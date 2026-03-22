namespace MovieRentalApp
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblPlaceholder;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPlaceholder = new Label();
            SuspendLayout();
            // 
            // lblPlaceholder
            // 
            lblPlaceholder.AutoSize = true;
            lblPlaceholder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPlaceholder.Location = new Point(192, 112);
            lblPlaceholder.Name = "lblPlaceholder";
            lblPlaceholder.Size = new Size(115, 30);
            lblPlaceholder.TabIndex = 0;
            lblPlaceholder.Text = "Login Success!";
            lblPlaceholder.Click += lblPlaceholder_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblPlaceholder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}