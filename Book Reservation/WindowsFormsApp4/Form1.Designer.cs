using System.Windows.Forms;
namespace WindowsFormsApp4
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxReservation = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccessionNo = new System.Windows.Forms.Label();
            this.txtAccessionNo = new System.Windows.Forms.TextBox();
            this.lblBorrowerId = new System.Windows.Forms.Label();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.btnReservationSearch = new System.Windows.Forms.Button();
            this.dgvReservationResults = new System.Windows.Forms.DataGridView();
            this.btnConfirmReservation = new System.Windows.Forms.Button();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.Controls.Add(this.groupBox1);
            this.groupBoxReservation.Controls.Add(this.pictureBox1);
            this.groupBoxReservation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(1086, 380);
            this.groupBoxReservation.TabIndex = 0;
            this.groupBoxReservation.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(750, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 355);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccessionNo
            // 
            this.lblAccessionNo.AutoSize = true;
            this.lblAccessionNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAccessionNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblAccessionNo.Location = new System.Drawing.Point(16, 61);
            this.lblAccessionNo.Name = "lblAccessionNo";
            this.lblAccessionNo.Size = new System.Drawing.Size(94, 17);
            this.lblAccessionNo.TabIndex = 0;
            this.lblAccessionNo.Text = "Accession No:";
            // 
            // txtAccessionNo
            // 
            this.txtAccessionNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccessionNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAccessionNo.Location = new System.Drawing.Point(126, 58);
            this.txtAccessionNo.Name = "txtAccessionNo";
            this.txtAccessionNo.Size = new System.Drawing.Size(200, 25);
            this.txtAccessionNo.TabIndex = 1;
            // 
            // lblBorrowerId
            // 
            this.lblBorrowerId.AutoSize = true;
            this.lblBorrowerId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBorrowerId.ForeColor = System.Drawing.Color.DimGray;
            this.lblBorrowerId.Location = new System.Drawing.Point(16, 96);
            this.lblBorrowerId.Name = "lblBorrowerId";
            this.lblBorrowerId.Size = new System.Drawing.Size(86, 17);
            this.lblBorrowerId.TabIndex = 2;
            this.lblBorrowerId.Text = "Borrower ID:";
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBorrowerId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBorrowerId.Location = new System.Drawing.Point(126, 93);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(200, 25);
            this.txtBorrowerId.TabIndex = 3;
            // 
            // btnReservationSearch
            // 
            this.btnReservationSearch.BackColor = System.Drawing.Color.Teal;
            this.btnReservationSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservationSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReservationSearch.ForeColor = System.Drawing.Color.White;
            this.btnReservationSearch.Location = new System.Drawing.Point(346, 71);
            this.btnReservationSearch.Name = "btnReservationSearch";
            this.btnReservationSearch.Size = new System.Drawing.Size(117, 30);
            this.btnReservationSearch.TabIndex = 4;
            this.btnReservationSearch.Text = "Check Availability";
            this.btnReservationSearch.UseVisualStyleBackColor = false;
            this.btnReservationSearch.Click += new System.EventHandler(this.btnReservationSearch_Click);
            // 
            // dgvReservationResults
            // 
            this.dgvReservationResults.AllowUserToAddRows = false;
            this.dgvReservationResults.AllowUserToDeleteRows = false;
            this.dgvReservationResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservationResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationResults.Location = new System.Drawing.Point(16, 135);
            this.dgvReservationResults.Name = "dgvReservationResults";
            this.dgvReservationResults.ReadOnly = true;
            this.dgvReservationResults.Size = new System.Drawing.Size(700, 150);
            this.dgvReservationResults.TabIndex = 5;
            // 
            // btnConfirmReservation
            // 
            this.btnConfirmReservation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmReservation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReservation.Location = new System.Drawing.Point(256, 310);
            this.btnConfirmReservation.Name = "btnConfirmReservation";
            this.btnConfirmReservation.Size = new System.Drawing.Size(182, 30);
            this.btnConfirmReservation.TabIndex = 6;
            this.btnConfirmReservation.Text = "Confirm Reservation";
            this.btnConfirmReservation.UseVisualStyleBackColor = false;
            this.btnConfirmReservation.Click += new System.EventHandler(this.btnConfirmReservation_Click);
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservationStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReservationStatus.Location = new System.Drawing.Point(16, 318);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(700, 30);
            this.lblReservationStatus.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblAccessionNo);
            this.groupBox1.Controls.Add(this.txtAccessionNo);
            this.groupBox1.Controls.Add(this.lblBorrowerId);
            this.groupBox1.Controls.Add(this.txtBorrowerId);
            this.groupBox1.Controls.Add(this.btnReservationSearch);
            this.groupBox1.Controls.Add(this.dgvReservationResults);
            this.groupBox1.Controls.Add(this.btnConfirmReservation);
            this.groupBox1.Controls.Add(this.lblReservationStatus);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 354);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Reservation";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1102, 394);
            this.Controls.Add(this.groupBoxReservation);
            this.Name = "Form1";
            this.Text = "Book Reservation";
            this.groupBoxReservation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReservation;
        private System.Windows.Forms.Label lblAccessionNo;
        private System.Windows.Forms.TextBox txtAccessionNo;
        private System.Windows.Forms.Label lblBorrowerId;
        private System.Windows.Forms.TextBox txtBorrowerId;
        private System.Windows.Forms.Button btnReservationSearch;
        private System.Windows.Forms.DataGridView dgvReservationResults;
        private System.Windows.Forms.Button btnConfirmReservation;
        private System.Windows.Forms.Label lblReservationStatus;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}
