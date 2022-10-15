namespace project
{
    partial class rent
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
            this.rentbookbtn = new System.Windows.Forms.Button();
            this.selectbookbtn = new System.Windows.Forms.Button();
            this.bookname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvrent = new System.Windows.Forms.DataGridView();
            this.seachbtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrent)).BeginInit();
            this.SuspendLayout();
            // 
            // rentbookbtn
            // 
            this.rentbookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentbookbtn.Location = new System.Drawing.Point(643, 424);
            this.rentbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.rentbookbtn.Name = "rentbookbtn";
            this.rentbookbtn.Size = new System.Drawing.Size(100, 36);
            this.rentbookbtn.TabIndex = 42;
            this.rentbookbtn.Text = "ยืม";
            this.rentbookbtn.UseVisualStyleBackColor = true;
            this.rentbookbtn.Click += new System.EventHandler(this.rentbookbtn_Click);
            // 
            // selectbookbtn
            // 
            this.selectbookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbookbtn.Location = new System.Drawing.Point(519, 424);
            this.selectbookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectbookbtn.Name = "selectbookbtn";
            this.selectbookbtn.Size = new System.Drawing.Size(100, 36);
            this.selectbookbtn.TabIndex = 41;
            this.selectbookbtn.Text = "เลือก";
            this.selectbookbtn.UseVisualStyleBackColor = true;
            this.selectbookbtn.Click += new System.EventHandler(this.selectbookbtn_Click);
            // 
            // bookname
            // 
            this.bookname.FormattingEnabled = true;
            this.bookname.Location = new System.Drawing.Point(240, 431);
            this.bookname.Margin = new System.Windows.Forms.Padding(4);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(201, 24);
            this.bookname.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "ชื่อหนังสือ";
            // 
            // dgvrent
            // 
            this.dgvrent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.dgvrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrent.Location = new System.Drawing.Point(122, 205);
            this.dgvrent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvrent.Name = "dgvrent";
            this.dgvrent.Size = new System.Drawing.Size(656, 200);
            this.dgvrent.TabIndex = 38;
            // 
            // seachbtn
            // 
            this.seachbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachbtn.Location = new System.Drawing.Point(643, 124);
            this.seachbtn.Margin = new System.Windows.Forms.Padding(4);
            this.seachbtn.Name = "seachbtn";
            this.seachbtn.Size = new System.Drawing.Size(100, 35);
            this.seachbtn.TabIndex = 37;
            this.seachbtn.Text = "ค้นหา";
            this.seachbtn.UseVisualStyleBackColor = true;
            this.seachbtn.Click += new System.EventHandler(this.seachbtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(240, 132);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 27);
            this.txtSearch.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "ค้นหา";
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(889, 599);
            this.Controls.Add(this.rentbookbtn);
            this.Controls.Add(this.selectbookbtn);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvrent);
            this.Controls.Add(this.seachbtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rent";
            this.Text = "rent";
            this.Load += new System.EventHandler(this.rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rentbookbtn;
        private System.Windows.Forms.Button selectbookbtn;
        private System.Windows.Forms.ComboBox bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvrent;
        private System.Windows.Forms.Button seachbtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;

    }
}