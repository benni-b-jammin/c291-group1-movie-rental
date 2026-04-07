using System.Drawing;
using System.Windows.Forms;

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

        private TabControl Movie;
        private TabPage CreateMovie;
        private TabPage SearchMovies;

        private Label lblCreateMovieName;
        private Label lblCreateMovieType;
        private Label lblCreateDistFee;
        private Label lblCreateNumCopies;
        private Label lblCreateMovie;
        private Label lblSearchMovieName;
        private Label lblSelectActors;
        private Label lblCreateActorLN;
        private Label lblCreateActorFN;
        private Label lblCreateFeaturedActors;
        private Label lblSearchMovies;
        private ListBox lstCreateActors;

        private TextBox txtCreateDistFee;
        private TextBox txtCreateNumCopies;
        private TextBox txtSearchMovie;
        private TextBox txtCreateActorLN;
        private TextBox txtCreateActorFN;
        private TextBox txtCreateMovieName;

        private DataGridView dgvSearchMovie;
        private DataGridView dgvCreateActors;

        private Button btnMovieDetails;
        private Button btnSearchMovie;
        private Button btnAddActor;
        private Button btnRemoveActor;
        private Button btnCreateMovie;
        private void InitializeComponent()
        {
            Movie = new TabControl();
            CreateMovie = new TabPage();
            btnSearchActor = new Button();
            cbCreateMovieType = new ComboBox();
            lblDollarSgn = new Label();
            btnRemoveActor = new Button();
            btnCreateMovie = new Button();
            btnAddActor = new Button();
            lblCreateFeaturedActors = new Label();
            txtCreateActorLN = new TextBox();
            txtCreateActorFN = new TextBox();
            lstCreateActors = new ListBox();
            lblCreateActorLN = new Label();
            lblCreateActorFN = new Label();
            lblSelectActors = new Label();
            dgvCreateActors = new DataGridView();
            lblCreateMovie = new Label();
            txtCreateNumCopies = new TextBox();
            lblCreateNumCopies = new Label();
            txtCreateDistFee = new TextBox();
            lblCreateDistFee = new Label();
            lblCreateMovieType = new Label();
            lblCreateMovieName = new Label();
            txtCreateMovieName = new TextBox();
            SearchMovies = new TabPage();
            lblSearchMovies = new Label();
            btnMovieDetails = new Button();
            btnSearchMovie = new Button();
            txtSearchMovie = new TextBox();
            lblSearchMovieName = new Label();
            dgvSearchMovie = new DataGridView();
            Movie.SuspendLayout();
            CreateMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreateActors).BeginInit();
            SearchMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchMovie).BeginInit();
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
            CreateMovie.Controls.Add(btnSearchActor);
            CreateMovie.Controls.Add(cbCreateMovieType);
            CreateMovie.Controls.Add(lblDollarSgn);
            CreateMovie.Controls.Add(btnRemoveActor);
            CreateMovie.Controls.Add(btnCreateMovie);
            CreateMovie.Controls.Add(btnAddActor);
            CreateMovie.Controls.Add(lblCreateFeaturedActors);
            CreateMovie.Controls.Add(txtCreateActorLN);
            CreateMovie.Controls.Add(txtCreateActorFN);
            CreateMovie.Controls.Add(lstCreateActors);
            CreateMovie.Controls.Add(lblCreateActorLN);
            CreateMovie.Controls.Add(lblCreateActorFN);
            CreateMovie.Controls.Add(lblSelectActors);
            CreateMovie.Controls.Add(dgvCreateActors);
            CreateMovie.Controls.Add(lblCreateMovie);
            CreateMovie.Controls.Add(txtCreateNumCopies);
            CreateMovie.Controls.Add(lblCreateNumCopies);
            CreateMovie.Controls.Add(txtCreateDistFee);
            CreateMovie.Controls.Add(lblCreateDistFee);
            CreateMovie.Controls.Add(lblCreateMovieType);
            CreateMovie.Controls.Add(lblCreateMovieName);
            CreateMovie.Controls.Add(txtCreateMovieName);
            CreateMovie.Location = new Point(4, 24);
            CreateMovie.Name = "CreateMovie";
            CreateMovie.Padding = new Padding(3);
            CreateMovie.Size = new Size(768, 377);
            CreateMovie.TabIndex = 0;
            CreateMovie.Text = "Create Movie";
            CreateMovie.UseVisualStyleBackColor = true;
            // 
            // btnSearchActor
            // 
            btnSearchActor.Location = new Point(648, 103);
            btnSearchActor.Name = "btnSearchActor";
            btnSearchActor.Size = new Size(96, 23);
            btnSearchActor.TabIndex = 24;
            btnSearchActor.Text = "Search";
            btnSearchActor.UseVisualStyleBackColor = true;
            btnSearchActor.Click += btnSearchActor_Click;
            // 
            // cbCreateMovieType
            // 
            cbCreateMovieType.FormattingEnabled = true;
            cbCreateMovieType.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            cbCreateMovieType.Location = new Point(143, 104);
            cbCreateMovieType.Name = "cbCreateMovieType";
            cbCreateMovieType.Size = new Size(121, 23);
            cbCreateMovieType.TabIndex = 23;
            cbCreateMovieType.Text = "(none selected)";
            // 
            // lblDollarSgn
            // 
            lblDollarSgn.AutoSize = true;
            lblDollarSgn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDollarSgn.Location = new Point(126, 145);
            lblDollarSgn.Name = "lblDollarSgn";
            lblDollarSgn.Size = new Size(14, 14);
            lblDollarSgn.TabIndex = 22;
            lblDollarSgn.Text = "$";
            // 
            // btnRemoveActor
            // 
            btnRemoveActor.Location = new Point(23, 255);
            btnRemoveActor.Name = "btnRemoveActor";
            btnRemoveActor.Size = new Size(96, 23);
            btnRemoveActor.TabIndex = 21;
            btnRemoveActor.Text = "Remove Actor";
            btnRemoveActor.UseVisualStyleBackColor = true;
            btnRemoveActor.Click += btnRemoveActor_Click;
            // 
            // btnCreateMovie
            // 
            btnCreateMovie.Location = new Point(23, 334);
            btnCreateMovie.Name = "btnCreateMovie";
            btnCreateMovie.Size = new Size(96, 23);
            btnCreateMovie.TabIndex = 20;
            btnCreateMovie.Text = "Create Movie";
            btnCreateMovie.UseVisualStyleBackColor = true;
            btnCreateMovie.Click += btnCreateMovie_Click;
            // 
            // btnAddActor
            // 
            btnAddActor.Location = new Point(648, 334);
            btnAddActor.Name = "btnAddActor";
            btnAddActor.Size = new Size(96, 23);
            btnAddActor.TabIndex = 19;
            btnAddActor.Text = "Add Actor";
            btnAddActor.UseVisualStyleBackColor = true;
            btnAddActor.Click += btnAddActor_Click;
            // 
            // lblCreateFeaturedActors
            // 
            lblCreateFeaturedActors.AutoSize = true;
            lblCreateFeaturedActors.Location = new Point(23, 228);
            lblCreateFeaturedActors.Name = "lblCreateFeaturedActors";
            lblCreateFeaturedActors.Size = new Size(98, 15);
            lblCreateFeaturedActors.TabIndex = 18;
            lblCreateFeaturedActors.Text = "Featured Actor(s)";
            // 
            // txtCreateActorLN
            // 
            txtCreateActorLN.Location = new Point(498, 103);
            txtCreateActorLN.Name = "txtCreateActorLN";
            txtCreateActorLN.Size = new Size(128, 23);
            txtCreateActorLN.TabIndex = 17;
            // 
            // txtCreateActorFN
            // 
            txtCreateActorFN.Location = new Point(498, 63);
            txtCreateActorFN.Name = "txtCreateActorFN";
            txtCreateActorFN.Size = new Size(128, 23);
            txtCreateActorFN.TabIndex = 16;
            // 
            // lstCreateActors
            // 
            lstCreateActors.FormattingEnabled = true;
            lstCreateActors.Location = new Point(143, 228);
            lstCreateActors.Name = "lstCreateActors";
            lstCreateActors.Size = new Size(234, 94);
            lstCreateActors.TabIndex = 15;
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
            // lblCreateActorFN
            // 
            lblCreateActorFN.AutoSize = true;
            lblCreateActorFN.Location = new Point(418, 66);
            lblCreateActorFN.Name = "lblCreateActorFN";
            lblCreateActorFN.Size = new Size(64, 15);
            lblCreateActorFN.TabIndex = 13;
            lblCreateActorFN.Text = "First Name";
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
            // 
            // dgvCreateActors
            // 
            dgvCreateActors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreateActors.Location = new Point(418, 146);
            dgvCreateActors.Name = "dgvCreateActors";
            dgvCreateActors.Size = new Size(326, 176);
            dgvCreateActors.TabIndex = 11;
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
            txtCreateNumCopies.Location = new Point(143, 184);
            txtCreateNumCopies.Name = "txtCreateNumCopies";
            txtCreateNumCopies.Size = new Size(75, 23);
            txtCreateNumCopies.TabIndex = 8;
            // 
            // lblCreateNumCopies
            // 
            lblCreateNumCopies.AutoSize = true;
            lblCreateNumCopies.Location = new Point(23, 184);
            lblCreateNumCopies.Name = "lblCreateNumCopies";
            lblCreateNumCopies.Size = new Size(104, 15);
            lblCreateNumCopies.TabIndex = 7;
            lblCreateNumCopies.Text = "Number of Copies";
            // 
            // txtCreateDistFee
            // 
            txtCreateDistFee.Location = new Point(143, 143);
            txtCreateDistFee.Name = "txtCreateDistFee";
            txtCreateDistFee.Size = new Size(75, 23);
            txtCreateDistFee.TabIndex = 6;
            // 
            // lblCreateDistFee
            // 
            lblCreateDistFee.AutoSize = true;
            lblCreateDistFee.Location = new Point(23, 143);
            lblCreateDistFee.Name = "lblCreateDistFee";
            lblCreateDistFee.Size = new Size(90, 15);
            lblCreateDistFee.TabIndex = 5;
            lblCreateDistFee.Text = "Distribution Fee";
            // 
            // lblCreateMovieType
            // 
            lblCreateMovieType.AutoSize = true;
            lblCreateMovieType.ForeColor = SystemColors.ControlText;
            lblCreateMovieType.Location = new Point(23, 104);
            lblCreateMovieType.Name = "lblCreateMovieType";
            lblCreateMovieType.Size = new Size(68, 15);
            lblCreateMovieType.TabIndex = 4;
            lblCreateMovieType.Text = "Movie Type";
            // 
            // lblCreateMovieName
            // 
            lblCreateMovieName.AutoSize = true;
            lblCreateMovieName.Location = new Point(23, 63);
            lblCreateMovieName.Name = "lblCreateMovieName";
            lblCreateMovieName.Size = new Size(75, 15);
            lblCreateMovieName.TabIndex = 2;
            lblCreateMovieName.Text = "Movie Name";
            // 
            // txtCreateMovieName
            // 
            txtCreateMovieName.Location = new Point(143, 63);
            txtCreateMovieName.Name = "txtCreateMovieName";
            txtCreateMovieName.Size = new Size(234, 23);
            txtCreateMovieName.TabIndex = 1;
            // 
            // SearchMovies
            // 
            SearchMovies.Controls.Add(lblSearchMovies);
            SearchMovies.Controls.Add(btnMovieDetails);
            SearchMovies.Controls.Add(btnSearchMovie);
            SearchMovies.Controls.Add(txtSearchMovie);
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
            // btnMovieDetails
            // 
            btnMovieDetails.Location = new Point(589, 60);
            btnMovieDetails.Name = "btnMovieDetails";
            btnMovieDetails.Size = new Size(115, 23);
            btnMovieDetails.TabIndex = 4;
            btnMovieDetails.Text = "Open Details";
            btnMovieDetails.UseVisualStyleBackColor = true;
            btnMovieDetails.Click += btnMovieDetails_Click;
            // 
            // btnSearchMovie
            // 
            btnSearchMovie.Location = new Point(448, 60);
            btnSearchMovie.Name = "btnSearchMovie";
            btnSearchMovie.Size = new Size(105, 23);
            btnSearchMovie.TabIndex = 3;
            btnSearchMovie.Text = "Search";
            btnSearchMovie.UseVisualStyleBackColor = true;
            btnSearchMovie.Click += btnSearchMovie_Click;
            // 
            // txtSearchMovie
            // 
            txtSearchMovie.Location = new Point(114, 59);
            txtSearchMovie.Name = "txtSearchMovie";
            txtSearchMovie.Size = new Size(229, 23);
            txtSearchMovie.TabIndex = 2;
            // 
            // lblSearchMovieName
            // 
            lblSearchMovieName.AutoSize = true;
            lblSearchMovieName.Location = new Point(20, 64);
            lblSearchMovieName.Name = "lblSearchMovieName";
            lblSearchMovieName.Size = new Size(75, 15);
            lblSearchMovieName.TabIndex = 1;
            lblSearchMovieName.Text = "Movie Name";
            // 
            // dgvSearchMovie
            // 
            dgvSearchMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchMovie.Location = new Point(20, 95);
            dgvSearchMovie.Name = "dgvSearchMovie";
            dgvSearchMovie.Size = new Size(733, 263);
            dgvSearchMovie.TabIndex = 0;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Movie);
            Name = "MovieForm";
            Text = "Movie Manager  ";
            Movie.ResumeLayout(false);
            CreateMovie.ResumeLayout(false);
            CreateMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreateActors).EndInit();
            SearchMovies.ResumeLayout(false);
            SearchMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchMovie).EndInit();
            ResumeLayout(false);
        }

        private Label lblDollarSgn;
        private ComboBox cbCreateMovieType;
        private Button btnSearchActor;
    }
}