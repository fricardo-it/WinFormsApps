using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;
using System.Text.RegularExpressions;

namespace WinFormsFinalProject
{
    public partial class TempConv : Form
    {
        public TempConv()
        {
            InitializeComponent();
        }

        // Data to txt file
        string dir = @".\files\";
        string file = "TempConv.txt";
        string name = "Temperature Conversion";

        // format to save in the txt file
        // 100 C = 212 F, 2023/3/22 01:01:33 PM Water Boils
        // 104 F = 40 C, 2023/3/22 10:07:03 PM Hot Bath

        public void createFile(string dir, string file, string name, string txt, string msg)
        {
            DateTime currentDate = DateTime.Now;

            try
            {
                string path = Path.Combine(dir, file);

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(path, true);    //Pass the filepath and filename to the StreamWriter Constructor
                    sw.WriteLine($"{txt}, {currentDate} {msg}");  //Write a line of text
                    sw.Close();
                }
                //Close the file
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            // clear the Convert value alwways radiobutton checked changed
            textBox1.Text = "";
            lbMessage.Text = "";
            lbValueTo.Text = "";

            if (radioButton1.Checked)
            {
                lbTextFrom.Text = "C";
                lbTextTo.Text = "F";
            }
            else if (radioButton2.Checked)
            {
                lbTextFrom.Text = "F";
                lbTextTo.Text = "C";
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal c = 0;
            decimal f = 0;

            Regex formatNumber = new Regex(@"^[+-]?\d+(\.\d+)?$");

            try
            {
                //validate if format number is: +NN, -NN or NN, w/ or w/o decimal numbers
                if ( formatNumber.IsMatch(textBox1.Text))
                {
                    if (radioButton1.Checked)
                    {
                        c = decimal.Parse(textBox1.Text); 

                        f = (c * 9 / 5) + 32;
                        f = decimal.Round(f,1);

                        lbValueTo.Text = f.ToString();

                        switch (f)
                        {
                            case var n when (n > 100 && n != 104 && n != 212):
                                {
                                    lbMessage.ForeColor = Color.Red;
                                    lbMessage.Text = "Scalding Water";
                                    lbValueTo.ForeColor = Color.Red;
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                            case 212:
                                {
                                    lbMessage.ForeColor = Color.Red;
                                    lbMessage.Text = "Water boils";
                                    lbValueTo.ForeColor = Color.Red;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 104:
                                {
                                    lbMessage.ForeColor = Color.Red;
                                    lbMessage.Text = "Hot Bath";
                                    lbValueTo.ForeColor = Color.Red;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case var n when (n >= 60 && n < 100 && n != 70 && n != 86 && n != 98.6m):
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Comfortable Temperature";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                            case 98.6m:
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Body Temperature";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 86:
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Beach Water";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 70:
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Room Temperature";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Regular);
                                    break;
                                }
                            case var n when (n < 60 && n != 50 && n != 32 && n != 0 && n != -40):
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Cold Day";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                            case 50:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Cool Day";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 32:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Freezing point of water";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);

                                    break;
                                }
                            case 0:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Very Cold Day";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Regular);
                                    break;
                                }
                            case -40:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Extremaly Cold Day\n(and the same number!)";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            default:
                                {
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        f = decimal.Parse(textBox1.Text);

                        c = (f - 32) * 5 / 9;
                        c = decimal.Round(c, 1);

                        lbValueTo.Text = c.ToString();
                        switch (c)
                        {
                            case var n when (n > 40 && n != 100):
                                {
                                    lbMessage.ForeColor = Color.Red;
                                    lbMessage.Text = "Scalding Water";
                                    lbValueTo.ForeColor = Color.Red;
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                            case 100:
                                {
                                    lbMessage.ForeColor = Color.Red;
                                    lbMessage.Text = "Water boils";
                                    lbValueTo.ForeColor = Color.Red;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 40:
                                {
                                    lbMessage.ForeColor = Color.Red;
                                    lbMessage.Text = "Hot Bath";
                                    lbValueTo.ForeColor = Color.Red;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case var n when(n > 15 && n < 40 && n != 37 && n != 30 && n != 21):
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Comfortable Temperature";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                            case 37:
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Body Temperature";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 30:
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Beach Water";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 21:
                                {
                                    lbMessage.ForeColor = Color.Green;
                                    lbMessage.Text = "Room Temperature";
                                    lbValueTo.ForeColor = Color.Green;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case var n when (n < 15 && n != 10 && n != 0 && n != -40):
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Cold Day";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                            case 10:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Cool Day";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case 0:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Freezing point of water";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);

                                    break;
                                }
                            case (-18):
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Very Cold Day";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            case -40:
                                {
                                    lbMessage.ForeColor = Color.Blue;
                                    lbMessage.Text = "Extremaly Cold Day\n(and the same number!)";
                                    lbValueTo.ForeColor = Color.Blue;
                                    lbValueTo.Font = new Font(lbValueTo.Font, FontStyle.Bold);
                                    break;
                                }
                            default:
                                {
                                    lbValueTo.Font = new Font(textBox1.Font, FontStyle.Regular);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input a value to convert", "Convert Value", MessageBoxButtons.OK);
                        textBox1.Focus();
                    }

                    // txt = initial value + C/F = converted value + F/C
                    string txt = textBox1.Text + " " + lbTextFrom.Text + " = " + lbValueTo.Text + " " + lbTextFrom.Text;
                    string msg = lbMessage.Text.Replace("\n", " ");
                    createFile(dir, file, name, txt, msg);    //Create text file. 
                }
                else
                {
                    MessageBox.Show("Input a value to convert", "Convert Value", MessageBoxButtons.OK);
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title = "Temperature Conversion";

            if (MessageBox.Show("Do you want to quit the main \n" + title + "?", "Exit " + title, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void showMsgModal(string title, string msg)
        {

            ShowMsg msgModal = new ShowMsg();
            msgModal.Text = title;
            msgModal.textBox1.Text = (msg);
            msgModal.ShowDialog();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(dir, file);
            string title = "Temperature Conversion";
            string textToPrint = "";
            FileStream stream = null;

            try
            {
                using (stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (reader.Peek() != -1)
                    {
                        string line = reader.ReadLine();
                        // inc the text, each one per new line
                        textToPrint += line + "\r\n";
                    }

                    // call the modal form, putting the text and title.
                    showMsgModal(title, textToPrint);

                    reader.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("IO Exception\n" + ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
