namespace MovieRentalApp
{
    partial class RentalForm
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
            listCust = new ListBox();
            listQueue = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listCust
            // 
            listCust.Font = new Font("Segoe UI", 12F);
            listCust.FormattingEnabled = true;
            listCust.Location = new Point(12, 50);
            listCust.Name = "listCust";
            listCust.Size = new Size(361, 340);
            listCust.TabIndex = 0;
            listCust.SelectedIndexChanged += listCust_SelectedIndexChanged;
            // 
            // listQueue
            // 
            listQueue.Font = new Font("Segoe UI", 12F);
            listQueue.FormattingEnabled = true;
            listQueue.Location = new Point(427, 50);
            listQueue.Name = "listQueue";
            listQueue.Size = new Size(361, 298);
            listQueue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(129, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 2;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(559, 19);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 3;
            label2.Text = "Queue";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(559, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Dispense";
            button1.UseVisualStyleBackColor = true;
            // 
            // RentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listQueue);
            Controls.Add(listCust);
            Name = "RentalForm";
            Text = "Rentals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCust;
        private ListBox listQueue;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}