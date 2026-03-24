using System.Drawing;
using System.Windows.Forms;

namespace MovieRentalApp
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabCustomer;
        private TabPage tabCreateCustomer;
        private TabPage tabSearchCustomer;

        private Label lblCreateTitle;
        private Label lblCreateFirstName;
        private Label lblCreateLastName;
        private Label lblCreateAddress;
        private Label lblCreateCity;
        private Label lblCreateState;
        private Label lblCreateZip;
        private Label lblCreateEmail;
        private Label lblCreateAccountNum;
        private Label lblCreateCardNum;
        private Label lblCreatePhone;

        private TextBox txtCreateFirstName;
        private TextBox txtCreateLastName;
        private TextBox txtCreateAddress;
        private TextBox txtCreateCity;
        private TextBox txtCreateState;
        private TextBox txtCreateZip;
        private TextBox txtCreateEmail;
        private TextBox txtCreateAccountNum;
        private TextBox txtCreateCardNum;
        private TextBox txtCreatePhone;

        private ListBox lstCreatePhones;

        private Button btnAddPhoneCreate;
        private Button btnRemovePhoneCreate;
        private Button btnCreateCustomer;

        private Label lblSearchTitle;
        private Label lblSearchFirstName;
        private Label lblSearchLastName;

        private TextBox txtSearchFirstName;
        private TextBox txtSearchLastName;

        private Button btnSearchCustomer;
        private Button btnOpenDetails;

        private DataGridView dgvSearchResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabCustomer = new TabControl();
            tabCreateCustomer = new TabPage();
            tabSearchCustomer = new TabPage();

            lblCreateTitle = new Label();
            lblCreateFirstName = new Label();
            lblCreateLastName = new Label();
            lblCreateAddress = new Label();
            lblCreateCity = new Label();
            lblCreateState = new Label();
            lblCreateZip = new Label();
            lblCreateEmail = new Label();
            lblCreateAccountNum = new Label();
            lblCreateCardNum = new Label();
            lblCreatePhone = new Label();

            txtCreateFirstName = new TextBox();
            txtCreateLastName = new TextBox();
            txtCreateAddress = new TextBox();
            txtCreateCity = new TextBox();
            txtCreateState = new TextBox();
            txtCreateZip = new TextBox();
            txtCreateEmail = new TextBox();
            txtCreateAccountNum = new TextBox();
            txtCreateCardNum = new TextBox();
            txtCreatePhone = new TextBox();

            lstCreatePhones = new ListBox();

            btnAddPhoneCreate = new Button();
            btnRemovePhoneCreate = new Button();
            btnCreateCustomer = new Button();

            lblSearchTitle = new Label();
            lblSearchFirstName = new Label();
            lblSearchLastName = new Label();

            txtSearchFirstName = new TextBox();
            txtSearchLastName = new TextBox();

            btnSearchCustomer = new Button();
            btnOpenDetails = new Button();

            dgvSearchResults = new DataGridView();

            tabCustomer.SuspendLayout();
            tabCreateCustomer.SuspendLayout();
            tabSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();

            // tabCustomer
            tabCustomer.Controls.Add(tabCreateCustomer);
            tabCustomer.Controls.Add(tabSearchCustomer);
            tabCustomer.Location = new Point(12, 12);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.SelectedIndex = 0;
            tabCustomer.Size = new Size(960, 626);
            tabCustomer.TabIndex = 0;

            // tabCreateCustomer
            tabCreateCustomer.Controls.Add(lblCreateTitle);
            tabCreateCustomer.Controls.Add(lblCreateFirstName);
            tabCreateCustomer.Controls.Add(lblCreateLastName);
            tabCreateCustomer.Controls.Add(lblCreateAddress);
            tabCreateCustomer.Controls.Add(lblCreateCity);
            tabCreateCustomer.Controls.Add(lblCreateState);
            tabCreateCustomer.Controls.Add(lblCreateZip);
            tabCreateCustomer.Controls.Add(lblCreateEmail);
            tabCreateCustomer.Controls.Add(lblCreateAccountNum);
            tabCreateCustomer.Controls.Add(lblCreateCardNum);
            tabCreateCustomer.Controls.Add(lblCreatePhone);

            tabCreateCustomer.Controls.Add(txtCreateFirstName);
            tabCreateCustomer.Controls.Add(txtCreateLastName);
            tabCreateCustomer.Controls.Add(txtCreateAddress);
            tabCreateCustomer.Controls.Add(txtCreateCity);
            tabCreateCustomer.Controls.Add(txtCreateState);
            tabCreateCustomer.Controls.Add(txtCreateZip);
            tabCreateCustomer.Controls.Add(txtCreateEmail);
            tabCreateCustomer.Controls.Add(txtCreateAccountNum);
            tabCreateCustomer.Controls.Add(txtCreateCardNum);
            tabCreateCustomer.Controls.Add(txtCreatePhone);

            tabCreateCustomer.Controls.Add(lstCreatePhones);

            tabCreateCustomer.Controls.Add(btnAddPhoneCreate);
            tabCreateCustomer.Controls.Add(btnRemovePhoneCreate);
            tabCreateCustomer.Controls.Add(btnCreateCustomer);

            tabCreateCustomer.Location = new Point(4, 29);
            tabCreateCustomer.Name = "tabCreateCustomer";
            tabCreateCustomer.Padding = new Padding(3);
            tabCreateCustomer.Size = new Size(952, 593);
            tabCreateCustomer.TabIndex = 0;
            tabCreateCustomer.Text = "Create Customer";
            tabCreateCustomer.UseVisualStyleBackColor = true;

            // lblCreateTitle
            lblCreateTitle.AutoSize = true;
            lblCreateTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCreateTitle.Location = new Point(28, 20);
            lblCreateTitle.Name = "lblCreateTitle";
            lblCreateTitle.Size = new Size(187, 32);
            lblCreateTitle.Text = "Create Customer";

            // Labels left column
            lblCreateFirstName.AutoSize = true;
            lblCreateFirstName.Location = new Point(30, 80);
            lblCreateFirstName.Text = "First Name";

            lblCreateLastName.AutoSize = true;
            lblCreateLastName.Location = new Point(30, 125);
            lblCreateLastName.Text = "Last Name";

            lblCreateAddress.AutoSize = true;
            lblCreateAddress.Location = new Point(30, 170);
            lblCreateAddress.Text = "Address";

            lblCreateCity.AutoSize = true;
            lblCreateCity.Location = new Point(30, 215);
            lblCreateCity.Text = "City";

            lblCreateState.AutoSize = true;
            lblCreateState.Location = new Point(30, 260);
            lblCreateState.Text = "State";

            lblCreateZip.AutoSize = true;
            lblCreateZip.Location = new Point(30, 305);
            lblCreateZip.Text = "Zip Code";

            lblCreateEmail.AutoSize = true;
            lblCreateEmail.Location = new Point(30, 350);
            lblCreateEmail.Text = "Email";

            lblCreateAccountNum.AutoSize = true;
            lblCreateAccountNum.Location = new Point(30, 395);
            lblCreateAccountNum.Text = "Account Num";

            lblCreateCardNum.AutoSize = true;
            lblCreateCardNum.Location = new Point(30, 440);
            lblCreateCardNum.Text = "Card Num";

            lblCreatePhone.AutoSize = true;
            lblCreatePhone.Location = new Point(520, 80);
            lblCreatePhone.Text = "Phone Number";

            // Textboxes left column
            txtCreateFirstName.Location = new Point(160, 77);
            txtCreateFirstName.Name = "txtCreateFirstName";
            txtCreateFirstName.Size = new Size(250, 27);

            txtCreateLastName.Location = new Point(160, 122);
            txtCreateLastName.Name = "txtCreateLastName";
            txtCreateLastName.Size = new Size(250, 27);

            txtCreateAddress.Location = new Point(160, 167);
            txtCreateAddress.Name = "txtCreateAddress";
            txtCreateAddress.Size = new Size(250, 27);

            txtCreateCity.Location = new Point(160, 212);
            txtCreateCity.Name = "txtCreateCity";
            txtCreateCity.Size = new Size(250, 27);

            txtCreateState.Location = new Point(160, 257);
            txtCreateState.Name = "txtCreateState";
            txtCreateState.Size = new Size(80, 27);

            txtCreateZip.Location = new Point(160, 302);
            txtCreateZip.Name = "txtCreateZip";
            txtCreateZip.Size = new Size(120, 27);

            txtCreateEmail.Location = new Point(160, 347);
            txtCreateEmail.Name = "txtCreateEmail";
            txtCreateEmail.Size = new Size(250, 27);

            txtCreateAccountNum.Location = new Point(160, 392);
            txtCreateAccountNum.Name = "txtCreateAccountNum";
            txtCreateAccountNum.Size = new Size(120, 27);

            txtCreateCardNum.Location = new Point(160, 437);
            txtCreateCardNum.Name = "txtCreateCardNum";
            txtCreateCardNum.Size = new Size(250, 27);

            // Phone controls
            txtCreatePhone.Location = new Point(640, 77);
            txtCreatePhone.Name = "txtCreatePhone";
            txtCreatePhone.Size = new Size(180, 27);

            btnAddPhoneCreate.Location = new Point(830, 76);
            btnAddPhoneCreate.Name = "btnAddPhoneCreate";
            btnAddPhoneCreate.Size = new Size(90, 29);
            btnAddPhoneCreate.Text = "Add";
            btnAddPhoneCreate.UseVisualStyleBackColor = true;
            btnAddPhoneCreate.Click += btnAddPhoneCreate_Click;

            lstCreatePhones.FormattingEnabled = true;
            lstCreatePhones.ItemHeight = 20;
            lstCreatePhones.Location = new Point(520, 125);
            lstCreatePhones.Name = "lstCreatePhones";
            lstCreatePhones.Size = new Size(300, 204);

            btnRemovePhoneCreate.Location = new Point(830, 125);
            btnRemovePhoneCreate.Name = "btnRemovePhoneCreate";
            btnRemovePhoneCreate.Size = new Size(90, 29);
            btnRemovePhoneCreate.Text = "Remove";
            btnRemovePhoneCreate.UseVisualStyleBackColor = true;
            btnRemovePhoneCreate.Click += btnRemovePhoneCreate_Click;

            btnCreateCustomer.Location = new Point(30, 500);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(180, 40);
            btnCreateCustomer.Text = "Create Customer";
            btnCreateCustomer.UseVisualStyleBackColor = true;
            btnCreateCustomer.Click += btnCreateCustomer_Click;

            // tabSearchCustomer
            tabSearchCustomer.Controls.Add(lblSearchTitle);
            tabSearchCustomer.Controls.Add(lblSearchFirstName);
            tabSearchCustomer.Controls.Add(lblSearchLastName);
            tabSearchCustomer.Controls.Add(txtSearchFirstName);
            tabSearchCustomer.Controls.Add(txtSearchLastName);
            tabSearchCustomer.Controls.Add(btnSearchCustomer);
            tabSearchCustomer.Controls.Add(btnOpenDetails);
            tabSearchCustomer.Controls.Add(dgvSearchResults);
            tabSearchCustomer.Location = new Point(4, 29);
            tabSearchCustomer.Name = "tabSearchCustomer";
            tabSearchCustomer.Padding = new Padding(3);
            tabSearchCustomer.Size = new Size(952, 593);
            tabSearchCustomer.TabIndex = 1;
            tabSearchCustomer.Text = "Search Customers";
            tabSearchCustomer.UseVisualStyleBackColor = true;

            // Search labels
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSearchTitle.Location = new Point(28, 20);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(205, 32);
            lblSearchTitle.Text = "Search Customers";

            lblSearchFirstName.AutoSize = true;
            lblSearchFirstName.Location = new Point(30, 80);
            lblSearchFirstName.Text = "First Name";

            lblSearchLastName.AutoSize = true;
            lblSearchLastName.Location = new Point(300, 80);
            lblSearchLastName.Text = "Last Name";

            txtSearchFirstName.Location = new Point(110, 77);
            txtSearchFirstName.Name = "txtSearchFirstName";
            txtSearchFirstName.Size = new Size(150, 27);

            txtSearchLastName.Location = new Point(380, 77);
            txtSearchLastName.Name = "txtSearchLastName";
            txtSearchLastName.Size = new Size(150, 27);

            btnSearchCustomer.Location = new Point(560, 75);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(100, 30);
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;

            btnOpenDetails.Location = new Point(680, 75);
            btnOpenDetails.Name = "btnOpenDetails";
            btnOpenDetails.Size = new Size(140, 30);
            btnOpenDetails.Text = "Open Details";
            btnOpenDetails.UseVisualStyleBackColor = true;
            btnOpenDetails.Click += btnOpenDetails_Click;

            dgvSearchResults.AllowUserToAddRows = false;
            dgvSearchResults.AllowUserToDeleteRows = false;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(30, 130);
            dgvSearchResults.MultiSelect = false;
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.ReadOnly = true;
            dgvSearchResults.RowHeadersWidth = 51;
            dgvSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchResults.Size = new Size(890, 420);

            // CustomerForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 650);
            Controls.Add(tabCustomer);
            Name = "CustomerForm";
            Text = "Customer Management";

            tabCustomer.ResumeLayout(false);
            tabCreateCustomer.ResumeLayout(false);
            tabCreateCustomer.PerformLayout();
            tabSearchCustomer.ResumeLayout(false);
            tabSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
        }
    }
}