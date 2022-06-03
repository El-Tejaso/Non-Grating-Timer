namespace NonGrateingTimer
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._renderTimer = new System.Windows.Forms.Timer(this.components);
            this._timerLabel = new System.Windows.Forms.Label();
            this._startButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._subtract1Hour = new System.Windows.Forms.Button();
            this._addOneHour = new System.Windows.Forms.Button();
            this._addOneMinute = new System.Windows.Forms.Button();
            this._addOneSecond = new System.Windows.Forms.Button();
            this._subtractOneSecond = new System.Windows.Forms.Button();
            this._subtractOneMinute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _renderTimer
            // 
            this._renderTimer.Tick += new System.EventHandler(this._renderTimerTick);
            // 
            // _timerLabel
            // 
            this._timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._timerLabel.Font = new System.Drawing.Font("Consolas", 64F);
            this._timerLabel.Location = new System.Drawing.Point(-1, 12);
            this._timerLabel.Margin = new System.Windows.Forms.Padding(10);
            this._timerLabel.Name = "_timerLabel";
            this._timerLabel.Size = new System.Drawing.Size(857, 126);
            this._timerLabel.TabIndex = 0;
            this._timerLabel.Text = "1h:00m:00s:000ms";
            this._timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _startButton
            // 
            this._startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._startButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._startButton.Location = new System.Drawing.Point(869, 12);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(103, 58);
            this._startButton.TabIndex = 5;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this._startButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._stopButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._stopButton.Location = new System.Drawing.Point(869, 76);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(103, 62);
            this._stopButton.TabIndex = 6;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
            // 
            // _subtract1Hour
            // 
            this._subtract1Hour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._subtract1Hour.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._subtract1Hour.Location = new System.Drawing.Point(24, 116);
            this._subtract1Hour.Name = "_subtract1Hour";
            this._subtract1Hour.Size = new System.Drawing.Size(118, 22);
            this._subtract1Hour.TabIndex = 7;
            this._subtract1Hour.Text = "▼";
            this._subtract1Hour.UseVisualStyleBackColor = true;
            this._subtract1Hour.Click += new System.EventHandler(this._subtract1Hour_Click);
            // 
            // _addOneHour
            // 
            this._addOneHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._addOneHour.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addOneHour.Location = new System.Drawing.Point(24, 12);
            this._addOneHour.Name = "_addOneHour";
            this._addOneHour.Size = new System.Drawing.Size(118, 22);
            this._addOneHour.TabIndex = 11;
            this._addOneHour.Text = "▲";
            this._addOneHour.UseVisualStyleBackColor = true;
            this._addOneHour.Click += new System.EventHandler(this._addOneHour_Click);
            // 
            // _addOneMinute
            // 
            this._addOneMinute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._addOneMinute.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addOneMinute.Location = new System.Drawing.Point(169, 12);
            this._addOneMinute.Name = "_addOneMinute";
            this._addOneMinute.Size = new System.Drawing.Size(183, 22);
            this._addOneMinute.TabIndex = 12;
            this._addOneMinute.Text = "▲";
            this._addOneMinute.UseVisualStyleBackColor = true;
            this._addOneMinute.Click += new System.EventHandler(this._addOneMinute_Click);
            // 
            // _addOneSecond
            // 
            this._addOneSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._addOneSecond.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addOneSecond.Location = new System.Drawing.Point(391, 12);
            this._addOneSecond.Name = "_addOneSecond";
            this._addOneSecond.Size = new System.Drawing.Size(164, 22);
            this._addOneSecond.TabIndex = 13;
            this._addOneSecond.Text = "▲";
            this._addOneSecond.UseVisualStyleBackColor = true;
            this._addOneSecond.Click += new System.EventHandler(this._addOneSecond_Click);
            // 
            // _subtractOneSecond
            // 
            this._subtractOneSecond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._subtractOneSecond.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._subtractOneSecond.Location = new System.Drawing.Point(391, 116);
            this._subtractOneSecond.Name = "_subtractOneSecond";
            this._subtractOneSecond.Size = new System.Drawing.Size(164, 22);
            this._subtractOneSecond.TabIndex = 9;
            this._subtractOneSecond.Text = "▼";
            this._subtractOneSecond.UseVisualStyleBackColor = true;
            this._subtractOneSecond.Click += new System.EventHandler(this._subtractOneSecond_Click);
            // 
            // _subtractOneMinute
            // 
            this._subtractOneMinute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._subtractOneMinute.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._subtractOneMinute.Location = new System.Drawing.Point(169, 116);
            this._subtractOneMinute.Name = "_subtractOneMinute";
            this._subtractOneMinute.Size = new System.Drawing.Size(183, 22);
            this._subtractOneMinute.TabIndex = 8;
            this._subtractOneMinute.Text = "▼";
            this._subtractOneMinute.UseVisualStyleBackColor = true;
            this._subtractOneMinute.Click += new System.EventHandler(this._subtractOneMinute_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 150);
            this.Controls.Add(this._addOneSecond);
            this.Controls.Add(this._addOneMinute);
            this.Controls.Add(this._addOneHour);
            this.Controls.Add(this._subtractOneSecond);
            this.Controls.Add(this._subtractOneMinute);
            this.Controls.Add(this._subtract1Hour);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._timerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer _renderTimer;
        private System.Windows.Forms.Label _timerLabel;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.Button _subtract1Hour;
        private System.Windows.Forms.Button _addOneHour;
        private System.Windows.Forms.Button _addOneMinute;
        private System.Windows.Forms.Button _addOneSecond;
        private System.Windows.Forms.Button _subtractOneSecond;
        private System.Windows.Forms.Button _subtractOneMinute;
    }
}

