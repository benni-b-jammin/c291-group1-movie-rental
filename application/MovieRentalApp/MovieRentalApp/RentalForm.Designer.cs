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
            DispenseButton = new Button();
            FirstNameText = new TextBox();
            LastNameText = new TextBox();
            buttonFilter = new Button();
            FirstLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listCust
            // 
            listCust.Font = new Font("Segoe UI", 12F);
            listCust.FormattingEnabled = true;
            listCust.Location = new Point(12, 113);
            listCust.Name = "listCust";
            listCust.Size = new Size(361, 277);
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
            label1.Location = new Point(138, 19);
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
            // DispenseButton
            // 
            DispenseButton.ForeColor = SystemColors.ActiveCaptionText;
            DispenseButton.Location = new Point(559, 360);
            DispenseButton.Name = "DispenseButton";
            DispenseButton.Size = new Size(75, 23);
            DispenseButton.TabIndex = 4;
            DispenseButton.Text = "Dispense";
            DispenseButton.UseVisualStyleBackColor = true;
            DispenseButton.Click += DispenseButton_Click;
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(47, 50);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(130, 23);
            FirstNameText.TabIndex = 5;
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(243, 50);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(130, 23);
            LastNameText.TabIndex = 6;
            // 
            // buttonFilter
            // 
            buttonFilter.ForeColor = SystemColors.ActiveCaptionText;
            buttonFilter.Location = new Point(149, 84);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(75, 23);
            buttonFilter.TabIndex = 7;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // FirstLabel
            // 
            FirstLabel.AutoSize = true;
            FirstLabel.Location = new Point(12, 53);
            FirstLabel.Name = "FirstLabel";
            FirstLabel.Size = new Size(32, 15);
            FirstLabel.TabIndex = 8;
            FirstLabel.Text = "First:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 53);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Last:";
            // 
            // RentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(FirstLabel);
            Controls.Add(buttonFilter);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameText);
            Controls.Add(DispenseButton);
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
        private Button DispenseButton;
        private TextBox FirstNameText;
        private TextBox LastNameText;
        private Button buttonFilter;
        private Label FirstLabel;
        private Label label3;
    }
}