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
            btnCustomerScreen = new Button();
            btnMovieScreen = new Button();
            btnRentalScreen = new Button();
            btnReportScreen = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblPlaceholder
            // 
            lblPlaceholder.AutoSize = true;
            lblPlaceholder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPlaceholder.Location = new Point(249, 56);
            lblPlaceholder.Name = "lblPlaceholder";
            lblPlaceholder.Size = new Size(162, 30);
            lblPlaceholder.TabIndex = 0;
            lblPlaceholder.Text = "Login Success!";
            lblPlaceholder.Click += lblPlaceholder_Click;
            // 
            // btnCustomerScreen
            // 
            btnCustomerScreen.Font = new Font("Segoe UI", 12F);
            btnCustomerScreen.Location = new Point(118, 133);
            btnCustomerScreen.Name = "btnCustomerScreen";
            btnCustomerScreen.Size = new Size(193, 51);
            btnCustomerScreen.TabIndex = 1;
            btnCustomerScreen.Text = "Customer Manager";
            btnCustomerScreen.UseVisualStyleBackColor = true;
            // 
            // btnMovieScreen
            // 
            btnMovieScreen.Font = new Font("Segoe UI", 12F);
            btnMovieScreen.Location = new Point(358, 133);
            btnMovieScreen.Name = "btnMovieScreen";
            btnMovieScreen.Size = new Size(193, 51);
            btnMovieScreen.TabIndex = 2;
            btnMovieScreen.Text = "Movie Manager";
            btnMovieScreen.UseVisualStyleBackColor = true;
            // 
            // btnRentalScreen
            // 
            btnRentalScreen.Font = new Font("Segoe UI", 12F);
            btnRentalScreen.Location = new Point(118, 223);
            btnRentalScreen.Name = "btnRentalScreen";
            btnRentalScreen.Size = new Size(193, 51);
            btnRentalScreen.TabIndex = 3;
            btnRentalScreen.Text = "Rentals";
            btnRentalScreen.UseVisualStyleBackColor = true;
            // 
            // btnReportScreen
            // 
            btnReportScreen.Font = new Font("Segoe UI", 12F);
            btnReportScreen.Location = new Point(358, 223);
            btnReportScreen.Name = "btnReportScreen";
            btnReportScreen.Size = new Size(193, 51);
            btnReportScreen.TabIndex = 4;
            btnReportScreen.Text = "Reports";
            btnReportScreen.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(569, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(105, 26);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnLogout);
            Controls.Add(btnReportScreen);
            Controls.Add(btnRentalScreen);
            Controls.Add(btnMovieScreen);
            Controls.Add(btnCustomerScreen);
            Controls.Add(lblPlaceholder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomerScreen;
        private Button btnMovieScreen;
        private Button btnRentalScreen;
        private Button btnReportScreen;
        private Button btnLogout;
    }
}