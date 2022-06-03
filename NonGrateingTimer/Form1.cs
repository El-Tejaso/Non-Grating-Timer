using NonGrateingTimer.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonGrateingTimer
{
    public partial class Window : Form
    {
        private TimeSpan _maxDuration = new TimeSpan(0, 9, 59, 59, 999);
        private CountdownTimer _timerState;
        private ITimeFormatter _formatter;

        private bool _addingTime = true;

        public Window()
        {
            InitializeComponent();

            _timerState = new CountdownTimer(new DefaultTimeProvider());
            _timerState.OnStart += _timerState_OnStart;
            _timerState.OnPause += _timerState_OnPause;
            _timerState.OnStop += _timerState_OnStop;
            _timerState.OnStateChanged += _timerState_OnStateChanged;
            _timerState.OnNoTimeRemaining += _timerState_OnNoTimeRemaining;

            _formatter = new DefaultTimeFormatter();

            initRenderTimer();

            updateTimerDisplayedTime();
        }

        private void _timerState_OnNoTimeRemaining()
        {
            _timerLabel.ForeColor = Color.Red;
            bringWindowToFront();
        }

        private void _timerState_OnStateChanged()
        {
            updateTimerDisplayedTime();
            _timerLabel.ForeColor = Color.Black;
        }

        private void _timerState_OnStop()
        {
            _startButton.Text = "Start";
            _renderTimer.Stop();
        }

        private void _timerState_OnPause()
        {
            _startButton.Text = "Resume";
            _renderTimer.Stop();
        }

        private void _timerState_OnStart()
        {
            _startButton.Text = "Pause";
            _renderTimer.Start();
        }

        private void initRenderTimer()
        {
            int FPS = 30;
            _renderTimer.Interval = 1000 / FPS;
            _renderTimer.Stop();
        }

        private void updateTimerDisplayedTime()
        {
            _timerLabel.Text = _formatter.FormatTime(_timerState.RemainingTime);
        }

        private void bringWindowToFront()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            Activate();
            Console.WriteLine("Focused");
        }

        private void _startButton_Click(object sender, EventArgs e)
        {
            if (!_timerState.IsCountingDown)
            {
                _timerState.StartOrResume();
            }
            else
            {
                _timerState.Pause();
            }
        }

        private void _stopButton_Click(object sender, EventArgs e)
        {
            _timerState.Stop();
            _timerLabel.ForeColor = Color.Black;
        }

        private void StopTimer()
        {
            _timerState.Stop();
            _renderTimer.Stop();

            _startButton.Text = "Start";
        }

        private void _add1HourButton_Click(object sender, EventArgs e)
        {
            addOrSubtractTime(1, 0, 0);
        }

        private void _add10MinButton_Click(object sender, EventArgs e)
        {
            addOrSubtractTime(0,10,0);
        }

        private void _add1MinButton_Click(object sender, EventArgs e)
        {
            addOrSubtractTime(0, 1, 0);
        }

        private void _add10SecButton_Click(object sender, EventArgs e)
        {
            addOrSubtractTime(0, 0, 10);
        }

        private void _add1SecButton_Click(object sender, EventArgs e)
        {
            addOrSubtractTime(0, 0, 1);
        }

        private void addOrSubtractTime(int h, int m, int s)
        {
            TimeSpan timeDelta = new TimeSpan(h, m, s);
            if (!_addingTime)
                timeDelta = -timeDelta;

            if (_timerState.Duration + timeDelta > _maxDuration)
            {
                _timerState.Duration = _maxDuration;
            }
            else if(_timerState.Duration + timeDelta < TimeSpan.Zero)
            {
                _timerState.Duration = TimeSpan.Zero;
            }
            else
            {
                _timerState.Duration += timeDelta;
            }
        }

        private void _renderTimerTick(object sender, EventArgs e)
        {
            updateTimerDisplayedTime();
        }

        private void _plusMinusToggleButton_Click(object sender, EventArgs e)
        {
            _addingTime = !_addingTime;
            _plusMinusToggleButton.Text = _addingTime ? "+" : "-";
        }
    }
}
