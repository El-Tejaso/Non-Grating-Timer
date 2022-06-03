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

namespace NonGrateingTimer {
    public partial class Window : Form {
        private TimeSpan _maxDuration = new TimeSpan(0, 9, 59, 59, 999);
        private CountdownTimer _timerState;
        private ITimeFormatter _formatter;
        private bool _unresolved = false;

        const int WINDOW_SPEED = 30;

        private int _xDir = 1, _yDir = 1;

        public Window() {
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

        private void _timerState_OnNoTimeRemaining() {
            _timerLabel.ForeColor = Color.Red;
            _unresolved = true;
            bringWindowToFront();
        }

        private void _timerState_OnStateChanged() {
            updateTimerDisplayedTime();
            _timerLabel.ForeColor = Color.Black;
            _unresolved = false;
            TopMost = false;
        }

        private void _timerState_OnStop() {
            _startButton.Text = "Start";
        }

        private void _timerState_OnPause() {
            _startButton.Text = "Resume";
            TopMost = false;
        }

        private void _timerState_OnStart() {
            _startButton.Text = "Pause";
            _renderTimer.Start();
            TopMost = false;
        }

        private void initRenderTimer() {
            int FPS = 30;
            _renderTimer.Interval = 1000 / FPS;
            _renderTimer.Stop();
        }

        private void updateTimerDisplayedTime() {
            _timerLabel.Text = _formatter.FormatTime(_timerState.RemainingTime);
        }

        private void bringWindowToFront() {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            Activate();
            TopMost = true;

            Console.WriteLine("Focused");
        }

        private void _startButton_Click(object sender, EventArgs e) {
            if (!_timerState.IsCountingDown) {
                _timerState.StartOrResume();
            } else {
                _timerState.Pause();
            }
        }

        private void _stopButton_Click(object sender, EventArgs e) {
            StopTimer();
        }

        private void StopTimer() {
            _timerState.Stop();
            _startButton.Text = "Start";
        }


        private void addTime(int h, int m, int s) {
            if ((ModifierKeys & Keys.Shift) == Keys.Shift) {
                h *= 10; m *= 10; s *= 10;
            }

            TimeSpan timeDelta = new TimeSpan(h, m, s);

            if (_timerState.Duration + timeDelta > _maxDuration) {
                _timerState.Duration = _maxDuration;
            } else if (_timerState.Duration + timeDelta < TimeSpan.Zero) {
                _timerState.Duration = TimeSpan.Zero;
            } else {
                _timerState.Duration += timeDelta;
            }
        }

        private void _renderTimerTick(object sender, EventArgs e) {
            updateTimerDisplayedTime();

            if (!_unresolved)
                return;

            var loc = DesktopLocation;
            if (loc.X + Bounds.Width > Screen.FromControl(this).Bounds.Width) {
                _xDir = -1;
            } else if (loc.X < 0) {
                _xDir = 1;
            }

            if (loc.Y + Bounds.Height > Screen.FromControl(this).Bounds.Height) {
                _yDir = -1;
            } else if (loc.Y < 0) {
                _yDir = 1;
            }

            loc.X += WINDOW_SPEED * _xDir;
            loc.Y += WINDOW_SPEED * _yDir;

            DesktopLocation = loc;
        }

        private void _addOneHour_Click(object sender, EventArgs e) {
            addTime(1, 0, 0);
        }

        private void _addOneMinute_Click(object sender, EventArgs e) {
            addTime(0, 1, 0);
        }

        private void _addOneSecond_Click(object sender, EventArgs e) {
            addTime(0, 0, 1);
        }

        private void _subtract1Hour_Click(object sender, EventArgs e) {
            addTime(-1, 0, 0);
        }

        private void _subtractOneMinute_Click(object sender, EventArgs e) {
            addTime(0, -1, 0);
        }

        private void _subtractOneSecond_Click(object sender, EventArgs e) {
            addTime(0, 0, -1);
        }
    }
}
