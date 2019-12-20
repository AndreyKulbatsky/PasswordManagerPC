namespace PasswordManagerPC
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbKeyPhrase = new System.Windows.Forms.TextBox();
            this.cbPassLength = new System.Windows.Forms.ComboBox();
            this.lbPassLength = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.btPassWrite = new System.Windows.Forms.Button();
            this.cbOnTop = new System.Windows.Forms.CheckBox();
            this.bpPassCopy = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lbAbout = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKeyPhrase
            // 
            this.tbKeyPhrase.Location = new System.Drawing.Point(6, 6);
            this.tbKeyPhrase.Name = "tbKeyPhrase";
            this.tbKeyPhrase.Size = new System.Drawing.Size(249, 20);
            this.tbKeyPhrase.TabIndex = 0;
            // 
            // cbPassLength
            // 
            this.cbPassLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPassLength.FormattingEnabled = true;
            this.cbPassLength.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cbPassLength.Location = new System.Drawing.Point(192, 35);
            this.cbPassLength.Name = "cbPassLength";
            this.cbPassLength.Size = new System.Drawing.Size(63, 21);
            this.cbPassLength.TabIndex = 1;
            // 
            // lbPassLength
            // 
            this.lbPassLength.AutoSize = true;
            this.lbPassLength.Location = new System.Drawing.Point(8, 35);
            this.lbPassLength.Name = "lbPassLength";
            this.lbPassLength.Size = new System.Drawing.Size(128, 13);
            this.lbPassLength.TabIndex = 2;
            this.lbPassLength.Text = "Выберите длину пароля";
            // 
            // tbPass
            // 
            this.tbPass.Enabled = false;
            this.tbPass.Location = new System.Drawing.Point(62, 58);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(112, 20);
            this.tbPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(6, 61);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(45, 13);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Пароль";
            // 
            // btPassWrite
            // 
            this.btPassWrite.Enabled = false;
            this.btPassWrite.Location = new System.Drawing.Point(3, 90);
            this.btPassWrite.Name = "btPassWrite";
            this.btPassWrite.Size = new System.Drawing.Size(75, 23);
            this.btPassWrite.TabIndex = 5;
            this.btPassWrite.Text = "Набрать";
            this.btPassWrite.UseVisualStyleBackColor = true;
            // 
            // cbOnTop
            // 
            this.cbOnTop.AutoSize = true;
            this.cbOnTop.Location = new System.Drawing.Point(84, 94);
            this.cbOnTop.Name = "cbOnTop";
            this.cbOnTop.Size = new System.Drawing.Size(90, 17);
            this.cbOnTop.TabIndex = 6;
            this.cbOnTop.Text = "Поверх окон";
            this.cbOnTop.UseVisualStyleBackColor = true;
            // 
            // bpPassCopy
            // 
            this.bpPassCopy.Enabled = false;
            this.bpPassCopy.Location = new System.Drawing.Point(180, 90);
            this.bpPassCopy.Name = "bpPassCopy";
            this.bpPassCopy.Size = new System.Drawing.Size(75, 23);
            this.bpPassCopy.TabIndex = 7;
            this.bpPassCopy.Text = "Копировать";
            this.bpPassCopy.UseVisualStyleBackColor = true;
            this.bpPassCopy.Click += new System.EventHandler(this.BpPassCopy_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Менеджер паролей";
            this.notifyIcon.Visible = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(267, 147);
            this.tabControl.TabIndex = 8;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cbPassLength);
            this.tabMain.Controls.Add(this.lbPassLength);
            this.tabMain.Controls.Add(this.tbPass);
            this.tabMain.Controls.Add(this.lbPass);
            this.tabMain.Controls.Add(this.btPassWrite);
            this.tabMain.Controls.Add(this.cbOnTop);
            this.tabMain.Controls.Add(this.bpPassCopy);
            this.tabMain.Controls.Add(this.tbKeyPhrase);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(259, 121);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Генератор пароля";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lbAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(259, 121);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "о программе";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(3, 3);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(248, 52);
            this.lbAbout.TabIndex = 0;
            this.lbAbout.Text = "Генератор паролей на основе ключевой фразы\n\n\n Copyright © andrey.kulbatsky@gmail." +
    "com 2019 ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 150);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Менеджер паролей ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeyPhrase;
        private System.Windows.Forms.ComboBox cbPassLength;
        private System.Windows.Forms.Label lbPassLength;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btPassWrite;
        private System.Windows.Forms.CheckBox cbOnTop;
        private System.Windows.Forms.Button bpPassCopy;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lbAbout;
    }
}

