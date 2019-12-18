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
            this.tbKeyPhrase = new System.Windows.Forms.TextBox();
            this.cbPassLength = new System.Windows.Forms.ComboBox();
            this.lbPassLength = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.btPassWrite = new System.Windows.Forms.Button();
            this.cbOnTop = new System.Windows.Forms.CheckBox();
            this.bpPassCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbKeyPhrase
            // 
            this.tbKeyPhrase.Location = new System.Drawing.Point(18, 12);
            this.tbKeyPhrase.Name = "tbKeyPhrase";
            this.tbKeyPhrase.Size = new System.Drawing.Size(253, 20);
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
            this.cbPassLength.Location = new System.Drawing.Point(208, 46);
            this.cbPassLength.Name = "cbPassLength";
            this.cbPassLength.Size = new System.Drawing.Size(63, 21);
            this.cbPassLength.TabIndex = 1;
            this.cbPassLength.SelectedIndex = 0;
            this.cbPassLength.SelectedIndexChanged += new System.EventHandler(this.cbPassLength_SelectedIndexChanged);
            // 
            // lbPassLength
            // 
            this.lbPassLength.AutoSize = true;
            this.lbPassLength.Location = new System.Drawing.Point(12, 49);
            this.lbPassLength.Name = "lbPassLength";
            this.lbPassLength.Size = new System.Drawing.Size(128, 13);
            this.lbPassLength.TabIndex = 2;
            this.lbPassLength.Text = "Выберите длину пароля";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(66, 80);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(143, 20);
            this.tbPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(15, 83);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(45, 13);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Пароль";
            // 
            // btPassWrite
            // 
            this.btPassWrite.Location = new System.Drawing.Point(19, 109);
            this.btPassWrite.Name = "btPassWrite";
            this.btPassWrite.Size = new System.Drawing.Size(75, 23);
            this.btPassWrite.TabIndex = 5;
            this.btPassWrite.Text = "Набрать";
            this.btPassWrite.UseVisualStyleBackColor = true;
            // 
            // cbOnTop
            // 
            this.cbOnTop.AutoSize = true;
            this.cbOnTop.Location = new System.Drawing.Point(100, 113);
            this.cbOnTop.Name = "cbOnTop";
            this.cbOnTop.Size = new System.Drawing.Size(90, 17);
            this.cbOnTop.TabIndex = 6;
            this.cbOnTop.Text = "Поверх окон";
            this.cbOnTop.UseVisualStyleBackColor = true;
            // 
            // bpPassCopy
            // 
            this.bpPassCopy.Location = new System.Drawing.Point(196, 109);
            this.bpPassCopy.Name = "bpPassCopy";
            this.bpPassCopy.Size = new System.Drawing.Size(75, 23);
            this.bpPassCopy.TabIndex = 7;
            this.bpPassCopy.Text = "Копировать";
            this.bpPassCopy.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 147);
            this.Controls.Add(this.bpPassCopy);
            this.Controls.Add(this.cbOnTop);
            this.Controls.Add(this.btPassWrite);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lbPassLength);
            this.Controls.Add(this.cbPassLength);
            this.Controls.Add(this.tbKeyPhrase);
            this.Name = "MainForm";
            this.Text = "Менеджер паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

