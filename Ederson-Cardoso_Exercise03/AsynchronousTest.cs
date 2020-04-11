using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ederson_Cardoso_Exercise03
{
    public partial class AsynchronousTestForm : Form
    {
        public AsynchronousTestForm()
        {
            InitializeComponent();
        }

        // start asynchronous calls to Fibonacci
        private async void startButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "Starting Task1 to calculate Factorial(46)\r\n";
            
            // create Task to perform Factorial(46) calculation in a thread
            Task<TimeData> task1 = Task.Run(() => StartFactorial(46));

            outputTextBox.AppendText("Starting Task2 to calculate Fibonacci(45)\r\n");

            // create Task to perform Fibonacci(45) calculation in a thread
            Task<TimeData> task2 = Task.Run(() => StartFibonacci(45));

            outputTextBox.AppendText("Starting Task3 to calculate RollDie(60_000_000)\r\n");

            // create Task to perform RollDie(60_000_000) calculation in a thread
            Task<TimeData> task3 = Task.Run(() => StartRollDie(60_000_000));

            await Task.WhenAll(task1, task2, task3); // wait for all tasks to complete

            // determine time that first thread started
            List<DateTime> listStartTime = new List<DateTime>();
            listStartTime.Add(task1.Result.StartTime);
            listStartTime.Add(task2.Result.StartTime);
            listStartTime.Add(task3.Result.StartTime);

            DateTime startTime = listStartTime.Min(start => start);

            // determine time that last thread ended
            List<DateTime> listEndTime = new List<DateTime>();
            listEndTime.Add(task1.Result.EndTime);
            listEndTime.Add(task2.Result.EndTime);
            listEndTime.Add(task3.Result.EndTime);

            DateTime endTime = listEndTime.Max(end => end);

            // display total time for calculations
            double totalMinutes = (endTime - startTime).TotalMinutes;
            outputTextBox.AppendText($"Total calculation time = {totalMinutes:F6} minutes\r\n");
        }

        #region Factorial
        /// <summary>
        /// This method starts a Factorial method and captures start/end times
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        TimeData StartFactorial(BigInteger n)
        {
            // create a TimeData object to store start/end times
            var result = new TimeData();

            AppendText($"Calculating Factorial({n})\r\n");
            result.StartTime = DateTime.Now;
            BigInteger factorialValue = CalculateFactorial(n);
            result.EndTime = DateTime.Now;

            AppendText($"Factorial({n}) = {factorialValue}");
            double minutes = (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculation time = {minutes:F6} minutes\r\n");

            return result;
        }

        /// <summary>
        /// This method returns a factorial of a number using recursion
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public BigInteger CalculateFactorial(BigInteger num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                try
                {
                    return checked(num * CalculateFactorial(num - 1));
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }
        } // end CalculateFactorial
        #endregion

        #region Fibonacci
        /// <summary>
        /// This method starts a Fibonacci method and captures start/end times
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        TimeData StartFibonacci(int n)
        {
            // create a TimeData object to store start/end times
            var result = new TimeData();

            AppendText($"Calculating Fibonacci({n})");
            result.StartTime = DateTime.Now;
            long fibonacciValue = Fibonacci(n);
            result.EndTime = DateTime.Now;

            AppendText($"Fibonacci({n}) = {fibonacciValue}");
            double minutes = (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculation time = {minutes:F6} minutes\r\n");

            return result;
        }

        /// <summary>
        /// This method calculates a Fibonacci of a number using recursion
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        #endregion

        #region Die
        /// <summary>
        /// This method starts a RollDie method and captures start/end times
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        TimeData StartRollDie(long n)
        {
            // create a TimeData object to store start/end times
            var result = new TimeData();

            AppendText($"Calculating Factorial({n})");
            result.StartTime = DateTime.Now;
            RollDie(n);
            result.EndTime = DateTime.Now;

            double minutes = (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculation time = {minutes:F6} minutes\r\n");

            return result;
        }

        /// <summary>
        /// This method rolls a die and returns the most frequent face number
        /// </summary>
        public void RollDie(long maxRoll)
        {
            // random-number generator
            var random = new Random();
            
            // array of frequency counters
            var frequency = new int[7];

            // roll die maxRoll times; use die value as frequency index
            for (var roll = 1; roll <= maxRoll; ++roll)
            {
                ++frequency[random.Next(1, 7)];
            }

            // Identify the most frequent face
            int maxIndex = Array.IndexOf(frequency, frequency.Max());

            AppendText($"Most frequent die face = {maxIndex}");
        }
        #endregion

        /// <summary>
        /// This method append text to outputTextBox in UI thread
        /// </summary>
        /// <param name="text"></param>
        public void AppendText(String text)
        {
            if (InvokeRequired) // not GUI thread, so add to GUI thread
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else // GUI thread so append text
            {
                outputTextBox.AppendText(text + "\r\n");
            }
        }
    } // end class
} // end namespace
