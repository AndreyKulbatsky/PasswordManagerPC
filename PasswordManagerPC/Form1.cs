using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerPC
{
    //todo 

    //при старте фокус в tbKeyPhrase
    //добавить hint в tbKeyPhrase
    //реализовать набор по кнопке "набрать"

    public partial class MainForm : Form
    {
        public static string Version = "1.5";
        private int currentPasswordLength;
        IniFile INI = new IniFile("config.ini");

        public MainForm()
        {
            InitializeComponent();
            lbAbout.Text = "\nГенератор паролей на основе ключевой фразы\n\n" + 
                                "Версия " + Version + "\n\n" +
                                "Copyright © 2019 andrey.kulbatsky@gmail.com";
            lbHelp.Text =  "1) Выберите длину пароля от 8 до 16 символов.\n" +
                                "2) Введите ключевую фразу длиной больше\n    выбранной длины пароля.\n" +
                                "3) Нажмите кнопку \"Копировать\" для \nкопирования пароля в буфер обмена.";
            notifyIcon.Visible = false;
            Settings_read();
            tbKeyPhrase.TextChanged += new EventHandler(this.TbKeyPhrase_TextChanged);
            cbOnTop.CheckedChanged += new EventHandler(this.CbOnTop_CheckedChanged);
            cbPassLength.SelectedIndexChanged += new EventHandler(this.CbPassLength_SelectedIndexChanged);
            notifyIcon.MouseClick += new MouseEventHandler(NotifyIcon_MouseClick);
            Resize += new EventHandler(MainForm_Resize);
            tbKeyPhrase.Focus();
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
            if ((tbKeyPhrase.Text != "")&(tbKeyPhrase.Text.Length>currentPasswordLength))
            {
                MD5 md5 = MD5.Create();
                SHA256 sha256 = SHA256.Create();
                byte[] md5Hash1 = md5.ComputeHash(Encoding.ASCII.GetBytes(tbKeyPhrase.Text));
                byte[] sha256Hash = sha256.ComputeHash(md5Hash1);
                byte[] md5Hash2 = md5.ComputeHash(sha256Hash);
                tbPass.Text = Convert.ToBase64String(md5Hash2).Substring(0, currentPasswordLength);
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
            Text += Version;
        }

        private void CbOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnTop.Checked)
                TopMost = true;
            else
                TopMost = false;

            INI.Write("Settings", "OnTop", cbOnTop.Checked.ToString());
            tbKeyPhrase.Focus();
        }
    }
}
