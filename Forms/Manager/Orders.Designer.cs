namespace Practice.Forms.Manager
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
            label2 = new Label();
            OrderClient = new TextBox();
            OrderDescription = new TextBox();
            StatusesList = new ComboBox();
            button1 = new Button();
            OrderLabel = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // OrdersList
            // 
            OrdersList.FormattingEnabled = true;
            OrdersList.ItemHeight = 15;
            OrdersList.Location = new Point(12, 42);
            OrdersList.Name = "OrdersList";
            OrdersList.Size = new Size(177, 394);
            OrdersList.TabIndex = 0;
            OrdersList.SelectedIndexChanged += OnChangeItem;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 1;
            label1.Text = "Заказы текущей смены";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 15);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Добавить заказ";
            // 
            // OrderClient
            // 
            OrderClient.Location = new Point(395, 42);
            OrderClient.Name = "OrderClient";
            OrderClient.PlaceholderText = "ID Клиента";
            OrderClient.Size = new Size(157, 23);
            OrderClient.TabIndex = 3;
            OrderClient.TextAlign = HorizontalAlignment.Center;
            // 
            // OrderDescription
            // 
            OrderDescription.Location = new Point(395, 71);
            OrderDescription.Name = "OrderDescription";
            OrderDescription.PlaceholderText = "Описание заказа";
            OrderDescription.Size = new Size(157, 23);
            OrderDescription.TabIndex = 4;
            OrderDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // StatusesList
            // 
            StatusesList.FormattingEnabled = true;
            StatusesList.Location = new Point(195, 42);
            StatusesList.Name = "StatusesList";
            StatusesList.Size = new Size(121, 23);
            StatusesList.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(195, 71);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 7;
            button1.Text = "Изменить статус";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnChangeClick;
            // 
            // OrderLabel
            // 
            OrderLabel.AutoSize = true;
            OrderLabel.Location = new Point(195, 109);
            OrderLabel.Name = "OrderLabel";
            OrderLabel.Size = new Size(0, 15);
            OrderLabel.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(395, 105);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 9;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnCreateClick;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(button2);
            Controls.Add(OrderLabel);
            Controls.Add(button1);
            Controls.Add(StatusesList);
            Controls.Add(OrderDescription);
            Controls.Add(OrderClient);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox OrderClient;
        private TextBox OrderDescription;
        private ComboBox StatusesList;
        private Button button1;
        private Label OrderLabel;
        private Button button2;
    }
}