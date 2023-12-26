namespace Practice.Forms
{
    partial class Users
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
            UsersList = new ListBox();
            label1 = new Label();
            LevelsCombo = new ComboBox();
            ChangeLevel = new Button();
            CreateUser = new Button();
            SuspendLayout();
            // 
            // UsersList
            // 
            UsersList.FormattingEnabled = true;
            UsersList.ItemHeight = 15;
            UsersList.Location = new Point(12, 42);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(173, 394);
            UsersList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 2;
            label1.Text = "Список пользователей";
            // 
            // LevelsCombo
            // 
            LevelsCombo.FormattingEnabled = true;
            LevelsCombo.Location = new Point(191, 42);
            LevelsCombo.Name = "LevelsCombo";
            LevelsCombo.Size = new Size(151, 23);
            LevelsCombo.TabIndex = 3;
            // 
            // ChangeLevel
            // 
            ChangeLevel.Location = new Point(191, 71);
            ChangeLevel.Name = "ChangeLevel";
            ChangeLevel.Size = new Size(151, 23);
            ChangeLevel.TabIndex = 4;
            ChangeLevel.Text = "Изменить доступ";
            ChangeLevel.UseVisualStyleBackColor = true;
            ChangeLevel.Click += OnChangeClick;
            // 
            // CreateUser
            // 
            CreateUser.Location = new Point(191, 413);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(151, 23);
            CreateUser.TabIndex = 5;
            CreateUser.Text = "Создать пользователя";
            CreateUser.UseVisualStyleBackColor = true;
            CreateUser.Click += OnCreateClick;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 450);
            Controls.Add(CreateUser);
            Controls.Add(ChangeLevel);
            Controls.Add(LevelsCombo);
            Controls.Add(label1);
            Controls.Add(UsersList);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersList;
        private Label label1;
        private ComboBox LevelsCombo;
        private Button ChangeLevel;
        private Button CreateUser;
    }
}