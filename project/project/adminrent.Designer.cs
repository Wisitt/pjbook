namespace project
{
    partial class adminrent
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
            this.newbookbtn = new System.Windows.Forms.Button();
            this.returnbookbtn = new System.Windows.Forms.Button();
            this.booktype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvrent = new System.Windows.Forms.DataGridView();
            this.seachbtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.bookQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrent)).BeginInit();
            this.SuspendLayout();
            // 
            // newbookbtn
            // 
            this.newbookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbookbtn.Location = new System.Drawing.Point(447, 559);
            this.newbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.newbookbtn.Name = "newbookbtn";
            this.newbookbtn.Size = new System.Drawing.Size(114, 42);
            this.newbookbtn.TabIndex = 34;
            this.newbookbtn.Text = "ยืนยัน";
            this.newbookbtn.UseVisualStyleBackColor = true;
            this.newbookbtn.Click += new System.EventHandler(this.newbookbtn_Click);
            // 
            // returnbookbtn
            // 
            this.returnbookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbookbtn.Location = new System.Drawing.Point(299, 559);
            this.returnbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.returnbookbtn.Name = "returnbookbtn";
            this.returnbookbtn.Size = new System.Drawing.Size(114, 42);
            this.returnbookbtn.TabIndex = 30;
            this.returnbookbtn.Text = "คืน";
            this.returnbookbtn.UseVisualStyleBackColor = true;
            this.returnbookbtn.Click += new System.EventHandler(this.returnbookbtn_Click);
            // 
            // booktype
            // 
            this.booktype.FormattingEnabled = true;
            this.booktype.Location = new System.Drawing.Point(290, 496);
            this.booktype.Margin = new System.Windows.Forms.Padding(4);
            this.booktype.Name = "booktype";
            this.booktype.Size = new System.Drawing.Size(132, 24);
            this.booktype.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 430);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "ชื่อผู้ยืม";
            // 
            // dgvrent
            // 
            this.dgvrent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dgvrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrent.Location = new System.Drawing.Point(103, 205);
            this.dgvrent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvrent.Name = "dgvrent";
            this.dgvrent.Size = new System.Drawing.Size(704, 205);
            this.dgvrent.TabIndex = 21;
            this.dgvrent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbook_CellClick);
            // 
            // seachbtn
            // 
            this.seachbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachbtn.Location = new System.Drawing.Point(645, 139);
            this.seachbtn.Margin = new System.Windows.Forms.Padding(4);
            this.seachbtn.Name = "seachbtn";
            this.seachbtn.Size = new System.Drawing.Size(100, 30);
            this.seachbtn.TabIndex = 20;
            this.seachbtn.Text = "ค้นหา";
            this.seachbtn.UseVisualStyleBackColor = true;
            this.seachbtn.Click += new System.EventHandler(this.seachbtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(245, 130);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 39);
            this.txtSearch.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "ค้นหา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 491);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "ชื่อหนังสือ";
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(600, 432);
            this.bookname.Margin = new System.Windows.Forms.Padding(4);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(135, 22);
            this.bookname.TabIndex = 27;
            // 
            // bookQty
            // 
            this.bookQty.Location = new System.Drawing.Point(600, 494);
            this.bookQty.Margin = new System.Windows.Forms.Padding(4);
            this.bookQty.Name = "bookQty";
            this.bookQty.Size = new System.Drawing.Size(135, 22);
            this.bookQty.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "วันที่ยืม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "รหัสยืมหนังสือ";
            // 
            // bookid
            // 
            this.bookid.Location = new System.Drawing.Point(290, 430);
            this.bookid.Margin = new System.Windows.Forms.Padding(4);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(132, 22);
            this.bookid.TabIndex = 26;
            // 
            // adminrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(915, 687);
            this.Controls.Add(this.newbookbtn);
            this.Controls.Add(this.returnbookbtn);
            this.Controls.Add(this.booktype);
            this.Controls.Add(this.bookQty);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvrent);
            this.Controls.Add(this.seachbtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminrent";
            this.Text = "adminrent";
            this.Load += new System.EventHandler(this.adminrent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newbookbtn;
        private System.Windows.Forms.Button returnbookbtn;
        private System.Windows.Forms.ComboBox booktype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvrent;
        private System.Windows.Forms.Button seachbtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox bookQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookid;
    }
}