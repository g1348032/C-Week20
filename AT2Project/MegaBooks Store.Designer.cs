
namespace AT2Project
{
    partial class MegaBooksForm
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
            this.components = new System.ComponentModel.Container();
            this.btnBook = new System.Windows.Forms.Button();
            this.listBoxBook = new System.Windows.Forms.ListBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCustIdRead = new System.Windows.Forms.TextBox();
            this.txtIsbnRead = new System.Windows.Forms.TextBox();
            this.listBoxCust = new System.Windows.Forms.ListBox();
            this.listBoxTrans = new System.Windows.Forms.ListBox();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.toolTipCustId = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.Search.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(514, 124);
            this.btnBook.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(481, 41);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Add Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // listBoxBook
            // 
            this.listBoxBook.FormattingEnabled = true;
            this.listBoxBook.ItemHeight = 24;
            this.listBoxBook.Location = new System.Drawing.Point(514, 192);
            this.listBoxBook.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listBoxBook.Name = "listBoxBook";
            this.listBoxBook.Size = new System.Drawing.Size(476, 652);
            this.listBoxBook.TabIndex = 1;
            this.listBoxBook.Click += new System.EventHandler(this.listBoxBook_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(182, 164);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(186, 31);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(182, 116);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(186, 31);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(182, 308);
            this.txtDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(186, 31);
            this.txtDate.TabIndex = 4;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_KeyPress);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(182, 212);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(186, 31);
            this.txtPublisher.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Publisher";
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.Color.LightSalmon;
            this.txtIsbn.Location = new System.Drawing.Point(182, 68);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(186, 31);
            this.txtIsbn.TabIndex = 10;
            this.txtIsbn.DoubleClick += new System.EventHandler(this.txtIsbn_DoubleClick);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(56, 74);
            this.ISBN.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(60, 24);
            this.ISBN.TabIndex = 11;
            this.ISBN.Text = "ISBN";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(182, 260);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 31);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.ISBN);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(28, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(442, 373);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // Search
            // 
            this.Search.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.Search.Name = "contextMenuStrip1";
            this.Search.Size = new System.Drawing.Size(302, 42);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(301, 38);
            this.toolStripMenuItem1.Text = "Search Customer ID";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(498, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 78);
            this.label6.TabIndex = 17;
            this.label6.Text = "Books";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1066, 462);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 78);
            this.label7.TabIndex = 18;
            this.label7.Text = "Transactions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1066, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 78);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCustId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Location = new System.Drawing.Point(1081, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Size = new System.Drawing.Size(442, 277);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 74);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Cust ID";
            // 
            // txtCustId
            // 
            this.txtCustId.BackColor = System.Drawing.Color.LightGreen;
            this.txtCustId.ContextMenuStrip = this.Search;
            this.txtCustId.Location = new System.Drawing.Point(182, 68);
            this.txtCustId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(186, 31);
            this.txtCustId.TabIndex = 10;
            this.toolTipCustId.SetToolTip(this.txtCustId, "Right click to search,double click to clear.");
            this.txtCustId.DoubleClick += new System.EventHandler(this.txtCustId_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 218);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 122);
            this.label17.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 24);
            this.label17.TabIndex = 7;
            this.label17.Text = "Full Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(95, 170);
            this.label18.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "City";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(182, 212);
            this.txtMail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 31);
            this.txtMail.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 31);
            this.txtName.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(182, 164);
            this.txtCity.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(186, 31);
            this.txtCity.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTransId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCustIdRead);
            this.groupBox3.Controls.Add(this.txtIsbnRead);
            this.groupBox3.Location = new System.Drawing.Point(1081, 563);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Size = new System.Drawing.Size(442, 257);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Trans ID";
            // 
            // txtTransId
            // 
            this.txtTransId.BackColor = System.Drawing.SystemColors.Window;
            this.txtTransId.Location = new System.Drawing.Point(182, 68);
            this.txtTransId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(186, 31);
            this.txtTransId.TabIndex = 10;
            this.txtTransId.DoubleClick += new System.EventHandler(this.txtTransId_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = "Cust ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 170);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 24);
            this.label16.TabIndex = 6;
            this.label16.Text = "ISBN";
            // 
            // txtCustIdRead
            // 
            this.txtCustIdRead.BackColor = System.Drawing.Color.LightGreen;
            this.txtCustIdRead.Location = new System.Drawing.Point(182, 116);
            this.txtCustIdRead.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCustIdRead.Name = "txtCustIdRead";
            this.txtCustIdRead.ReadOnly = true;
            this.txtCustIdRead.Size = new System.Drawing.Size(186, 31);
            this.txtCustIdRead.TabIndex = 3;
            // 
            // txtIsbnRead
            // 
            this.txtIsbnRead.BackColor = System.Drawing.Color.LightSalmon;
            this.txtIsbnRead.Location = new System.Drawing.Point(182, 164);
            this.txtIsbnRead.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtIsbnRead.Name = "txtIsbnRead";
            this.txtIsbnRead.ReadOnly = true;
            this.txtIsbnRead.Size = new System.Drawing.Size(186, 31);
            this.txtIsbnRead.TabIndex = 2;
            // 
            // listBoxCust
            // 
            this.listBoxCust.FormattingEnabled = true;
            this.listBoxCust.ItemHeight = 24;
            this.listBoxCust.Location = new System.Drawing.Point(1614, 124);
            this.listBoxCust.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listBoxCust.Name = "listBoxCust";
            this.listBoxCust.Size = new System.Drawing.Size(485, 316);
            this.listBoxCust.TabIndex = 29;
            this.listBoxCust.Click += new System.EventHandler(this.listBoxCust_Click);
            // 
            // listBoxTrans
            // 
            this.listBoxTrans.FormattingEnabled = true;
            this.listBoxTrans.ItemHeight = 24;
            this.listBoxTrans.Location = new System.Drawing.Point(1614, 563);
            this.listBoxTrans.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listBoxTrans.Name = "listBoxTrans";
            this.listBoxTrans.Size = new System.Drawing.Size(485, 316);
            this.listBoxTrans.TabIndex = 30;
            this.listBoxTrans.Click += new System.EventHandler(this.listBoxTrans_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(1614, 72);
            this.btnCus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(490, 41);
            this.btnCus.TabIndex = 31;
            this.btnCus.Text = "Add Customer";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(1614, 493);
            this.btnTrans.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(490, 41);
            this.btnTrans.TabIndex = 32;
            this.btnTrans.Text = "Add Transaction";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // MegaBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2262, 958);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.listBoxTrans);
            this.Controls.Add(this.listBoxCust);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxBook);
            this.Controls.Add(this.btnBook);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MegaBooksForm";
            this.Text = "MegaBooksStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MegaBooksForm_FormClosing);
            this.Load += new System.EventHandler(this.MegaBooksForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Search.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ListBox listBoxBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCustIdRead;
        private System.Windows.Forms.TextBox txtIsbnRead;
        private System.Windows.Forms.ListBox listBoxCust;
        private System.Windows.Forms.ListBox listBoxTrans;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.ToolTip toolTipCustId;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

