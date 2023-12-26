namespace Practice.Forms.Manager
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Меню менеджера";
            // 
            // button1
            // 
            button1.Location = new Point(116, 41);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 1;
            button1.Text = "Смены";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnSchedulesClick;
            // 
            // button2
            // 
            button2.Location = new Point(116, 70);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 2;
            button2.Text = "Заказы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnOrdersClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 117);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}