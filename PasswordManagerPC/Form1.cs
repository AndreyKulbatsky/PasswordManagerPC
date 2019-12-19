using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerPC
{
    //todo 
    //добавить hint в tbKeyPhrase
    //добавить about
    //реализовать набор по кнопке "набрать"

    public partial class MainForm : Form
    {
        public static string Version = "1.2";
        private int currentPasswordLength;
        IniFile INI = new IniFile("config.ini");

        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Visible = false;
            Settings_read();
            tbKeyPhrase.TextChanged += new EventHandler(this.TbKeyPhrase_TextChanged);
            this.cbOnTop.CheckedChanged += new System.EventHandler(this.CbOnTop_CheckedChanged);
            cbPassLength.SelectedIndexChanged += new EventHandler(this.CbPassLength_SelectedIndexChanged);
            notifyIcon.MouseClick += new MouseEventHandler(NotifyIcon_MouseClick);
            this.Resize += new EventHandler(MainForm_Resize);
        }

        private void Settings_read()
        {
            if (INI.KeyExists("Settings", "Length"))
            {
                currentPasswordLength = int.Parse(INI.Read("Settings", "Length"));
                cbPassLength.SelectedIndex = currentPasswordLength - 8;
            }
            else
            {
                currentPasswordLength = 8;
                cbPassLength.SelectedIndex = 0;
            }
            if (INI.KeyExists("Settings", "OnTop"))
            {
                bool onTop = bool.Parse(INI.Read("Settings", "OnTop"));
                if (onTop)
                {
                    this.TopMost = true;
                    cbOnTop.CheckState = CheckState.Checked;
                }
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void TbKeyPhrase_TextChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void CbPassLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPasswordLength = cbPassLength.SelectedIndex + 8;
            INI.Write("Settings", "Length", currentPasswordLength.ToString());
            ShowPassword();
            tbKeyPhrase.Focus();
        }

        private void ShowPassword() {
            if (tbKeyPhrase.Text != "")
            {
                MD5 md5 = MD5.Create();
                tbPass.Text = Convert.ToBase64String(md5.ComputeHash(Encoding.ASCII.GetBytes(tbKeyPhrase.Text))).Substring(0, currentPasswordLength);
                bpPassCopy.Enabled = true;
//                btPassWrite.Enabled = true;
            }
            else
            {
                tbPass.Text = "";
                bpPassCopy.Enabled = false;
                btPassWrite.Enabled = false;
            }
        }

        private void BpPassCopy_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(tbPass.Text);
                tbKeyPhrase.Focus();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += Version;
        }

        private void CbOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnTop.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;

            INI.Write("Settings", "OnTop", cbOnTop.Checked.ToString());
            tbKeyPhrase.Focus();
        }
    }
}
