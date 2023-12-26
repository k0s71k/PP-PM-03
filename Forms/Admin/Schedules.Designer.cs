namespace Practice.Forms
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
            ManagerIdEdit = new Label();
            DatePicker = new DateTimePicker();
            StartTimePicker = new DateTimePicker();
            EndTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ManagerCombo = new ComboBox();
            CreateSchedule = new Button();
            SuspendLayout();
            // 
            // SchedulesList
            // 
            SchedulesList.FormattingEnabled = true;
            SchedulesList.ItemHeight = 15;
            SchedulesList.Location = new Point(12, 12);
            SchedulesList.Name = "SchedulesList";
            SchedulesList.Size = new Size(184, 424);
            SchedulesList.TabIndex = 0;
            SchedulesList.SelectedIndexChanged += OnSchedulesChange;
            // 
            // WorkersList
            // 
            WorkersList.FormattingEnabled = true;
            WorkersList.ItemHeight = 15;
            WorkersList.Location = new Point(202, 267);
            WorkersList.Name = "WorkersList";
            WorkersList.Size = new Size(183, 169);
            WorkersList.TabIndex = 1;
            WorkersList.Visible = false;
            // 
            // ManagerIdEdit
            // 
            ManagerIdEdit.AutoSize = true;
            ManagerIdEdit.Location = new Point(202, 240);
            ManagerIdEdit.Name = "ManagerIdEdit";
            ManagerIdEdit.Size = new Size(38, 15);
            ManagerIdEdit.TabIndex = 2;
            ManagerIdEdit.Text = "label1";
            ManagerIdEdit.Visible = false;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(588, 12);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 3;
            // 
            // StartTimePicker
            // 
            StartTimePicker.Format = DateTimePickerFormat.Time;
            StartTimePicker.Location = new Point(588, 41);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(200, 23);
            StartTimePicker.TabIndex = 4;
            StartTimePicker.Value = new DateTime(2023, 12, 24, 0, 0, 0, 0);
            // 
            // EndTimePicker
            // 
            EndTimePicker.Format = DateTimePickerFormat.Time;
            EndTimePicker.Location = new Point(588, 70);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(200, 23);
            EndTimePicker.TabIndex = 5;
            EndTimePicker.Value = new DateTime(2023, 12, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 18);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 47);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Начало";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 76);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Окончание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 106);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "Менеджер";
            // 
            // ManagerCombo
            // 
            ManagerCombo.FormattingEnabled = true;
            ManagerCombo.Location = new Point(588, 103);
            ManagerCombo.Name = "ManagerCombo";
            ManagerCombo.Size = new Size(200, 23);
            ManagerCombo.TabIndex = 10;
            // 
            // CreateSchedule
            // 
            CreateSchedule.Location = new Point(629, 141);
            CreateSchedule.Name = "CreateSchedule";
            CreateSchedule.Size = new Size(159, 23);
            CreateSchedule.TabIndex = 11;
            CreateSchedule.Text = "Создать смену";
            CreateSchedule.UseVisualStyleBackColor = true;
            CreateSchedule.Click += OnCreateClick;
            // 
            // Schedules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateSchedule);
            Controls.Add(ManagerCombo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(DatePicker);
            Controls.Add(ManagerIdEdit);
            Controls.Add(WorkersList);
            Controls.Add(SchedulesList);
            Name = "Schedules";
            Text = "AdminSchedules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SchedulesList;
        private ListBox WorkersList;
        private Label ManagerIdEdit;
        private DateTimePicker DatePicker;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox ManagerCombo;
        private Button CreateSchedule;
    }
}