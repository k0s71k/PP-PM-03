namespace Practice
{
    partial class Login
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
            LoginEdit = new TextBox();
            PasswordEdit = new TextBox();
            AuthorizeButton = new Button();
            SuspendLayout();
            // 
            // LoginEdit
            // 
            LoginEdit.Location = new Point(12, 12);
            LoginEdit.Name = "LoginEdit";
            LoginEdit.PlaceholderText = "Логин";
            LoginEdit.Size = new Size(189, 23);
            LoginEdit.TabIndex = 0;
            LoginEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordEdit
            // 
            PasswordEdit.Location = new Point(12, 41);
            PasswordEdit.Name = "PasswordEdit";
            PasswordEdit.PasswordChar = '*';
            PasswordEdit.PlaceholderText = "Пароль";
            PasswordEdit.Size = new Size(189, 23);
            PasswordEdit.TabIndex = 1;
            PasswordEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // AuthorizeButton
            // 
            AuthorizeButton.Location = new Point(12, 81);
            AuthorizeButton.Name = "AuthorizeButton";
            AuthorizeButton.Size = new Size(189, 23);
            AuthorizeButton.TabIndex = 2;
            AuthorizeButton.Text = "Авторизоваться";
            AuthorizeButton.UseVisualStyleBackColor = true;
            AuthorizeButton.Click += OnAuthorizeClick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 116);
            Controls.Add(AuthorizeButton);
            Controls.Add(PasswordEdit);
            Controls.Add(LoginEdit);
            Name = "Login";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginEdit;
        private TextBox PasswordEdit;
        private Button AuthorizeButton;
    }
}