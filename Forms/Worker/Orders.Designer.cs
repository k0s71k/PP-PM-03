namespace Practice.Forms.Worker
{
    partial class Orders
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
            OrdersList = new ListBox();
            label1 = new Label();
            OrderInfo = new Label();
            SuspendLayout();
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.ItemHeight = 15;
            OrdersList.Location = new Point(12, 44);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(159, 394);
            OrdersList.TabIndex = 0;
            OrdersList.SelectedIndexChanged += OnChangeItem;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Активные заказы";
            // 
            // OrderInfo
            // 
            OrderInfo.AutoSize = true;
            OrderInfo.Location = new Point(196, 44);
            OrderInfo.Name = "OrderInfo";
            OrderInfo.Size = new Size(0, 15);
            OrderInfo.TabIndex = 2;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(OrderInfo);
            Controls.Add(label1);
            Controls.Add(OrdersList);
            Name = "Orders";
            Text = "Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox OrdersList;
        private Label label1;
        private Label OrderInfo;
    }
}