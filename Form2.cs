using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poe
{
    public partial class Form2 : Form
    {
        public Form2(Form callingForm)
        {
            InitializeComponent();
            this.TopMost = true;
            mainForm = callingForm as Form1;
        }
        private Form1 mainForm = null;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            mainForm.OpacityS = bunifuHSlider1.Value / 100.0;
            Properties.Settings.Default.OpacityS = bunifuHSlider1.Value / 100.0;
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked == true)
            {
                mainForm.WayPointS = true;
                Properties.Settings.Default.WayPointS = true;
            }
            else
            {
                mainForm.WayPointS = false;
                Properties.Settings.Default.WayPointS = false;
            }
        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox2.Checked == true)
            {
                mainForm.LabS = true;
                Properties.Settings.Default.LabS = true;
            }
            else
            {
                mainForm.LabS = false;
                Properties.Settings.Default.LabS = false;
            }
        }

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.Enter)
            {
                bunifuTextBox1.Text = (e.KeyCode.ToString());
                SendKeys.Send("{TAB}");
                Keys KeyNext = (Keys)Enum.Parse(typeof(Keys), e.KeyCode.ToString(), ignoreCase: true);
                Properties.Settings.Default.KeyNext = (KeyNext);
            }
        }

        private void bunifuTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.Enter)
            {
                bunifuTextBox2.Text = (e.KeyCode.ToString());
                SendKeys.Send("{TAB}");
                Keys KeyPrevious = (Keys)Enum.Parse(typeof(Keys), e.KeyCode.ToString(), ignoreCase: true);
                Properties.Settings.Default.KeyPrevious = (KeyPrevious);
            }
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch1.Checked == true)
            {
                mainForm.BackColor = Color.FromArgb(0, 7, 22);
                Properties.Settings.Default.ColorB = true;
            }
            else
            {
                mainForm.BackColor = Color.White;
                Properties.Settings.Default.ColorB = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ColorB == true)
            {
                bunifuToggleSwitch1.Checked = true;
            }
            else
            {
                bunifuToggleSwitch1.Checked = false;
            }
            bunifuTextBox1.Text = (Properties.Settings.Default.KeyNext.ToString());
            bunifuTextBox2.Text = (Properties.Settings.Default.KeyPrevious.ToString());
            ConvertNum(sender, e);
            if (Properties.Settings.Default.WayPointS == true)
            {
                bunifuCheckBox1.Checked = true;
            }
            else
            {
                bunifuCheckBox1.Checked = false;
            }
            if(Properties.Settings.Default.LabS == true)
            {
                bunifuCheckBox2.Checked = true;
            }
            else
            {
                bunifuCheckBox2.Checked = false;
            }
            var d = Properties.Settings.Default.OpacityS * 100;
            bunifuHSlider1.Value = (int)d;

            if (mainForm.start == false)
            {
                bunifuDropdown1.SelectedItem = "Manual";
            }
        }

        void ConvertNum(object sender, EventArgs e)
        {
            foreach (Bunifu.UI.WinForms.BunifuTextBox control in tabPage1.Controls.OfType <Bunifu.UI.WinForms.BunifuTextBox>())
            {
                if (control.Text == "NUMPAD1")
                {
                    control.Text = "1";
                }
                if (control.Text == "NUMPAD2")
                {
                    control.Text = "2";
                }
                if (control.Text == "NUMPAD3")
                {
                    control.Text = "3";
                }
                if (control.Text == "NUMPAD4")
                {
                    control.Text = "4";
                }
                if (control.Text == "NUMPAD5")
                {
                    control.Text = "5";
                }
                if (control.Text == "NUMPAD6")
                {
                    control.Text = "6";
                }
                if (control.Text == "NUMPAD7")
                {
                    control.Text = "7";
                }
                if (control.Text == "NUMPAD8")
                {
                    control.Text = "8";
                }
                if (control.Text == "NUMPAD9")
                {
                    control.Text = "9";
                }
            }
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            ConvertNum(sender, e);
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            ConvertNum(sender, e);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage4);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/c/EngineeringEternity");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.twitch.tv/engineeringeternity");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if(bunifuTextBox3.Text == "")
            {
                MessageBox.Show("Please enter Name");
            }
            else if (bunifuTextBox4.Text == "")
            {
                MessageBox.Show("Please enter Subject");
            }
            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please write your message");
            }
            else
            {
                CreateTestMessage2();
            }
        }

        private void CreateTestMessage2()
        {
            SmtpClient client = new SmtpClient("smtp-relay.sendinblue.com", 587);

            NetworkCredential basicCredential = new NetworkCredential("gonsteal@gmail.com", "J46VCBtmWsvZz7aT");
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential;

            MailAddress from = new MailAddress(bunifuTextBox3.Text+"@hotmail.com");
            MailAddress to = new MailAddress("tocheun14@hotmail.fr"); // recepient
            MailMessage message = new MailMessage(from, to);

            message.Subject = bunifuTextBox4.Text;
            message.Body = richTextBox1.Text;

            client.Send(message);
            MessageBox.Show("Message sent!");
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            string clientpath = mainForm.clientpath;
            var p = Process.GetProcessesByName("PathOfExileSteam");
            if(p.Length >= 1)
            {
                MessageBox.Show("Please, close Path Of Exile first");
            }
            else
            {
                mainForm.start = false;
                using (StreamWriter sw = new StreamWriter(clientpath))
                {
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    MessageBox.Show("Cache cleared!");
                    mainForm.start = true;
                }
            }
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.Text == "Manual")
            {
                mainForm.start = false;
            }
            else
            {
                mainForm.start = true;
            }
            if (bunifuDropdown1.Text == "Automatic Simplified")
            {
                UserControl1 customControl = new UserControl1();
                Form newForm = new Form();
                newForm.Controls.Add(customControl);
                newForm.BackColor = Color.Black;
                newForm.TransparencyKey = Color.Black;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Size = new Size (216, 348);
                newForm.StartPosition = FormStartPosition.CenterScreen;
                newForm.TopMost = true;
                newForm.Show();
                mainForm.Hide();
            }
            else
            {
                mainForm.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }
    }
}
