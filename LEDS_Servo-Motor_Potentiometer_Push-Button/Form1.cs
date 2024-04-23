﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDS_Servo_Motor_Potentiometer_Push_Button
{
    public partial class Form1 : Form
    {
        public delegate void delegate1(String dataReceived); // Useful for aligning different running threads
        private static int buttonCounter;

        private String redValue;
        private String yellowValue;
        private String greenValue;
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open(); // Change the COM number, mine is COM6
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String inputData = serialPort1.ReadLine();
            delegate1 writeData = new delegate1(changeTextIntoCounterData);
            Invoke(writeData, inputData);
        }

        public void changeTextIntoCounterData(String inputData)
        {
            // Handles data sent from Arduino
            char firstChar;

            firstChar = inputData[0];

            switch (firstChar)
            {
                case 'p':
                    buttonCounter++;
                    buttonCounterRichTextBox.Text = Convert.ToString(buttonCounter);
                    break;
            }
        }

        private void redLEDTrackBar_Scroll(object sender, EventArgs e)
        {
            redValue = "Red" + redLEDTrackBar.Value;
        }
        private void redLEDButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(redValue))
            {
                redValue = "Red0";
            }
            serialPort1.Write(redValue);
        }
        private void yellowLEDTrackBar_Scroll(object sender, EventArgs e)
        {
            yellowValue = "Yellow" + yellowLEDTrackBar.Value;
        }

        private void yellowLEDButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(yellowValue))
            {
                redValue = "Yellow0";
            }
            serialPort1.Write(yellowValue);
        }

        private void greenLEDTrackBar_Scroll(object sender, EventArgs e)
        {
            greenValue = "Green" + greenLEDTrackBar.Value;
        }

        private void greenLEDButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(greenValue))
            {
                redValue = "Green0";
            }
            serialPort1.Write(greenValue);
        }

        private void servoAngleButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Servo" + servoAngle.Text);
        }
    }
}
