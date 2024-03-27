using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsFinalProject
{
    public partial class IP4_Validator : Form
    {
        private DateTime formLoadTime;

        // Data to txt file
        string dir = @".\files\";
        string file = "IP4-Validate.bin";

        public IP4_Validator()
        {
            InitializeComponent();
        }
        private bool ValidIP(string ip)
        {
            Regex myRegex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
            return myRegex.IsMatch(ip);
        }

        private void IP4_Validator_Load(object sender, EventArgs e)
        {
            // datetime today
           // DateTime currentDate = DateTime.Now;

            // write text + current date
            label1.Text += DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt");
            ;

            // start time when Load Form
            formLoadTime = DateTime.Now;
            timer1.Start();
        }

        private void IP4_Validator_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnValidateIP_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            try
            {
                string title = "alid IP";

                if (ValidIP(textBox1.Text.Trim()))
                {
                    MessageBox.Show(textBox1.Text.Trim() + "\nThe IP is correct", "V"+title, MessageBoxButtons.OK);
                    createBinaryFile(dir, file, (textBox1.Text.Trim() + "|" + Regex.Replace(label1.Text.Trim(),"Today is: ","")));
                }
                else
                {
                    MessageBox.Show(textBox1.Text + "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nsepareted by a dot (255.255.255.255)", "Inv" + title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title = "IP4_Validator";

            if (MessageBox.Show("Do you want to quit the application \n" + title + "?", "Exit " + title, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();

                // after close the form, stop the counter and show the total
                timer1.Stop();

                MessageBox.Show(label3.Text, "Total time today");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // stop time when Closing Form
            DateTime formCloseTime = DateTime.Now;

            // diff stop & start time
            TimeSpan timeSpent = formCloseTime - formLoadTime;
            int totalSec = (int)timeSpent.TotalSeconds;
            int totalMin = (int)timeSpent.TotalMinutes;

            label3.Text = string.Format("Total time today: {0:D2}:{1:D2}", totalMin, totalSec % 60);
        }

        public void createBinaryFile(string dir, string file, string txt)
        {
            // create filepath
            string path = Path.Combine(dir, file);
            // declarating the filestream and writer as binary
            FileStream fs = null;
            BinaryWriter binaryOut = null;

            try
            {
                if (!File.Exists(path))
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate);
                }

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                // create the output stream for a binary file that exists
                binaryOut = new BinaryWriter(fs);
                // write the fields into text file
                binaryOut.Write(txt);
                // close the output stream for the text file
                binaryOut.Close();
                fs.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error \n" + ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    binaryOut.Close();
                    fs.Close();
                }
            }
        }
    }
}
