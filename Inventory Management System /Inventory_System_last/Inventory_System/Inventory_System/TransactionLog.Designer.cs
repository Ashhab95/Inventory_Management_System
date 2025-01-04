
namespace Inventory_System
{
    partial class frmTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridViewTransactionLog = new System.Windows.Forms.DataGridView();
            this.grdbillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTransactionLog = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.dataGridViewTransactionLog);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeTransactionLog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(152, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(29, 583);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(79, 23);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridViewTransactionLog
            // 
            this.dataGridViewTransactionLog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdbillNo,
            this.grdname,
            this.grdmobile,
            this.grdtotal,
            this.grddate});
            this.dataGridViewTransactionLog.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTransactionLog.Location = new System.Drawing.Point(241, 91);
            this.dataGridViewTransactionLog.Name = "dataGridViewTransactionLog";
            this.dataGridViewTransactionLog.Size = new System.Drawing.Size(644, 448);
            this.dataGridViewTransactionLog.TabIndex = 3;
            // 
            // grdbillNo
            // 
            this.grdbillNo.HeaderText = "Bill No";
            this.grdbillNo.Name = "grdbillNo";
            // 
            // grdname
            // 
            this.grdname.HeaderText = "NAME";
            this.grdname.Name = "grdname";
            // 
            // grdmobile
            // 
            this.grdmobile.HeaderText = "MOBILE";
            this.grdmobile.Name = "grdmobile";
            // 
            // grdtotal
            // 
            this.grdtotal.HeaderText = "TOTAL";
            this.grdtotal.Name = "grdtotal";
            // 
            // grddate
            // 
            this.grddate.HeaderText = "DATE";
            this.grddate.Name = "grddate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATE";
            // 
            // dateTimeTransactionLog
            // 
            this.dateTimeTransactionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTransactionLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransactionLog.Location = new System.Drawing.Point(29, 111);
            this.dateTimeTransactionLog.Name = "dateTimeTransactionLog";
            this.dateTimeTransactionLog.Size = new System.Drawing.Size(101, 22);
            this.dateTimeTransactionLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Log";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 649);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionLog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTransactionLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeTransactionLog;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdbillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn grddate;
    }
}