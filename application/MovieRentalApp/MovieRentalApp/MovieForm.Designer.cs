namespace MovieRentalApp
{
    partial class MovieForm
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
            Movie = new TabControl();
            CreateMovie = new TabPage();
            EditMovie = new TabPage();
            label1 = new Label();
            txtCreateMovieName = new TextBox();
            lblCreateMovieName = new Label();
            lstCreateMovieType = new ListBox();
            lblCreateMovieType = new Label();
            lblCreateDistFee = new Label();
            txtCreateDistFee = new TextBox();
            lblCreateNumCopies = new Label();
            txtCreateNumCopies = new TextBox();
            panel1 = new Panel();
            Movie.SuspendLayout();
            CreateMovie.SuspendLayout();
            SuspendLayout();
            // 
            // Movie
            // 
            Movie.AccessibleName = "";
            Movie.Controls.Add(CreateMovie);
            Movie.Controls.Add(EditMovie);
            Movie.Location = new Point(12, 12);
            Movie.Name = "Movie";
            Movie.SelectedIndex = 0;
            Movie.Size = new Size(776, 405);
            Movie.TabIndex = 0;
            // 
            // CreateMovie
            // 
            CreateMovie.Controls.Add(panel1);
            CreateMovie.Controls.Add(txtCreateNumCopies);
            CreateMovie.Controls.Add(lblCreateNumCopies);
            CreateMovie.Controls.Add(txtCreateDistFee);
            CreateMovie.Controls.Add(lblCreateDistFee);
            CreateMovie.Controls.Add(lblCreateMovieType);
            CreateMovie.Controls.Add(lstCreateMovieType);
            CreateMovie.Controls.Add(lblCreateMovieName);
            CreateMovie.Controls.Add(txtCreateMovieName);
            CreateMovie.Controls.Add(label1);
            CreateMovie.Location = new Point(4, 24);
            CreateMovie.Name = "CreateMovie";
            CreateMovie.Padding = new Padding(3);
            CreateMovie.Size = new Size(768, 377);
            CreateMovie.TabIndex = 0;
            CreateMovie.Text = "Create Movie";
            CreateMovie.UseVisualStyleBackColor = true;
            CreateMovie.Click += this.CreateMovie_Click;
            // 
            // EditMovie
            // 
            EditMovie.Location = new Point(4, 24);
            EditMovie.Name = "EditMovie";
            EditMovie.Padding = new Padding(3);
            EditMovie.Size = new Size(768, 377);
            EditMovie.TabIndex = 1;
            EditMovie.Text = "Edit Movie";
            EditMovie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Create Movie";
            label1.Click += this.label1_Click;
            // 
            // txtCreateMovieName
            // 
            txtCreateMovieName.Location = new Point(143, 63);
            txtCreateMovieName.Name = "txtCreateMovieName";
            txtCreateMovieName.Size = new Size(213, 23);
            txtCreateMovieName.TabIndex = 1;
            // 
            // lblCreateMovieName
            // 
            lblCreateMovieName.AutoSize = true;
            lblCreateMovieName.Location = new Point(23, 66);
            lblCreateMovieName.Name = "lblCreateMovieName";
            lblCreateMovieName.Size = new Size(75, 15);
            lblCreateMovieName.TabIndex = 2;
            lblCreateMovieName.Text = "Movie Name";
            lblCreateMovieName.Click += this.label2_Click;
            // 
            // lstCreateMovieType
            // 
            lstCreateMovieType.FormattingEnabled = true;
            lstCreateMovieType.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            lstCreateMovieType.Location = new Point(143, 100);
            lstCreateMovieType.Name = "lstCreateMovieType";
            lstCreateMovieType.Size = new Size(120, 64);
            lstCreateMovieType.TabIndex = 3;
            lstCreateMovieType.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
            // 
            // lblCreateMovieType
            // 
            lblCreateMovieType.AutoSize = true;
            lblCreateMovieType.ForeColor = SystemColors.ControlText;
            lblCreateMovieType.Location = new Point(23, 103);
            lblCreateMovieType.Name = "lblCreateMovieType";
            lblCreateMovieType.Size = new Size(68, 15);
            lblCreateMovieType.TabIndex = 4;
            lblCreateMovieType.Text = "Movie Type";
            lblCreateMovieType.Click += this.label2_Click_1;
            // 
            // lblCreateDistFee
            // 
            lblCreateDistFee.AutoSize = true;
            lblCreateDistFee.Location = new Point(23, 185);
            lblCreateDistFee.Name = "lblCreateDistFee";
            lblCreateDistFee.Size = new Size(90, 15);
            lblCreateDistFee.TabIndex = 5;
            lblCreateDistFee.Text = "Distribution Fee";
            // 
            // txtCreateDistFee
            // 
            txtCreateDistFee.Location = new Point(143, 182);
            txtCreateDistFee.Name = "txtCreateDistFee";
            txtCreateDistFee.Size = new Size(75, 23);
            txtCreateDistFee.TabIndex = 6;
            // 
            // lblCreateNumCopies
            // 
            lblCreateNumCopies.AutoSize = true;
            lblCreateNumCopies.Location = new Point(23, 222);
            lblCreateNumCopies.Name = "lblCreateNumCopies";
            lblCreateNumCopies.Size = new Size(104, 15);
            lblCreateNumCopies.TabIndex = 7;
            lblCreateNumCopies.Text = "Number of Copies";
            lblCreateNumCopies.Click += this.label2_Click_2;
            // 
            // txtCreateNumCopies
            // 
            txtCreateNumCopies.Location = new Point(143, 219);
            txtCreateNumCopies.Name = "txtCreateNumCopies";
            txtCreateNumCopies.Size = new Size(75, 23);
            txtCreateNumCopies.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(391, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 239);
            panel1.TabIndex = 9;
            panel1.Paint += this.panel1_Paint;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Movie);
            Name = "MovieForm";
            Text = "Movie Manager  ";
            Load += this.MovieForm_Load;
            Movie.ResumeLayout(false);
            CreateMovie.ResumeLayout(false);
            CreateMovie.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Movie;
        private TabPage CreateMovie;
        private TabPage EditMovie;
        private Label label1;
        private TextBox txtCreateMovieName;
        private Label lblCreateMovieName;
        private ListBox lstCreateMovieType;
        private Label lblCreateMovieType;
        private TextBox txtCreateDistFee;
        private Label lblCreateDistFee;
        private TextBox txtCreateNumCopies;
        private Label lblCreateNumCopies;
        private Panel panel1;
    }
}