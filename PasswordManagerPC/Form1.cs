using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerPC
{
    public partial class MainForm : Form
    {
        public static string Version = "1.0";
        private const string hint = "Введите ключевую фразу";
        private bool showHint = true;
        private int currentPasswordLength;

        public MainForm()
        {
            InitializeComponent();
            tbKeyPhrase.Text = hint;
            tbKeyPhrase.ForeColor = Color.Gray;
            tbKeyPhrase.SelectionStart = 0;
            tbKeyPhrase.TextChanged += new EventHandler(this.tbKeyPhrase_TextChanged);
            cbPassLength.SelectedIndex = 0;
            currentPasswordLength = cbPassLength.SelectedIndex+8;
            cbPassLength.SelectedIndexChanged += new EventHandler(this.cbPassLength_SelectedIndexChanged);
            notifyIcon.Visible = false;
            notifyIcon.MouseClick += new MouseEventHandler(notifyIcon_MouseClick);
            this.Resize += new EventHandler(MainForm_Resize);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
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

        private void tbKeyPhrase_TextChanged(object sender, EventArgs e)
        {
            if (showHint == true)
            {
                showHint = false;
                int indexOfHint = tbKeyPhrase.Text.IndexOf(hint);
                tbKeyPhrase.Text = tbKeyPhrase.Text.Remove(indexOfHint);
                tbKeyPhrase.ForeColor = Color.Black;
                tbKeyPhrase.SelectionStart = tbKeyPhrase.Text.Length;
                showPassword();
            }
            else {
                if (tbKeyPhrase.Text == "") {
                    tbKeyPhrase.Text = hint;
                    tbKeyPhrase.ForeColor = Color.Gray;
                    tbKeyPhrase.SelectionStart = 0;
                    showHint = true;
                }
                else
                    showPassword();
            }
        }

        private void cbPassLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPasswordLength = cbPassLength.SelectedIndex + 8;
            showPassword();
        }

        private void showPassword() {
            if (tbKeyPhrase.Text != "")
            {
                MD5 md5 = MD5.Create();
                tbPass.Text = Convert.ToBase64String(md5.ComputeHash(Encoding.ASCII.GetBytes(tbKeyPhrase.Text))).Substring(0, currentPasswordLength);
            }
            else
                tbPass.Text = "";
        }

        private void bpPassCopy_Click(object sender, EventArgs e)
        {
            if (tbKeyPhrase.Text != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(tbPass.Text);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += Version;
        }
    }
}
