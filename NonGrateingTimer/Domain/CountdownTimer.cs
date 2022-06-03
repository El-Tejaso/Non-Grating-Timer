using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGrateingTimer
{
    public interface IDateTimeProvider
    {
        DateTime Now();
    }

    //A state machine.
    public class CountdownTimer
    {
        IDateTimeProvider dateTimeProvider;

        private TimeSpan duration;
        private DateTime startedTime;

        private bool started = false;
        private bool paused = false;

        public bool IsCountingDown { get { return !paused && started; } }
        public bool IsStarted { get { return started; } }
        public bool IsPaused { get { return paused; } }

        public TimeSpan Duration {
            get {
                return duration;
            }
            set {
                duration = value;

                OnStateChanged?.Invoke();
            }
        }

        public TimeSpan RemainingTime {
            get {
                if (IsCountingDown)
                {
                    TimeSpan remainingTime = startedTime + duration - dateTimeProvider.Now();
                    if (remainingTime < TimeSpan.Zero)
                    {
                        Stop();
                        OnNoTimeRemaining?.Invoke();
                        return TimeSpan.Zero;
                    }

                    return remainingTime;
                }

                return duration;
            }
        }

        public event Action OnNoTimeRemaining;
        public event Action OnStart;
        public event Action OnPause;
        public event Action OnStop;
        public event Action OnStateChanged;

        public CountdownTimer(IDateTimeProvider provider)
        {
            dateTimeProvider = provider;
            duration = TimeSpan.Zero;
            startedTime = provider.Now();
        }

        public void StartOrResume()
        {
            paused = false;

            if (!started)
            {
                start();
            }
            else
            {
                resume();
            }

            OnStart?.Invoke();
            OnStateChanged?.Invoke();
        }

        private void start()
        {
            started = true;
            startedTime = dateTimeProvider.Now();
        }

        private void resume()
        {
            paused = false;
            startedTime = dateTimeProvider.Now();
        }

        public void Pause()
        {
            paused = true;

            duration = calculateRemainingTime();

            OnPause.Invoke();
            OnStateChanged?.Invoke();
        }

        private TimeSpan calculateRemainingTime()
        {
            return (startedTime + duration) - dateTimeProvider.Now();
        }

        public void Stop()
        {
            started = false;
            paused = false;
            duration = new TimeSpan(0);

            OnStop?.Invoke();
            OnStateChanged?.Invoke();
        }
    }
}
