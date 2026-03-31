using System.Drawing;
using System.Windows.Forms;

namespace MovieRentalApp
{
    partial class CustomerDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblCustomerID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress;
        private Label lblCity;
        private Label lblState;
        private Label lblZip;
        private Label lblEmail;
        private Label lblAccountNum;
        private Label lblCardNum;
        private Label lblPhone;

        private TextBox txtCustomerID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZip;
        private TextBox txtEmail;
        private TextBox txtAccountNum;
        private TextBox txtCardNum;
        private TextBox txtPhone;

        private ListBox lstPhones;

        private Button btnAddPhone;
        private Button btnRemovePhone;
        private Button btnUpdate;
        private Button btnDelete;

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
            lblTitle = new Label();
            lblCustomerID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZip = new Label();
            lblEmail = new Label();
            lblAccountNum = new Label();
            lblCardNum = new Label();
            lblPhone = new Label();

            txtCustomerID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            txtEmail = new TextBox();
            txtAccountNum = new TextBox();
            txtCardNum = new TextBox();
            txtPhone = new TextBox();

            lstPhones = new ListBox();

            btnAddPhone = new Button();
            btnRemovePhone = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(28, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 32);
            lblTitle.Text = "Customer Details";

            // Labels
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(30, 80);
            lblCustomerID.Text = "Customer ID";

            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 125);
            lblFirstName.Text = "First Name";

            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 170);
            lblLastName.Text = "Last Name";

            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(30, 215);
            lblAddress.Text = "Address";

            lblCity.AutoSize = true;
            lblCity.Location = new Point(30, 260);
            lblCity.Text = "City";

            lblState.AutoSize = true;
            lblState.Location = new Point(30, 305);
            lblState.Text = "State";

            lblZip.AutoSize = true;
            lblZip.Location = new Point(30, 350);
            lblZip.Text = "Zip Code";

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 395);
            lblEmail.Text = "Email";

            lblAccountNum.AutoSize = true;
            lblAccountNum.Location = new Point(30, 440);
            lblAccountNum.Text = "Account Num";

            lblCardNum.AutoSize = true;
            lblCardNum.Location = new Point(30, 485);
            lblCardNum.Text = "Card Num";

            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(560, 80);
            lblPhone.Text = "Phone Number";

            // Textboxes
            txtCustomerID.Location = new Point(150, 77);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(150, 27);

            txtFirstName.Location = new Point(150, 122);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);

            txtLastName.Location = new Point(150, 167);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);

            txtAddress.Location = new Point(150, 212);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);

            txtCity.Location = new Point(150, 257);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 27);

            txtState.Location = new Point(150, 302);
            txtState.Name = "txtState";
            txtState.Size = new Size(80, 27);

            txtZip.Location = new Point(150, 347);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(120, 27);

            txtEmail.Location = new Point(150, 392);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);

            txtAccountNum.Location = new Point(150, 437);
            txtAccountNum.Name = "txtAccountNum";
            txtAccountNum.Size = new Size(120, 27);

            txtCardNum.Location = new Point(150, 482);
            txtCardNum.Name = "txtCardNum";
            txtCardNum.Size = new Size(250, 27);

            txtPhone.Location = new Point(680, 77);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 27);

            // Phone controls
            btnAddPhone.Location = new Point(870, 76);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(80, 29);
            btnAddPhone.Text = "Add";
            btnAddPhone.UseVisualStyleBackColor = true;
            btnAddPhone.Click += btnAddPhone_Click;

            lstPhones.FormattingEnabled = true;
            lstPhones.ItemHeight = 20;
            lstPhones.Location = new Point(560, 125);
            lstPhones.Name = "lstPhones";
            lstPhones.Size = new Size(300, 224);

            btnRemovePhone.Location = new Point(870, 125);
            btnRemovePhone.Name = "btnRemovePhone";
            btnRemovePhone.Size = new Size(80, 29);
            btnRemovePhone.Text = "Remove";
            btnRemovePhone.UseVisualStyleBackColor = true;
            btnRemovePhone.Click += btnRemovePhone_Click;

            // Action buttons
            btnUpdate.Location = new Point(560, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Location = new Point(720, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            // CustomerDetailsForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(lblTitle);
            Controls.Add(lblCustomerID);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblAddress);
            Controls.Add(lblCity);
            Controls.Add(lblState);
            Controls.Add(lblZip);
            Controls.Add(lblEmail);
            Controls.Add(lblAccountNum);
            Controls.Add(lblCardNum);
            Controls.Add(lblPhone);

            Controls.Add(txtCustomerID);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtState);
            Controls.Add(txtZip);
            Controls.Add(txtEmail);
            Controls.Add(txtAccountNum);
            Controls.Add(txtCardNum);
            Controls.Add(txtPhone);

            Controls.Add(lstPhones);

            Controls.Add(btnAddPhone);
            Controls.Add(btnRemovePhone);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);

            Name = "CustomerDetailsForm";
            Text = "Customer Details";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}