/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RunProgress();

        }

        /// <summary>
        /// This function run a processing and display the progress with RuProgressBar
        /// </summary>
        public void RunProgress()
        {
            try
            {
                // Init RuProgressBar
                ProgressWindow progress = new ProgressWindow();

                // Text
                progress.Text = "FM in operation";

                // Run application with RuProgressBar
                System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(Test), progress);
                progress.ShowDialog();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }

        }
        /// <summary>
        ///  Function of progress should appear 
        /// </summary>
        /// <param name="status"></param>
        public void Test(object status)
        {
            try
            {
                IProgressCallback callback = status as IProgressCallback;

                // Initiate the RuProgressBar with the maximum possible number
                int iMax = 1000000;

                // Only every n change should be displayed
                int divisor = 10 ; 

                // Start the progressbar
                callback.Begin(0, iMax / divisor);

                // *******************************************
                // Here you enter what your function should do
                // *******************************************
                // Process for example in a loop
                for (int i = 0; i < iMax; i++)
                {
                    if (i % divisor == 0 & i > 0)
                    {
                        // Change Progressbar
                        callback.StepTo(i / divisor);
                    }

                }
                // End process
                callback.End();

            }
            catch (System.FormatException)
            {
            }
        }
}
*/