namespace Practice.Forms.Manager
{
    partial class Schedules
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
            SchedulesList = new ListBox();
            WorkersList = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            UsersList = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // SchedulesList
            // 
            SchedulesList.FormattingEnabled = true;
            SchedulesList.ItemHeight = 15;
            SchedulesList.Location = new Point(12, 42);
            SchedulesList.Name = "SchedulesList";
            SchedulesList.Size = new Size(192, 394);
            SchedulesList.TabIndex = 0;
            SchedulesList.SelectedIndexChanged += OnScheduleChange;
            // 
            // WorkersList
            // 
            WorkersList.FormattingEnabled = true;
            WorkersList.ItemHeight = 15;
            WorkersList.Location = new Point(210, 76);
            WorkersList.Name = "WorkersList";
            WorkersList.Size = new Size(179, 139);
            WorkersList.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(210, 413);
            button1.Name = "button1";
            button1.Size = new Size(179, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnAddWorkerClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(192, 15);
            label1.TabIndex = 3;
            label1.Text = "Смены под вашим руководством";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 357);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 4;
            label2.Text = "Добавить сотрудника";
            // 
            // UsersList
            // 
            UsersList.FormattingEnabled = true;
            UsersList.Location = new Point(210, 384);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(181, 23);
            UsersList.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 52);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 6;
            label3.Text = "Сотрудники смены";
            // 
            // Schedules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 450);
            Controls.Add(label3);
            Controls.Add(UsersList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(WorkersList);
            Controls.Add(SchedulesList);
            Name = "Schedules";
            Text = "Schedules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SchedulesList;
        private ListBox WorkersList;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox UsersList;
        private Label label3;
    }
}