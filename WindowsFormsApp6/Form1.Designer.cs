using System.Windows.Forms;

namespace WindowsFormsApp6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckEligibility = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblCopyStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBookTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLoanInfo = new System.Windows.Forms.GroupBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmLoan = new System.Windows.Forms.Button();
            this.lblmistake = new System.Windows.Forms.Label();
            this.lblMistake2 = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpMemberDetails.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            this.grpLoanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.BackColor = System.Drawing.Color.White;
            this.grpMemberDetails.Controls.Add(this.groupBox1);
            this.grpMemberDetails.Controls.Add(this.btnCheckEligibility);
            this.grpMemberDetails.Controls.Add(this.txtUserID);
            this.grpMemberDetails.Controls.Add(this.lblMemberID);
            this.grpMemberDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberDetails.ForeColor = System.Drawing.Color.Teal;
            this.grpMemberDetails.Location = new System.Drawing.Point(-1, 73);
            this.grpMemberDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpMemberDetails.Size = new System.Drawing.Size(488, 131);
            this.grpMemberDetails.TabIndex = 0;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details";
            this.grpMemberDetails.Enter += new System.EventHandler(this.grpMemberDetails_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(467, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCheckEligibility
            // 
            this.btnCheckEligibility.BackColor = System.Drawing.Color.Teal;
            this.btnCheckEligibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckEligibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEligibility.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEligibility.ForeColor = System.Drawing.Color.White;
            this.btnCheckEligibility.Location = new System.Drawing.Point(255, 33);
            this.btnCheckEligibility.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckEligibility.Name = "btnCheckEligibility";
            this.btnCheckEligibility.Size = new System.Drawing.Size(130, 30);
            this.btnCheckEligibility.TabIndex = 2;
            this.btnCheckEligibility.Text = "Check Eligibility";
            this.btnCheckEligibility.UseVisualStyleBackColor = false;
            this.btnCheckEligibility.Click += new System.EventHandler(this.btnCheckEligibility_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(112, 35);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(116, 25);
            this.txtUserID.TabIndex = 1;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.DimGray;
            this.lblMemberID.Location = new System.Drawing.Point(14, 39);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(81, 17);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID:";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.BackColor = System.Drawing.Color.White;
            this.grpBookInfo.Controls.Add(this.lblCopyStatus);
            this.grpBookInfo.Controls.Add(this.label3);
            this.grpBookInfo.Controls.Add(this.txtCopyID);
            this.grpBookInfo.Controls.Add(this.label2);
            this.grpBookInfo.Controls.Add(this.cmbBookTitle);
            this.grpBookInfo.Controls.Add(this.label1);
            this.grpBookInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfo.ForeColor = System.Drawing.Color.Teal;
            this.grpBookInfo.Location = new System.Drawing.Point(2, 214);
            this.grpBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBookInfo.Size = new System.Drawing.Size(477, 186);
            this.grpBookInfo.TabIndex = 1;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Info";
            // 
            // lblCopyStatus
            // 
            this.lblCopyStatus.AutoSize = true;
            this.lblCopyStatus.Location = new System.Drawing.Point(98, 131);
            this.lblCopyStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyStatus.Name = "lblCopyStatus";
            this.lblCopyStatus.Size = new System.Drawing.Size(13, 17);
            this.lblCopyStatus.TabIndex = 5;
            this.lblCopyStatus.Text = "-";
            this.lblCopyStatus.Click += new System.EventHandler(this.lblCopyStatus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCopyID
            // 
            this.txtCopyID.AccessibleName = "txtCopyID";
            this.txtCopyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCopyID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyID.Location = new System.Drawing.Point(102, 88);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(116, 25);
            this.txtCopyID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copy ID:";
            // 
            // cmbBookTitle
            // 
            this.cmbBookTitle.AccessibleName = "txtCopyID";
            this.cmbBookTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookTitle.FormattingEnabled = true;
            this.cmbBookTitle.Location = new System.Drawing.Point(102, 37);
            this.cmbBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBookTitle.Name = "cmbBookTitle";
            this.cmbBookTitle.Size = new System.Drawing.Size(140, 25);
            this.cmbBookTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title:";
            // 
            // grpLoanInfo
            // 
            this.grpLoanInfo.BackColor = System.Drawing.Color.White;
            this.grpLoanInfo.Controls.Add(this.dtpReturnDate);
            this.grpLoanInfo.Controls.Add(this.label5);
            this.grpLoanInfo.Controls.Add(this.dtpLoanDate);
            this.grpLoanInfo.Controls.Add(this.label4);
            this.grpLoanInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanInfo.ForeColor = System.Drawing.Color.Teal;
            this.grpLoanInfo.Location = new System.Drawing.Point(2, 418);
            this.grpLoanInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpLoanInfo.Name = "grpLoanInfo";
            this.grpLoanInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpLoanInfo.Size = new System.Drawing.Size(467, 131);
            this.grpLoanInfo.TabIndex = 2;
            this.grpLoanInfo.TabStop = false;
            this.grpLoanInfo.Text = "Loan Info";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(102, 86);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(233, 25);
            this.dtpReturnDate.TabIndex = 3;
            this.dtpReturnDate.Value = new System.DateTime(2025, 6, 7, 0, 0, 0, 0);
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Return Date:";
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpLoanDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(102, 43);
            this.dtpLoanDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(233, 25);
            this.dtpLoanDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loan Date:";
            // 
            // btnConfirmLoan
            // 
            this.btnConfirmLoan.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmLoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmLoan.ForeColor = System.Drawing.Color.White;
            this.btnConfirmLoan.Location = new System.Drawing.Point(-1, 570);
            this.btnConfirmLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmLoan.Name = "btnConfirmLoan";
            this.btnConfirmLoan.Size = new System.Drawing.Size(117, 30);
            this.btnConfirmLoan.TabIndex = 3;
            this.btnConfirmLoan.Text = "Confirm Loan";
            this.btnConfirmLoan.UseVisualStyleBackColor = false;
            this.btnConfirmLoan.Click += new System.EventHandler(this.btnConfirmLoan_Click);
            // 
            // lblmistake
            // 
            this.lblmistake.AutoSize = true;
            this.lblmistake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblmistake.Location = new System.Drawing.Point(276, 543);
            this.lblmistake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmistake.Name = "lblmistake";
            this.lblmistake.Size = new System.Drawing.Size(0, 17);
            this.lblmistake.TabIndex = 4;
            // 
            // lblMistake2
            // 
            this.lblMistake2.AutoSize = true;
            this.lblMistake2.ForeColor = System.Drawing.Color.Red;
            this.lblMistake2.Location = new System.Drawing.Point(10, 585);
            this.lblMistake2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMistake2.Name = "lblMistake2";
            this.lblMistake2.Size = new System.Drawing.Size(0, 17);
            this.lblMistake2.TabIndex = 5;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Teal;
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(479, 32);
            this.lblFormTitle.TabIndex = 7;
            this.lblFormTitle.Text = "📚 Sarasavi Library System-Loan Process";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 645);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(23, 17);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "---";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(353, 446);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(929, 662);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblMistake2);
            this.Controls.Add(this.lblmistake);
            this.Controls.Add(this.btnConfirmLoan);
            this.Controls.Add(this.grpLoanInfo);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.grpMemberDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sarasavi Library - Loan Process";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.grpLoanInfo.ResumeLayout(false);
            this.grpLoanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckEligibility;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.Label lblCopyStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpLoanInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnConfirmLoan;
        private Label lblmistake;
        private Label lblMistake2;
        private Label lblFormTitle;
        private Label lblMessage;
        private PictureBox pictureBox2;
    }
}

