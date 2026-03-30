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
            lblCreateMovie = new Label();
            txtCreateNumCopies = new TextBox();
            lblCreateNumCopies = new Label();
            txtCreateDistFee = new TextBox();
            lblCreateDistFee = new Label();
            lblCreateMovieType = new Label();
            lstCreateMovieType = new ListBox();
            lblCreateMovieName = new Label();
            txtCreateMovieName = new TextBox();
            SearchMovies = new TabPage();
            dgvSearchMovie = new DataGridView();
            lblSearchMovieName = new Label();
            textBox1 = new TextBox();
            btnSearchMovie = new Button();
            btnOpenMovieDetails = new Button();
            dataGridView1 = new DataGridView();
            lblSelectActors = new Label();
            lblSearchMovies = new Label();
            lblCreateActorFN = new Label();
            lblCreateActorLN = new Label();
            lstCreateActors = new ListBox();
            txtCreateActorFN = new TextBox();
            txtCreateActorLN = new TextBox();
            lblCreateFeaturedActors = new Label();
            btnCreateAddActor = new Button();
            Movie.SuspendLayout();
            CreateMovie.SuspendLayout();
            SearchMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Movie
            // 
            Movie.AccessibleName = "";
            Movie.Controls.Add(CreateMovie);
            Movie.Controls.Add(SearchMovies);
            Movie.Location = new Point(12, 12);
            Movie.Name = "Movie";
            Movie.SelectedIndex = 0;
            Movie.Size = new Size(776, 405);
            Movie.TabIndex = 0;
            // 
            // CreateMovie
            // 
            CreateMovie.Controls.Add(btnCreateAddActor);
            CreateMovie.Controls.Add(lblCreateFeaturedActors);
            CreateMovie.Controls.Add(txtCreateActorLN);
            CreateMovie.Controls.Add(txtCreateActorFN);
            CreateMovie.Controls.Add(lstCreateActors);
            CreateMovie.Controls.Add(lblCreateActorLN);
            CreateMovie.Controls.Add(lblCreateActorFN);
            CreateMovie.Controls.Add(lblSelectActors);
            CreateMovie.Controls.Add(dataGridView1);
            CreateMovie.Controls.Add(lblCreateMovie);
            CreateMovie.Controls.Add(txtCreateNumCopies);
            CreateMovie.Controls.Add(lblCreateNumCopies);
            CreateMovie.Controls.Add(txtCreateDistFee);
            CreateMovie.Controls.Add(lblCreateDistFee);
            CreateMovie.Controls.Add(lblCreateMovieType);
            CreateMovie.Controls.Add(lstCreateMovieType);
            CreateMovie.Controls.Add(lblCreateMovieName);
            CreateMovie.Controls.Add(txtCreateMovieName);
            CreateMovie.Location = new Point(4, 24);
            CreateMovie.Name = "CreateMovie";
            CreateMovie.Padding = new Padding(3);
            CreateMovie.Size = new Size(768, 377);
            CreateMovie.TabIndex = 0;
            CreateMovie.Text = "Create Movie";
            CreateMovie.UseVisualStyleBackColor = true;
            CreateMovie.Click += CreateMovie_Click;
            // 
            // lblCreateMovie
            // 
            lblCreateMovie.AutoSize = true;
            lblCreateMovie.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateMovie.Location = new Point(23, 21);
            lblCreateMovie.Name = "lblCreateMovie";
            lblCreateMovie.Size = new Size(129, 25);
            lblCreateMovie.TabIndex = 10;
            lblCreateMovie.Text = "Create Movie";
            // 
            // txtCreateNumCopies
            // 
            txtCreateNumCopies.Location = new Point(143, 219);
            txtCreateNumCopies.Name = "txtCreateNumCopies";
            txtCreateNumCopies.Size = new Size(75, 23);
            txtCreateNumCopies.TabIndex = 8;
            // 
            // lblCreateNumCopies
            // 
            lblCreateNumCopies.AutoSize = true;
            lblCreateNumCopies.Location = new Point(23, 222);
            lblCreateNumCopies.Name = "lblCreateNumCopies";
            lblCreateNumCopies.Size = new Size(104, 15);
            lblCreateNumCopies.TabIndex = 7;
            lblCreateNumCopies.Text = "Number of Copies";
            // 
            // txtCreateDistFee
            // 
            txtCreateDistFee.Location = new Point(143, 182);
            txtCreateDistFee.Name = "txtCreateDistFee";
            txtCreateDistFee.Size = new Size(75, 23);
            txtCreateDistFee.TabIndex = 6;
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
            // lblCreateMovieType
            // 
            lblCreateMovieType.AutoSize = true;
            lblCreateMovieType.ForeColor = SystemColors.ControlText;
            lblCreateMovieType.Location = new Point(23, 103);
            lblCreateMovieType.Name = "lblCreateMovieType";
            lblCreateMovieType.Size = new Size(68, 15);
            lblCreateMovieType.TabIndex = 4;
            lblCreateMovieType.Text = "Movie Type";
            // 
            // lstCreateMovieType
            // 
            lstCreateMovieType.FormattingEnabled = true;
            lstCreateMovieType.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            lstCreateMovieType.Location = new Point(143, 100);
            lstCreateMovieType.Name = "lstCreateMovieType";
            lstCreateMovieType.Size = new Size(120, 64);
            lstCreateMovieType.TabIndex = 3;
            lstCreateMovieType.SelectedIndexChanged += lstCreateMovieType_SelectedIndexChanged;
            // 
            // lblCreateMovieName
            // 
            lblCreateMovieName.AutoSize = true;
            lblCreateMovieName.Location = new Point(23, 66);
            lblCreateMovieName.Name = "lblCreateMovieName";
            lblCreateMovieName.Size = new Size(75, 15);
            lblCreateMovieName.TabIndex = 2;
            lblCreateMovieName.Text = "Movie Name";
            // 
            // txtCreateMovieName
            // 
            txtCreateMovieName.Location = new Point(143, 63);
            txtCreateMovieName.Name = "txtCreateMovieName";
            txtCreateMovieName.Size = new Size(213, 23);
            txtCreateMovieName.TabIndex = 1;
            // 
            // SearchMovies
            // 
            SearchMovies.Controls.Add(lblSearchMovies);
            SearchMovies.Controls.Add(btnOpenMovieDetails);
            SearchMovies.Controls.Add(btnSearchMovie);
            SearchMovies.Controls.Add(textBox1);
            SearchMovies.Controls.Add(lblSearchMovieName);
            SearchMovies.Controls.Add(dgvSearchMovie);
            SearchMovies.Location = new Point(4, 24);
            SearchMovies.Name = "SearchMovies";
            SearchMovies.Padding = new Padding(3);
            SearchMovies.Size = new Size(768, 377);
            SearchMovies.TabIndex = 1;
            SearchMovies.Text = "Search Movies";
            SearchMovies.UseVisualStyleBackColor = true;
            // 
            // dgvSearchMovie
            // 
            dgvSearchMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchMovie.Location = new Point(20, 95);
            dgvSearchMovie.Name = "dgvSearchMovie";
            dgvSearchMovie.Size = new Size(733, 263);
            dgvSearchMovie.TabIndex = 0;
            dgvSearchMovie.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSearchMovieName
            // 
            lblSearchMovieName.AutoSize = true;
            lblSearchMovieName.Location = new Point(20, 64);
            lblSearchMovieName.Name = "lblSearchMovieName";
            lblSearchMovieName.Size = new Size(75, 15);
            lblSearchMovieName.TabIndex = 1;
            lblSearchMovieName.Text = "Movie Name";
            lblSearchMovieName.Click += lblSearchMovieName_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSearchMovie
            // 
            btnSearchMovie.Location = new Point(448, 60);
            btnSearchMovie.Name = "btnSearchMovie";
            btnSearchMovie.Size = new Size(105, 23);
            btnSearchMovie.TabIndex = 3;
            btnSearchMovie.Text = "Search";
            btnSearchMovie.UseVisualStyleBackColor = true;
            // 
            // btnOpenMovieDetails
            // 
            btnOpenMovieDetails.Location = new Point(589, 60);
            btnOpenMovieDetails.Name = "btnOpenMovieDetails";
            btnOpenMovieDetails.Size = new Size(115, 23);
            btnOpenMovieDetails.TabIndex = 4;
            btnOpenMovieDetails.Text = "Open Details";
            btnOpenMovieDetails.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(418, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(326, 167);
            dataGridView1.TabIndex = 11;
            // 
            // lblSelectActors
            // 
            lblSelectActors.AutoSize = true;
            lblSelectActors.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectActors.Location = new Point(418, 21);
            lblSelectActors.Name = "lblSelectActors";
            lblSelectActors.Size = new Size(224, 25);
            lblSelectActors.TabIndex = 12;
            lblSelectActors.Text = "Select Featured Actor(s)";
            lblSelectActors.Click += lblCreateSFeaturedActors_Click;
            // 
            // lblSearchMovies
            // 
            lblSearchMovies.AutoSize = true;
            lblSearchMovies.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchMovies.Location = new Point(20, 23);
            lblSearchMovies.Name = "lblSearchMovies";
            lblSearchMovies.RightToLeft = RightToLeft.No;
            lblSearchMovies.Size = new Size(139, 25);
            lblSearchMovies.TabIndex = 5;
            lblSearchMovies.Text = "Search Movies";
            // 
            // lblCreateActorFN
            // 
            lblCreateActorFN.AutoSize = true;
            lblCreateActorFN.Location = new Point(418, 66);
            lblCreateActorFN.Name = "lblCreateActorFN";
            lblCreateActorFN.Size = new Size(64, 15);
            lblCreateActorFN.TabIndex = 13;
            lblCreateActorFN.Text = "First Name";
            lblCreateActorFN.Click += label1_Click_1;
            // 
            // lblCreateActorLN
            // 
            lblCreateActorLN.AutoSize = true;
            lblCreateActorLN.Location = new Point(418, 103);
            lblCreateActorLN.Name = "lblCreateActorLN";
            lblCreateActorLN.Size = new Size(63, 15);
            lblCreateActorLN.TabIndex = 14;
            lblCreateActorLN.Text = "Last Name";
            // 
            // lstCreateActors
            // 
            lstCreateActors.FormattingEnabled = true;
            lstCreateActors.Location = new Point(143, 263);
            lstCreateActors.Name = "lstCreateActors";
            lstCreateActors.Size = new Size(120, 94);
            lstCreateActors.TabIndex = 15;
            lstCreateActors.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtCreateActorFN
            // 
            txtCreateActorFN.Location = new Point(498, 63);
            txtCreateActorFN.Name = "txtCreateActorFN";
            txtCreateActorFN.Size = new Size(167, 23);
            txtCreateActorFN.TabIndex = 16;
            // 
            // txtCreateActorLN
            // 
            txtCreateActorLN.Location = new Point(498, 103);
            txtCreateActorLN.Name = "txtCreateActorLN";
            txtCreateActorLN.Size = new Size(167, 23);
            txtCreateActorLN.TabIndex = 17;
            // 
            // lblCreateFeaturedActors
            // 
            lblCreateFeaturedActors.AutoSize = true;
            lblCreateFeaturedActors.Location = new Point(23, 268);
            lblCreateFeaturedActors.Name = "lblCreateFeaturedActors";
            lblCreateFeaturedActors.Size = new Size(98, 15);
            lblCreateFeaturedActors.TabIndex = 18;
            lblCreateFeaturedActors.Text = "Featured Actor(s)";
            // 
            // btnCreateAddActor
            // 
            btnCreateAddActor.Location = new Point(648, 334);
            btnCreateAddActor.Name = "btnCreateAddActor";
            btnCreateAddActor.Size = new Size(96, 23);
            btnCreateAddActor.TabIndex = 19;
            btnCreateAddActor.Text = "Add Actor";
            btnCreateAddActor.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Movie);
            Name = "MovieForm";
            Text = "Movie Manager  ";
            Load += MovieForm_Load;
            Movie.ResumeLayout(false);
            CreateMovie.ResumeLayout(false);
            CreateMovie.PerformLayout();
            SearchMovies.ResumeLayout(false);
            SearchMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Movie;
        private TabPage CreateMovie;
        private TabPage SearchMovies;
        private TextBox txtCreateMovieName;
        private Label lblCreateMovieName;
        private ListBox lstCreateMovieType;
        private Label lblCreateMovieType;
        private TextBox txtCreateDistFee;
        private Label lblCreateDistFee;
        private TextBox txtCreateNumCopies;
        private Label lblCreateNumCopies;
        private Label lblCreateMovie;
        private DataGridView dgvSearchMovie;
        private TextBox textBox1;
        private Label lblSearchMovieName;
        private Button btnOpenMovieDetails;
        private Button btnSearchMovie;
        private Label lblSelectActors;
        private DataGridView dataGridView1;
        private Label lblSearchMovies;
        private ListBox lstCreateActors;
        private Label lblCreateActorLN;
        private Label lblCreateActorFN;
        private TextBox txtCreateActorLN;
        private TextBox txtCreateActorFN;
        private Label lblCreateFeaturedActors;
        private Button btnCreateAddActor;
    }
}