namespace Practice.Forms
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegisterButton = new Button();
            PasswordEdit = new TextBox();
            LoginEdit = new TextBox();
            NameEdit = new TextBox();
            SurnameEdit = new TextBox();
            EmailEdit = new TextBox();
            LevelsCombo = new ComboBox();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(12, 219);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(189, 23);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Создать";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += OnRegisterClick;
            // 
            // PasswordEdit
            // 
            PasswordEdit.Location = new Point(12, 41);
            PasswordEdit.Name = "PasswordEdit";
            PasswordEdit.PasswordChar = '*';
            PasswordEdit.PlaceholderText = "Пароль";
            PasswordEdit.Size = new Size(189, 23);
            PasswordEdit.TabIndex = 4;
            PasswordEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginEdit
            // 
            LoginEdit.Location = new Point(12, 12);
            LoginEdit.Name = "LoginEdit";
            LoginEdit.PlaceholderText = "Логин";
            LoginEdit.Size = new Size(189, 23);
            LoginEdit.TabIndex = 3;
            LoginEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // NameEdit
            // 
            NameEdit.Location = new Point(12, 70);
            NameEdit.Name = "NameEdit";
            NameEdit.PlaceholderText = "Имя";
            NameEdit.Size = new Size(189, 23);
            NameEdit.TabIndex = 6;
            NameEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // SurnameEdit
            // 
            SurnameEdit.Location = new Point(12, 99);
            SurnameEdit.Name = "SurnameEdit";
            SurnameEdit.PlaceholderText = "Фамилия";
            SurnameEdit.Size = new Size(189, 23);
            SurnameEdit.TabIndex = 7;
            SurnameEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // EmailEdit
            // 
            EmailEdit.Location = new Point(12, 128);
            EmailEdit.Name = "EmailEdit";
            EmailEdit.PlaceholderText = "Эл. Почта";
            EmailEdit.Size = new Size(189, 23);
            EmailEdit.TabIndex = 8;
            EmailEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // LevelsCombo
            // 
            LevelsCombo.FormattingEnabled = true;
            LevelsCombo.Location = new Point(12, 156);
            LevelsCombo.Name = "LevelsCombo";
            LevelsCombo.Size = new Size(189, 23);
            LevelsCombo.TabIndex = 9;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 254);
            Controls.Add(LevelsCombo);
            Controls.Add(EmailEdit);
            Controls.Add(SurnameEdit);
            Controls.Add(NameEdit);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordEdit);
            Controls.Add(LoginEdit);
            Name = "CreateUser";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private TextBox PasswordEdit;
        private TextBox LoginEdit;
        private TextBox NameEdit;
        private TextBox SurnameEdit;
        private TextBox EmailEdit;
        private ComboBox LevelsCombo;
    }
}