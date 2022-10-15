namespace project
{
    partial class book
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.seachbtn = new System.Windows.Forms.Button();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.bookQty = new System.Windows.Forms.TextBox();
            this.booktype = new System.Windows.Forms.ComboBox();
            this.createbookbtn = new System.Windows.Forms.Button();
            this.editbookbtn = new System.Windows.Forms.Button();
            this.deletebookbtn = new System.Windows.Forms.Button();
            this.savebookbtn = new System.Windows.Forms.Button();
            this.newbookbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ค้นหา";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(272, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(439, 34);
            this.txtSearch.TabIndex = 1;
            // 
            // seachbtn
            // 
            this.seachbtn.Location = new System.Drawing.Point(751, 48);
            this.seachbtn.Margin = new System.Windows.Forms.Padding(4);
            this.seachbtn.Name = "seachbtn";
            this.seachbtn.Size = new System.Drawing.Size(100, 28);
            this.seachbtn.TabIndex = 2;
            this.seachbtn.Text = "ค้นหา";
            this.seachbtn.UseVisualStyleBackColor = true;
            this.seachbtn.Click += new System.EventHandler(this.seachbtn_Click);
            // 
            // dgvbook
            // 
            this.dgvbook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Location = new System.Drawing.Point(196, 103);
            this.dgvbook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.Size = new System.Drawing.Size(634, 185);
            this.dgvbook.TabIndex = 3;
            this.dgvbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbook_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "รหัสหนังสือ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ชื่อหนังสือ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ประเถทหนังสือ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "จำนวนหนังสือ";
            // 
            // bookid
            // 
            this.bookid.Location = new System.Drawing.Point(308, 313);
            this.bookid.Margin = new System.Windows.Forms.Padding(4);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(160, 22);
            this.bookid.TabIndex = 8;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(691, 318);
            this.bookname.Margin = new System.Windows.Forms.Padding(4);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(160, 22);
            this.bookname.TabIndex = 9;
            // 
            // bookQty
            // 
            this.bookQty.Location = new System.Drawing.Point(691, 380);
            this.bookQty.Margin = new System.Windows.Forms.Padding(4);
            this.bookQty.Name = "bookQty";
            this.bookQty.Size = new System.Drawing.Size(160, 22);
            this.bookQty.TabIndex = 11;
            // 
            // booktype
            // 
            this.booktype.FormattingEnabled = true;
            this.booktype.Location = new System.Drawing.Point(308, 379);
            this.booktype.Margin = new System.Windows.Forms.Padding(4);
            this.booktype.Name = "booktype";
            this.booktype.Size = new System.Drawing.Size(160, 24);
            this.booktype.TabIndex = 12;
            // 
            // createbookbtn
            // 
            this.createbookbtn.Location = new System.Drawing.Point(233, 475);
            this.createbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.createbookbtn.Name = "createbookbtn";
            this.createbookbtn.Size = new System.Drawing.Size(86, 31);
            this.createbookbtn.TabIndex = 13;
            this.createbookbtn.Text = "Create";
            this.createbookbtn.UseVisualStyleBackColor = true;
            this.createbookbtn.Click += new System.EventHandler(this.createbookbtn_Click);
            // 
            // editbookbtn
            // 
            this.editbookbtn.Location = new System.Drawing.Point(359, 475);
            this.editbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.editbookbtn.Name = "editbookbtn";
            this.editbookbtn.Size = new System.Drawing.Size(86, 31);
            this.editbookbtn.TabIndex = 14;
            this.editbookbtn.Text = "Edit";
            this.editbookbtn.UseVisualStyleBackColor = true;
            this.editbookbtn.Click += new System.EventHandler(this.editbookbtn_Click);
            // 
            // deletebookbtn
            // 
            this.deletebookbtn.Location = new System.Drawing.Point(485, 475);
            this.deletebookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletebookbtn.Name = "deletebookbtn";
            this.deletebookbtn.Size = new System.Drawing.Size(86, 31);
            this.deletebookbtn.TabIndex = 15;
            this.deletebookbtn.Text = "Delete";
            this.deletebookbtn.UseVisualStyleBackColor = true;
            this.deletebookbtn.Click += new System.EventHandler(this.deletebookbtn_Click);
            // 
            // savebookbtn
            // 
            this.savebookbtn.Location = new System.Drawing.Point(611, 475);
            this.savebookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.savebookbtn.Name = "savebookbtn";
            this.savebookbtn.Size = new System.Drawing.Size(86, 31);
            this.savebookbtn.TabIndex = 16;
            this.savebookbtn.Text = "Save";
            this.savebookbtn.UseVisualStyleBackColor = true;
            this.savebookbtn.Click += new System.EventHandler(this.savebookbtn_Click);
            // 
            // newbookbtn
            // 
            this.newbookbtn.Location = new System.Drawing.Point(731, 475);
            this.newbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.newbookbtn.Name = "newbookbtn";
            this.newbookbtn.Size = new System.Drawing.Size(86, 31);
            this.newbookbtn.TabIndex = 17;
            this.newbookbtn.Text = "New";
            this.newbookbtn.UseVisualStyleBackColor = true;
            this.newbookbtn.Click += new System.EventHandler(this.newbookbtn_Click);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 658);
            this.Controls.Add(this.newbookbtn);
            this.Controls.Add(this.savebookbtn);
            this.Controls.Add(this.deletebookbtn);
            this.Controls.Add(this.editbookbtn);
            this.Controls.Add(this.createbookbtn);
            this.Controls.Add(this.booktype);
            this.Controls.Add(this.bookQty);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvbook);
            this.Controls.Add(this.seachbtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "book";
            this.Text = "book";
            this.Load += new System.EventHandler(this.book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button seachbtn;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox bookQty;
        private System.Windows.Forms.ComboBox booktype;
        private System.Windows.Forms.Button createbookbtn;
        private System.Windows.Forms.Button editbookbtn;
        private System.Windows.Forms.Button deletebookbtn;
        private System.Windows.Forms.Button savebookbtn;
        private System.Windows.Forms.Button newbookbtn;
    }
}