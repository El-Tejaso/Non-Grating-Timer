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
            this._timerLabel = new System.Windows.Forms.Label();
            this._add10MinButton = new System.Windows.Forms.Button();
            this._add1MinButton = new System.Windows.Forms.Button();
            this._add10SecButton = new System.Windows.Forms.Button();
            this._add1SecButton = new System.Windows.Forms.Button();
            this._startButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._renderTimer = new System.Windows.Forms.Timer(this.components);
            this._add1HourButton = new System.Windows.Forms.Button();
            this._plusMinusToggleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _timerLabel
            // 
            this._timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._timerLabel.Font = new System.Drawing.Font("Consolas", 64F);
            this._timerLabel.Location = new System.Drawing.Point(0, 0);
            this._timerLabel.Margin = new System.Windows.Forms.Padding(10);
            this._timerLabel.Name = "_timerLabel";
            this._timerLabel.Size = new System.Drawing.Size(901, 158);
            this._timerLabel.TabIndex = 0;
            this._timerLabel.Text = "1h:00m:00s:000ms";
            this._timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _add10MinButton
            // 
            this._add10MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._add10MinButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._add10MinButton.Location = new System.Drawing.Point(172, 171);
            this._add10MinButton.Name = "_add10MinButton";
            this._add10MinButton.Size = new System.Drawing.Size(65, 38);
            this._add10MinButton.TabIndex = 1;
            this._add10MinButton.Text = "10min";
            this._add10MinButton.UseVisualStyleBackColor = true;
            this._add10MinButton.Click += new System.EventHandler(this._add10MinButton_Click);
            // 
            // _add1MinButton
            // 
            this._add1MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._add1MinButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._add1MinButton.Location = new System.Drawing.Point(243, 171);
            this._add1MinButton.Name = "_add1MinButton";
            this._add1MinButton.Size = new System.Drawing.Size(65, 38);
            this._add1MinButton.TabIndex = 2;
            this._add1MinButton.Text = "1min";
            this._add1MinButton.UseVisualStyleBackColor = true;
            this._add1MinButton.Click += new System.EventHandler(this._add1MinButton_Click);
            // 
            // _add10SecButton
            // 
            this._add10SecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._add10SecButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._add10SecButton.Location = new System.Drawing.Point(312, 171);
            this._add10SecButton.Name = "_add10SecButton";
            this._add10SecButton.Size = new System.Drawing.Size(65, 38);
            this._add10SecButton.TabIndex = 3;
            this._add10SecButton.Text = "10sec";
            this._add10SecButton.UseVisualStyleBackColor = true;
            this._add10SecButton.Click += new System.EventHandler(this._add10SecButton_Click);
            // 
            // _add1SecButton
            // 
            this._add1SecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._add1SecButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._add1SecButton.Location = new System.Drawing.Point(383, 171);
            this._add1SecButton.Name = "_add1SecButton";
            this._add1SecButton.Size = new System.Drawing.Size(65, 38);
            this._add1SecButton.TabIndex = 4;
            this._add1SecButton.Text = "1sec";
            this._add1SecButton.UseVisualStyleBackColor = true;
            this._add1SecButton.Click += new System.EventHandler(this._add1SecButton_Click);
            // 
            // _startButton
            // 
            this._startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._startButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._startButton.Location = new System.Drawing.Point(723, 171);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(80, 38);
            this._startButton.TabIndex = 5;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this._startButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._stopButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._stopButton.Location = new System.Drawing.Point(809, 171);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(80, 38);
            this._stopButton.TabIndex = 6;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
            // 
            // _renderTimer
            // 
            this._renderTimer.Tick += new System.EventHandler(this._renderTimerTick);
            // 
            // _add1HourButton
            // 
            this._add1HourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._add1HourButton.Font = new System.Drawing.Font("Consolas", 12F);
            this._add1HourButton.Location = new System.Drawing.Point(101, 171);
            this._add1HourButton.Name = "_add1HourButton";
            this._add1HourButton.Size = new System.Drawing.Size(65, 38);
            this._add1HourButton.TabIndex = 7;
            this._add1HourButton.Text = "1hr";
            this._add1HourButton.UseVisualStyleBackColor = true;
            this._add1HourButton.Click += new System.EventHandler(this._add1HourButton_Click);
            // 
            // _plusMinusToggleButton
            // 
            this._plusMinusToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._plusMinusToggleButton.Font = new System.Drawing.Font("Consolas", 18F);
            this._plusMinusToggleButton.Location = new System.Drawing.Point(12, 171);
            this._plusMinusToggleButton.Name = "_plusMinusToggleButton";
            this._plusMinusToggleButton.Size = new System.Drawing.Size(65, 38);
            this._plusMinusToggleButton.TabIndex = 8;
            this._plusMinusToggleButton.Text = "+";
            this._plusMinusToggleButton.UseVisualStyleBackColor = true;
            this._plusMinusToggleButton.Click += new System.EventHandler(this._plusMinusToggleButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 221);
            this.Controls.Add(this._plusMinusToggleButton);
            this.Controls.Add(this._add1HourButton);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._add1SecButton);
            this.Controls.Add(this._add10SecButton);
            this.Controls.Add(this._add1MinButton);
            this.Controls.Add(this._add10MinButton);
            this.Controls.Add(this._timerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _timerLabel;
        private System.Windows.Forms.Button _add10MinButton;
        private System.Windows.Forms.Button _add1MinButton;
        private System.Windows.Forms.Button _add10SecButton;
        private System.Windows.Forms.Button _add1SecButton;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.Timer _renderTimer;
        private System.Windows.Forms.Button _add1HourButton;
        private System.Windows.Forms.Button _plusMinusToggleButton;
    }
}

