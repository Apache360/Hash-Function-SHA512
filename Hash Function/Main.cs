using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_Function
{
    public partial class windowMain : Form
    {
        public windowMain()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);
        }

        //16*16 115792089237316195423570985008687907853269984665640564039457584007913129639936
        //16*16 139008452377144732764939786789661303114218850808529137991604824430036072629766435941001769154109609521811665540548899435521
        public char separator;
        public string inputData; 
        public string outputHash; 
        public StringBuilder outputData;
        Stopwatch stopwatch = new Stopwatch();

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            setSeparator();
            inputData = richTextBoxInput1.Text;
            outputHash = SHA512(inputData);
            richTextBoxOutput1.Text = outputHash;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            buttonDecrypt.Enabled = false;
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }

            richTextBoxLog.Text += "Decrypting..." + Environment.NewLine;

            richTextBoxLog.Text+=("Time elapsed (ms): " + stopwatch.ElapsedMilliseconds)+Environment.NewLine;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Cancel the asynchronous operation.
            this.backgroundWorker1.CancelAsync();

            // Disable the Cancel button.
            buttonStop.Enabled = false;
            //stopwatch.Stop();
        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            stopwatch.Start();

            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            //e.Result = SHA512Decr(worker, e);
            SHA512Decr(richTextBoxOutput1.Text, worker, e);
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            richTextBoxLog.Text += (e.ProgressPercentage.ToString() + "%");
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopwatch.Stop();
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                richTextBoxLog.Text += "Canceled"+Environment.NewLine;
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                //richTextBoxLog.Text += e.Result.ToString();
            }
            // Enable the Start button.
            buttonDecrypt.Enabled = true;

            // Disable the Cancel button.
            buttonStop.Enabled = false;
            stopwatch.Reset();
        }

        public void setSeparator()
        {
            if (textBoxSeparator.Text.Length != 0)
            {
                separator = textBoxSeparator.Text[0];
            }
            else
            {
                separator = ';';
                textBoxSeparator.Text = ";";
            }
        }

        public void SHA512Decr(string inputHash, BackgroundWorker worker, DoWorkEventArgs e)
        {         
            setSeparator();
            int order = richTextBoxInput1.Text.Length;
            double count = Math.Pow(3, order);
            string str;
            for (double i = 0; i < count; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                outputData = new StringBuilder("", order);
                for (int j = 0; j < order; j++, outputData.Append("0")) { };
                str = DecimalToTernary(Convert.ToUInt32(i));
                outputData.Remove(outputData.Length - str.Length, str.Length);
                outputData.Append(str);
                outputData= outputData.Replace('2', separator);

                if (inputHash == SHA512(outputData.ToString()))
                {
                    richTextBoxLog.Text += "Iteration: " + i + ", Your Data: " + Environment.NewLine 
                        + outputData + Environment.NewLine
                        + "Time elapsed (ms): " + stopwatch.ElapsedMilliseconds + Environment.NewLine;
                    richTextBoxOutput2.Text = outputData.ToString();
                    break;
                }
                               
                if (i % 100000 == 0)
                {
                    worker.ReportProgress((int)((double)i / count * 100));
                    richTextBoxLog.AppendText(" Iteration: " + i 
                        + ", Time elapsed (ms): " + stopwatch.ElapsedMilliseconds 
                        + ", Current data: " + outputData + Environment.NewLine);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    richTextBoxLog.ScrollToCaret();
                }
            }
        }

        static string DecimalToTernary(uint decimalNumber)
        {
            var ternaryNumber = string.Empty;
            while (decimalNumber > 0)
            {
                ternaryNumber = (decimalNumber % 3) + ternaryNumber;
                decimalNumber /= 3;
            }
            return ternaryNumber;
        }

        public string SHA512(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            setSeparator();
            char[] array = new char[16];
            char[] filler = new char[3] { '1', '0', separator };
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                if (i>0)
                {

                    if (array[i - 1] != filler[filler.Length-1])
                    {
                        array[i] = filler[rand.Next(0, filler.Length)];
                    }
                    else
                    {
                        array[i] = filler[rand.Next(0, filler.Length - 1)];
                    }
                }
                else
                {
                    array[i] = filler[rand.Next(0, filler.Length-1)];
                }
            }
            inputData = new string (array);
            richTextBoxInput1.Text = inputData;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (richTextBoxOutput1.Text !="")
            {
                richTextBoxInput2.Text = richTextBoxOutput1.Text;
            }
            else
            {
                richTextBoxLog.Text += "Output hash is empty" + Environment.NewLine;
            }
        }
    }
}
