namespace MovieRentalApp
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            ReportTabs = new TabControl();
            TopActors = new TabPage();
            textBox1 = new TextBox();
            RunReport = new Button();
            ActressActor = new RadioButton();
            Actors = new RadioButton();
            Actress = new RadioButton();
            SalesReport = new TabPage();
            textBox2 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            DropMonth = new ComboBox();
            TopEmployees = new TabPage();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            textBox3 = new TextBox();
            TopMovies = new TabPage();
            button3 = new Button();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox4 = new TextBox();
            MovieSuggest = new TabPage();
            button4 = new Button();
            comboBox6 = new ComboBox();
            textBox5 = new TextBox();
            ReportTabs.SuspendLayout();
            TopActors.SuspendLayout();
            SalesReport.SuspendLayout();
            TopEmployees.SuspendLayout();
            TopMovies.SuspendLayout();
            MovieSuggest.SuspendLayout();
            SuspendLayout();
            // 
            // ReportTabs
            // 
            ReportTabs.Controls.Add(TopActors);
            ReportTabs.Controls.Add(SalesReport);
            ReportTabs.Controls.Add(TopEmployees);
            ReportTabs.Controls.Add(TopMovies);
            ReportTabs.Controls.Add(MovieSuggest);
            ReportTabs.Location = new Point(11, 12);
            ReportTabs.Name = "ReportTabs";
            ReportTabs.SelectedIndex = 0;
            ReportTabs.Size = new Size(776, 426);
            ReportTabs.TabIndex = 0;
            // 
            // TopActors
            // 
            TopActors.Controls.Add(textBox1);
            TopActors.Controls.Add(RunReport);
            TopActors.Controls.Add(ActressActor);
            TopActors.Controls.Add(Actors);
            TopActors.Controls.Add(Actress);
            TopActors.Location = new Point(4, 24);
            TopActors.Name = "TopActors";
            TopActors.Padding = new Padding(3);
            TopActors.Size = new Size(768, 398);
            TopActors.TabIndex = 0;
            TopActors.Text = "Top Actors";
            TopActors.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(63, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(561, 121);
            textBox1.TabIndex = 6;
            textBox1.Text = "This report is for finding the top 5 rated actor or actress or both\r\nSelect your options then press RUN REPORT\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RunReport
            // 
            RunReport.BackColor = Color.Navy;
            RunReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RunReport.ForeColor = SystemColors.ControlLight;
            RunReport.Location = new Point(617, 332);
            RunReport.Name = "RunReport";
            RunReport.Size = new Size(145, 60);
            RunReport.TabIndex = 4;
            RunReport.Text = "RUN REPORT";
            RunReport.UseVisualStyleBackColor = false;
            RunReport.Click += RunReport_Click;
            // 
            // ActressActor
            // 
            ActressActor.AutoSize = true;
            ActressActor.Checked = true;
            ActressActor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActressActor.Location = new Point(447, 332);
            ActressActor.Name = "ActressActor";
            ActressActor.Size = new Size(60, 25);
            ActressActor.TabIndex = 3;
            ActressActor.TabStop = true;
            ActressActor.Text = "Both";
            ActressActor.UseVisualStyleBackColor = true;
            ActressActor.CheckedChanged += ActressActor_CheckedChanged;
            // 
            // Actors
            // 
            Actors.AutoSize = true;
            Actors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Actors.Location = new Point(284, 332);
            Actors.Name = "Actors";
            Actors.Size = new Size(72, 25);
            Actors.TabIndex = 2;
            Actors.Text = "Actors";
            Actors.UseVisualStyleBackColor = true;
            Actors.CheckedChanged += Actors_CheckedChanged;
            // 
            // Actress
            // 
            Actress.AutoSize = true;
            Actress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Actress.Location = new Point(130, 332);
            Actress.Name = "Actress";
            Actress.Size = new Size(93, 25);
            Actress.TabIndex = 1;
            Actress.Text = "Actresses";
            Actress.UseVisualStyleBackColor = true;
            Actress.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // SalesReport
            // 
            SalesReport.Controls.Add(textBox2);
            SalesReport.Controls.Add(button1);
            SalesReport.Controls.Add(comboBox1);
            SalesReport.Controls.Add(DropMonth);
            SalesReport.Location = new Point(4, 24);
            SalesReport.Name = "SalesReport";
            SalesReport.Padding = new Padding(3);
            SalesReport.Size = new Size(768, 398);
            SalesReport.TabIndex = 1;
            SalesReport.Text = "Sales Report";
            SalesReport.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(122, 93);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(494, 116);
            textBox2.TabIndex = 6;
            textBox2.Text = "This report is for generating a sales report for a given\r\nmonth and year.\r\nSelect your options then press RUN REPORT";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(617, 332);
            button1.Name = "button1";
            button1.Size = new Size(145, 60);
            button1.TabIndex = 5;
            button1.Text = "RUN REPORT";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2025", "2026" });
            comboBox1.Location = new Point(352, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Year";
            // 
            // DropMonth
            // 
            DropMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DropMonth.FormattingEnabled = true;
            DropMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            DropMonth.Location = new Point(122, 332);
            DropMonth.Name = "DropMonth";
            DropMonth.Size = new Size(121, 29);
            DropMonth.TabIndex = 0;
            DropMonth.Text = "Month";
            // 
            // TopEmployees
            // 
            TopEmployees.Controls.Add(comboBox3);
            TopEmployees.Controls.Add(comboBox2);
            TopEmployees.Controls.Add(button2);
            TopEmployees.Controls.Add(textBox3);
            TopEmployees.Location = new Point(4, 24);
            TopEmployees.Name = "TopEmployees";
            TopEmployees.Padding = new Padding(3);
            TopEmployees.Size = new Size(768, 398);
            TopEmployees.TabIndex = 2;
            TopEmployees.Text = "Top Employees";
            TopEmployees.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "2025", "2026" });
            comboBox3.Location = new Point(331, 332);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 29);
            comboBox3.TabIndex = 8;
            comboBox3.Text = "Year";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox2.Location = new Point(140, 332);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "Month";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(617, 332);
            button2.Name = "button2";
            button2.Size = new Size(145, 60);
            button2.TabIndex = 6;
            button2.Text = "RUN REPORT";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(140, 81);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(412, 129);
            textBox3.TabIndex = 0;
            textBox3.Text = "This report is to find the top 5 employees in a given time period\r\n(employee who oversaw the most orders).\r\nSelect your options then press RUN REPORT\r\n";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // TopMovies
            // 
            TopMovies.Controls.Add(button3);
            TopMovies.Controls.Add(comboBox5);
            TopMovies.Controls.Add(comboBox4);
            TopMovies.Controls.Add(textBox4);
            TopMovies.Location = new Point(4, 24);
            TopMovies.Name = "TopMovies";
            TopMovies.Padding = new Padding(3);
            TopMovies.Size = new Size(768, 398);
            TopMovies.TabIndex = 3;
            TopMovies.Text = "Top Movies";
            TopMovies.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(617, 332);
            button3.Name = "button3";
            button3.Size = new Size(145, 60);
            button3.TabIndex = 10;
            button3.Text = "RUN REPORT";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "2025", "2026" });
            comboBox5.Location = new Point(380, 319);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 29);
            comboBox5.TabIndex = 9;
            comboBox5.Text = "Year";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox4.Location = new Point(175, 319);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 29);
            comboBox4.TabIndex = 8;
            comboBox4.Text = "Month";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(164, 96);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(391, 104);
            textBox4.TabIndex = 0;
            textBox4.Text = "This report is to find the most actively rented movies in a given time period\r\nSelect your options then press RUN REPORT";
            // 
            // MovieSuggest
            // 
            MovieSuggest.Controls.Add(button4);
            MovieSuggest.Controls.Add(comboBox6);
            MovieSuggest.Controls.Add(textBox5);
            MovieSuggest.Location = new Point(4, 24);
            MovieSuggest.Name = "MovieSuggest";
            MovieSuggest.Padding = new Padding(3);
            MovieSuggest.Size = new Size(768, 398);
            MovieSuggest.TabIndex = 4;
            MovieSuggest.Text = "Movie Suggestions";
            MovieSuggest.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(617, 332);
            button4.Name = "button4";
            button4.Size = new Size(145, 60);
            button4.TabIndex = 11;
            button4.Text = "RUN REPORT";
            button4.UseVisualStyleBackColor = false;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(72, 332);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 29);
            comboBox6.TabIndex = 1;
            comboBox6.Text = "Customer";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(72, 89);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(604, 117);
            textBox5.TabIndex = 0;
            textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportTabs);
            Name = "ReportForm";
            Text = "ReportForm";
            ReportTabs.ResumeLayout(false);
            TopActors.ResumeLayout(false);
            TopActors.PerformLayout();
            SalesReport.ResumeLayout(false);
            SalesReport.PerformLayout();
            TopEmployees.ResumeLayout(false);
            TopEmployees.PerformLayout();
            TopMovies.ResumeLayout(false);
            TopMovies.PerformLayout();
            MovieSuggest.ResumeLayout(false);
            MovieSuggest.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ReportTabs;
        private TabPage TopActors;
        private TabPage SalesReport;
        private TabPage TopEmployees;
        private TabPage TopMovies;
        private TabPage MovieSuggest;
        private RadioButton ActressActor;
        private RadioButton Actors;
        private RadioButton Actress;
        private Button RunReport;
        private ComboBox DropMonth;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Button button3;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private Button button4;
        private ComboBox comboBox6;
        private TextBox textBox5;
    }
}