namespace Practice.Forms.Admin
{
    partial class Main
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
            label1 = new Label();
            UsersMenuButton = new Button();
            ScheduleMenuButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 37);
            label1.Name = "label1";
            label1.Size = new Size(250, 15);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать в меню администратора";
            // 
            // UsersMenuButton
            // 
            UsersMenuButton.Location = new Point(160, 68);
            UsersMenuButton.Name = "UsersMenuButton";
            UsersMenuButton.Size = new Size(136, 23);
            UsersMenuButton.TabIndex = 1;
            UsersMenuButton.Text = "Пользователи";
            UsersMenuButton.UseVisualStyleBackColor = true;
            UsersMenuButton.Click += OnUsersClick;
            // 
            // ScheduleMenuButton
            // 
            ScheduleMenuButton.Location = new Point(160, 97);
            ScheduleMenuButton.Name = "ScheduleMenuButton";
            ScheduleMenuButton.Size = new Size(136, 23);
            ScheduleMenuButton.TabIndex = 2;
            ScheduleMenuButton.Text = "Смены";
            ScheduleMenuButton.UseVisualStyleBackColor = true;
            ScheduleMenuButton.Click += OnScheduleClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 155);
            Controls.Add(ScheduleMenuButton);
            Controls.Add(UsersMenuButton);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button UsersMenuButton;
        private Button ScheduleMenuButton;
    }
}