
namespace LEDS_Servo_Motor_Potentiometer_Push_Button
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.greenLEDButton = new System.Windows.Forms.Button();
            this.greenLEDTrackBar = new System.Windows.Forms.TrackBar();
            this.yellowLEDButton = new System.Windows.Forms.Button();
            this.yellowLEDTrackBar = new System.Windows.Forms.TrackBar();
            this.redLEDButton = new System.Windows.Forms.Button();
            this.redLEDTrackBar = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCounterRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.servoAngleButton = new System.Windows.Forms.Button();
            this.servoAngle = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.potentiometerProgressBar = new System.Windows.Forms.ProgressBar();
            this.potentiometerStatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenLEDTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLEDTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLEDTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.greenLEDButton);
            this.groupBox1.Controls.Add(this.greenLEDTrackBar);
            this.groupBox1.Controls.Add(this.yellowLEDButton);
            this.groupBox1.Controls.Add(this.yellowLEDTrackBar);
            this.groupBox1.Controls.Add(this.redLEDButton);
            this.groupBox1.Controls.Add(this.redLEDTrackBar);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Controller";
            // 
            // greenLEDButton
            // 
            this.greenLEDButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.greenLEDButton.Location = new System.Drawing.Point(322, 203);
            this.greenLEDButton.Name = "greenLEDButton";
            this.greenLEDButton.Size = new System.Drawing.Size(125, 56);
            this.greenLEDButton.TabIndex = 5;
            this.greenLEDButton.Text = "Send Green";
            this.greenLEDButton.UseVisualStyleBackColor = true;
            this.greenLEDButton.Click += new System.EventHandler(this.greenLEDButton_Click);
            // 
            // greenLEDTrackBar
            // 
            this.greenLEDTrackBar.BackColor = System.Drawing.Color.LimeGreen;
            this.greenLEDTrackBar.Location = new System.Drawing.Point(16, 203);
            this.greenLEDTrackBar.Maximum = 255;
            this.greenLEDTrackBar.Name = "greenLEDTrackBar";
            this.greenLEDTrackBar.Size = new System.Drawing.Size(284, 56);
            this.greenLEDTrackBar.TabIndex = 4;
            this.greenLEDTrackBar.TickFrequency = 15;
            this.greenLEDTrackBar.Scroll += new System.EventHandler(this.greenLEDTrackBar_Scroll);
            // 
            // yellowLEDButton
            // 
            this.yellowLEDButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowLEDButton.Location = new System.Drawing.Point(322, 121);
            this.yellowLEDButton.Name = "yellowLEDButton";
            this.yellowLEDButton.Size = new System.Drawing.Size(125, 56);
            this.yellowLEDButton.TabIndex = 3;
            this.yellowLEDButton.Text = "Send Yellow";
            this.yellowLEDButton.UseVisualStyleBackColor = true;
            this.yellowLEDButton.Click += new System.EventHandler(this.yellowLEDButton_Click);
            // 
            // yellowLEDTrackBar
            // 
            this.yellowLEDTrackBar.BackColor = System.Drawing.Color.Gold;
            this.yellowLEDTrackBar.Location = new System.Drawing.Point(16, 121);
            this.yellowLEDTrackBar.Maximum = 255;
            this.yellowLEDTrackBar.Name = "yellowLEDTrackBar";
            this.yellowLEDTrackBar.Size = new System.Drawing.Size(284, 56);
            this.yellowLEDTrackBar.TabIndex = 2;
            this.yellowLEDTrackBar.TickFrequency = 15;
            this.yellowLEDTrackBar.Scroll += new System.EventHandler(this.yellowLEDTrackBar_Scroll);
            // 
            // redLEDButton
            // 
            this.redLEDButton.ForeColor = System.Drawing.Color.Red;
            this.redLEDButton.Location = new System.Drawing.Point(322, 41);
            this.redLEDButton.Name = "redLEDButton";
            this.redLEDButton.Size = new System.Drawing.Size(125, 56);
            this.redLEDButton.TabIndex = 1;
            this.redLEDButton.Text = "Send Red";
            this.redLEDButton.UseVisualStyleBackColor = true;
            this.redLEDButton.Click += new System.EventHandler(this.redLEDButton_Click);
            // 
            // redLEDTrackBar
            // 
            this.redLEDTrackBar.BackColor = System.Drawing.Color.Red;
            this.redLEDTrackBar.Location = new System.Drawing.Point(16, 41);
            this.redLEDTrackBar.Maximum = 255;
            this.redLEDTrackBar.Name = "redLEDTrackBar";
            this.redLEDTrackBar.Size = new System.Drawing.Size(284, 56);
            this.redLEDTrackBar.TabIndex = 0;
            this.redLEDTrackBar.TickFrequency = 15;
            this.redLEDTrackBar.Scroll += new System.EventHandler(this.redLEDTrackBar_Scroll);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.buttonCounterRichTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(518, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 176);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button Counter";
            // 
            // buttonCounterRichTextBox
            // 
            this.buttonCounterRichTextBox.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCounterRichTextBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonCounterRichTextBox.Location = new System.Drawing.Point(26, 40);
            this.buttonCounterRichTextBox.Name = "buttonCounterRichTextBox";
            this.buttonCounterRichTextBox.Size = new System.Drawing.Size(137, 108);
            this.buttonCounterRichTextBox.TabIndex = 0;
            this.buttonCounterRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox3.Controls.Add(this.servoAngleButton);
            this.groupBox3.Controls.Add(this.servoAngle);
            this.groupBox3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(729, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 176);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servo Controller";
            // 
            // servoAngleButton
            // 
            this.servoAngleButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.servoAngleButton.Location = new System.Drawing.Point(28, 107);
            this.servoAngleButton.Name = "servoAngleButton";
            this.servoAngleButton.Size = new System.Drawing.Size(156, 56);
            this.servoAngleButton.TabIndex = 6;
            this.servoAngleButton.Text = "Send Angle";
            this.servoAngleButton.UseVisualStyleBackColor = true;
            this.servoAngleButton.Click += new System.EventHandler(this.servoAngleButton_Click);
            // 
            // servoAngle
            // 
            this.servoAngle.Font = new System.Drawing.Font("Malgun Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoAngle.ForeColor = System.Drawing.Color.SeaGreen;
            this.servoAngle.Location = new System.Drawing.Point(28, 40);
            this.servoAngle.Name = "servoAngle";
            this.servoAngle.Size = new System.Drawing.Size(156, 61);
            this.servoAngle.TabIndex = 0;
            this.servoAngle.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox4.Controls.Add(this.potentiometerStatusRichTextBox);
            this.groupBox4.Controls.Add(this.potentiometerProgressBar);
            this.groupBox4.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Location = new System.Drawing.Point(518, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 92);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Potentiometer Value";
            // 
            // potentiometerProgressBar
            // 
            this.potentiometerProgressBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.potentiometerProgressBar.Location = new System.Drawing.Point(26, 29);
            this.potentiometerProgressBar.Maximum = 1023;
            this.potentiometerProgressBar.Name = "potentiometerProgressBar";
            this.potentiometerProgressBar.Size = new System.Drawing.Size(300, 38);
            this.potentiometerProgressBar.TabIndex = 0;
            // 
            // potentiometerStatusRichTextBox
            // 
            this.potentiometerStatusRichTextBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potentiometerStatusRichTextBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.potentiometerStatusRichTextBox.Location = new System.Drawing.Point(342, 29);
            this.potentiometerStatusRichTextBox.Name = "potentiometerStatusRichTextBox";
            this.potentiometerStatusRichTextBox.Size = new System.Drawing.Size(53, 38);
            this.potentiometerStatusRichTextBox.TabIndex = 1;
            this.potentiometerStatusRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 334);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenLEDTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLEDTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLEDTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yellowLEDButton;
        private System.Windows.Forms.TrackBar yellowLEDTrackBar;
        private System.Windows.Forms.Button redLEDButton;
        private System.Windows.Forms.TrackBar redLEDTrackBar;
        private System.Windows.Forms.Button greenLEDButton;
        private System.Windows.Forms.TrackBar greenLEDTrackBar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox buttonCounterRichTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button servoAngleButton;
        private System.Windows.Forms.RichTextBox servoAngle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar potentiometerProgressBar;
        private System.Windows.Forms.RichTextBox potentiometerStatusRichTextBox;
    }
}

