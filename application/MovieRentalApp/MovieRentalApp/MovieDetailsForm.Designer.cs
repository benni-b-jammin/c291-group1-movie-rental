using Microsoft.VisualBasic.Devices;

namespace MovieRentalApp
{
    partial class MovieDetailsForm
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
            lblMovieDetails = new Label();
            lblCreateMovieName = new Label();
            lblCreateDistFee = new Label();
            lblCreateNumCopies = new Label();
            lblCreateMovieType = new Label();
            txtMovieName = new TextBox();
            cbMovieType = new ComboBox();
            txtDistFee = new TextBox();
            txtNumCopies = new TextBox();
            lstActors = new ListBox();
            lblDollarSgn = new Label();
            lblCreateFeaturedActors = new Label();
            btnRemoveActor = new Button();
            btnSaveChanges = new Button();
            lblSelectActors = new Label();
            lblCreateActorFN = new Label();
            lblCreateActorLN = new Label();
            txtActorFN = new TextBox();
            txtActorLN = new TextBox();
            btnSearchActor = new Button();
            dgvCreateActors = new DataGridView();
            btnAddActor = new Button();
            btnDeleteMovie = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCreateActors).BeginInit();
            SuspendLayout();
            // 
            // lblMovieDetails
            // 
            lblMovieDetails.AutoSize = true;
            lblMovieDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDetails.Location = new Point(23, 21);
            lblMovieDetails.Name = "lblMovieDetails";
            lblMovieDetails.Size = new Size(131, 25);
            lblMovieDetails.TabIndex = 10;
            lblMovieDetails.Text = "Movie Details";
            // 
            // lblCreateMovieName
            // 
            lblCreateMovieName.AutoSize = true;
            lblCreateMovieName.Location = new Point(23, 68);
            lblCreateMovieName.Name = "lblCreateMovieName";
            lblCreateMovieName.Size = new Size(75, 15);
            lblCreateMovieName.TabIndex = 2;
            lblCreateMovieName.Text = "Movie Name";
            // 
            // lblCreateDistFee
            // 
            lblCreateDistFee.AutoSize = true;
            lblCreateDistFee.Location = new Point(23, 148);
            lblCreateDistFee.Name = "lblCreateDistFee";
            lblCreateDistFee.Size = new Size(90, 15);
            lblCreateDistFee.TabIndex = 5;
            lblCreateDistFee.Text = "Distribution Fee";
            // 
            // lblCreateNumCopies
            // 
            lblCreateNumCopies.AutoSize = true;
            lblCreateNumCopies.Location = new Point(23, 189);
            lblCreateNumCopies.Name = "lblCreateNumCopies";
            lblCreateNumCopies.Size = new Size(104, 15);
            lblCreateNumCopies.TabIndex = 7;
            lblCreateNumCopies.Text = "Number of Copies";
            // 
            // lblCreateMovieType
            // 
            lblCreateMovieType.AutoSize = true;
            lblCreateMovieType.ForeColor = SystemColors.ControlText;
            lblCreateMovieType.Location = new Point(23, 109);
            lblCreateMovieType.Name = "lblCreateMovieType";
            lblCreateMovieType.Size = new Size(68, 15);
            lblCreateMovieType.TabIndex = 4;
            lblCreateMovieType.Text = "Movie Type";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(143, 63);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(234, 23);
            txtMovieName.TabIndex = 1;
            // 
            // cbMovieType
            // 
            cbMovieType.FormattingEnabled = true;
            cbMovieType.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            cbMovieType.Location = new Point(143, 104);
            cbMovieType.Name = "cbMovieType";
            cbMovieType.Size = new Size(121, 23);
            cbMovieType.TabIndex = 23;
            cbMovieType.Text = "(none selected)";
            // 
            // txtDistFee
            // 
            txtDistFee.Location = new Point(143, 143);
            txtDistFee.Name = "txtDistFee";
            txtDistFee.Size = new Size(75, 23);
            txtDistFee.TabIndex = 6;
            // 
            // txtNumCopies
            // 
            txtNumCopies.Location = new Point(143, 184);
            txtNumCopies.Name = "txtNumCopies";
            txtNumCopies.Size = new Size(75, 23);
            txtNumCopies.TabIndex = 8;
            // 
            // lstActors
            // 
            lstActors.FormattingEnabled = true;
            lstActors.Location = new Point(143, 231);
            lstActors.Name = "lstActors";
            lstActors.Size = new Size(234, 94);
            lstActors.TabIndex = 15;
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
            // lblCreateFeaturedActors
            // 
            lblCreateFeaturedActors.AutoSize = true;
            lblCreateFeaturedActors.Location = new Point(23, 233);
            lblCreateFeaturedActors.Name = "lblCreateFeaturedActors";
            lblCreateFeaturedActors.Size = new Size(98, 15);
            lblCreateFeaturedActors.TabIndex = 18;
            lblCreateFeaturedActors.Text = "Featured Actor(s)";
            // 
            // btnRemoveActor
            // 
            btnRemoveActor.Location = new Point(23, 260);
            btnRemoveActor.Name = "btnRemoveActor";
            btnRemoveActor.Size = new Size(96, 23);
            btnRemoveActor.TabIndex = 21;
            btnRemoveActor.Text = "Remove Actor";
            btnRemoveActor.UseVisualStyleBackColor = true;
            btnRemoveActor.Click += btnRemoveActor_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(23, 393);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(117, 23);
            btnSaveChanges.TabIndex = 20;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
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
            // lblCreateActorFN
            // 
            lblCreateActorFN.AutoSize = true;
            lblCreateActorFN.Location = new Point(418, 66);
            lblCreateActorFN.Name = "lblCreateActorFN";
            lblCreateActorFN.Size = new Size(64, 15);
            lblCreateActorFN.TabIndex = 13;
            lblCreateActorFN.Text = "First Name";
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
            // txtActorFN
            // 
            txtActorFN.Location = new Point(498, 63);
            txtActorFN.Name = "txtActorFN";
            txtActorFN.Size = new Size(128, 23);
            txtActorFN.TabIndex = 16;
            // 
            // txtActorLN
            // 
            txtActorLN.Location = new Point(498, 103);
            txtActorLN.Name = "txtActorLN";
            txtActorLN.Size = new Size(128, 23);
            txtActorLN.TabIndex = 17;
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
            // dgvCreateActors
            // 
            dgvCreateActors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreateActors.Location = new Point(418, 146);
            dgvCreateActors.Name = "dgvCreateActors";
            dgvCreateActors.Size = new Size(326, 179);
            dgvCreateActors.TabIndex = 11;
            // 
            // btnAddActor
            // 
            btnAddActor.Location = new Point(648, 340);
            btnAddActor.Name = "btnAddActor";
            btnAddActor.Size = new Size(96, 23);
            btnAddActor.TabIndex = 19;
            btnAddActor.Text = "Add Actor";
            btnAddActor.UseVisualStyleBackColor = true;
            btnAddActor.Click += btnAddActor_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(159, 393);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(117, 23);
            btnDeleteMovie.TabIndex = 25;
            btnDeleteMovie.Text = "Delete Movie";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnAddActor);
            Controls.Add(dgvCreateActors);
            Controls.Add(btnSearchActor);
            Controls.Add(txtActorLN);
            Controls.Add(txtActorFN);
            Controls.Add(lblCreateActorLN);
            Controls.Add(lblCreateActorFN);
            Controls.Add(lblSelectActors);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnRemoveActor);
            Controls.Add(lblCreateFeaturedActors);
            Controls.Add(lblDollarSgn);
            Controls.Add(lstActors);
            Controls.Add(txtNumCopies);
            Controls.Add(txtDistFee);
            Controls.Add(cbMovieType);
            Controls.Add(txtMovieName);
            Controls.Add(lblCreateMovieType);
            Controls.Add(lblCreateNumCopies);
            Controls.Add(lblCreateDistFee);
            Controls.Add(lblCreateMovieName);
            Controls.Add(lblMovieDetails);
            Name = "MovieDetailsForm";
            Text = "Movie Details";
            ((System.ComponentModel.ISupportInitialize)dgvCreateActors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieDetails;
        private Label lblCreateMovieName;
        private Label lblCreateDistFee;
        private Label lblCreateNumCopies;
        private Label lblCreateMovieType;
        private TextBox txtMovieName;
        private ComboBox cbMovieType;
        private TextBox txtDistFee;
        private TextBox txtNumCopies;
        private ListBox lstActors;
        private Label lblDollarSgn;
        private Label lblCreateFeaturedActors;
        private Button btnRemoveActor;
        private Button btnSaveChanges;
        private Label lblSelectActors;
        private Label lblCreateActorFN;
        private Label lblCreateActorLN;
        private TextBox txtActorFN;
        private TextBox txtActorLN;
        private Button btnSearchActor;
        private DataGridView dgvCreateActors;
        private Button btnAddActor;
        private Button btnDeleteMovie;
    }
}