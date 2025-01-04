namespace Inventory_System
{
    partial class frmInvoice
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
            this.btnback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.dataGridViewbill = new System.Windows.Forms.DataGridView();
            this.grdtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTransactionLog = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbillNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(20, 576);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(79, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "BILL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "CUSTOMER DETAILS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "NAME";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(23, 260);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(198, 20);
            this.txtname.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "MOBILE";
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.Location = new System.Drawing.Point(23, 313);
            this.txtmobile.Multiline = true;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(198, 20);
            this.txtmobile.TabIndex = 22;
            // 
            // dataGridViewbill
            // 
            this.dataGridViewbill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItem,
            this.grdquantity,
            this.grdprice,
            this.grdtotal});
            this.dataGridViewbill.Location = new System.Drawing.Point(238, 125);
            this.dataGridViewbill.Name = "dataGridViewbill";
            this.dataGridViewbill.Size = new System.Drawing.Size(445, 474);
            this.dataGridViewbill.TabIndex = 24;
            // 
            // grdtotal
            // 
            this.grdtotal.HeaderText = "TOTAL";
            this.grdtotal.Name = "grdtotal";
            // 
            // grdprice
            // 
            this.grdprice.HeaderText = "PRICE";
            this.grdprice.Name = "grdprice";
            // 
            // grdquantity
            // 
            this.grdquantity.HeaderText = "QUANTITY";
            this.grdquantity.Name = "grdquantity";
            // 
            // grdItem
            // 
            this.grdItem.HeaderText = "ITEMS";
            this.grdItem.Name = "grdItem";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtbillNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeTransactionLog);
            this.groupBox1.Controls.Add(this.dataGridViewbill);
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-8, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 649);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAFEWAY GENERAL STORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "DATE";
            // 
            // dateTimeTransactionLog
            // 
            this.dateTimeTransactionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTransactionLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransactionLog.Location = new System.Drawing.Point(23, 145);
            this.dateTimeTransactionLog.Name = "dateTimeTransactionLog";
            this.dateTimeTransactionLog.Size = new System.Drawing.Size(101, 22);
            this.dateTimeTransactionLog.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "NO:";
            // 
            // txtbillNo
            // 
            this.txtbillNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillNo.Location = new System.Drawing.Point(23, 84);
            this.txtbillNo.Multiline = true;
            this.txtbillNo.Name = "txtbillNo";
            this.txtbillNo.ReadOnly = true;
            this.txtbillNo.Size = new System.Drawing.Size(84, 19);
            this.txtbillNo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "INVOICE";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 708);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.DataGridView dataGridViewbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeTransactionLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbillNo;
        private System.Windows.Forms.Label label1;
    }
}