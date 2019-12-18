using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerPC
{
    public partial class MainForm : Form
    {
        private string hint = "Введите ключевую фразу";
        private bool showHint = true;
        private string keyPhrase = "";

        public MainForm()
        {
            InitializeComponent();
            this.tbKeyPhrase.Text = hint;
            this.tbKeyPhrase.ForeColor = Color.Gray;
            this.tbKeyPhrase.SelectionStart = 0;
            this.tbKeyPhrase.TextChanged += new System.EventHandler(this.tbKeyPhrase_TextChanged);
        }

        private void tbKeyPhrase_TextChanged(object sender, EventArgs e)
        {
            if (showHint == true)
            {
                this.tbKeyPhrase.Text = hint;
                this.tbKeyPhrase.ForeColor = Color.Gray;
            }
            else
            {
                this.tbKeyPhrase.Text = null;
                this.tbKeyPhrase.ForeColor = Color.Black;
            }
        }

        private void cbPassLength_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
