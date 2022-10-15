using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//////////*********
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        public static string cn = "Data Source=.; initial Catalog=book; Trusted_Connection=True";

        private void book_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Book";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "B");
            dgvbook.DataSource = ds.Tables["B"];

            string sql1 = "SELECT* FROM ViewBook";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.Fill(ds, "VB");
            dgvbook.DataSource = ds.Tables["VB"];

            string sql2 = "SELECT* FROM Book_Type";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.Fill(ds, "BT");

            booktype.DisplayMember = "Book_Type_Name";
            booktype.ValueMember = "Book_Type_ID";
            booktype.DataSource = ds.Tables["BT"];
        }

        private void seachbtn_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SECH"))
                ds.Tables.Remove("SECH");
            string sql = "SELECT * FROM ViewBook WHERE Book_Name LIKE '%" + txtSearch.Text + "%' OR Book_Type_Name LIKE '%" + txtSearch.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "SECH");

            dgvbook.DataSource = ds.Tables["SECH"];//อัพเดทหน้าจอ
        }

        private void createbookbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["B"].Select("Book_ID='" + bookid.Text + "'");
            if (dr.Length == 0)
            {
                DataRow drd = ds.Tables["B"].NewRow();
                drd["Book_ID"] = bookid.Text;
                drd["Book_Name"] = bookname.Text;
                drd["Book_Type_ID"] = booktype.SelectedValue;
                drd["Book_Quantity"] = bookQty.Text;
                ds.Tables["B"].Rows.Add(drd);

            }
            else
            {
                MessageBox.Show("เลข ID ซ้ำ", "ERROR");
            }
            dgvbook.DataSource = ds.Tables["B"];
        }

        private void editbookbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["B"].Select("Book_ID='" + bookid.Text + "'");
            if (dr.Length == 0)//ไม่มีข้อมูล id ตัวนั้น
            {
                MessageBox.Show("ไม่พบข้อมูลที่จะลบ", "ERROR");
            }
            else
            {
                dr[0]["Book_Name"] = bookname.Text;
                dr[0]["Book_Type_ID"] = booktype.SelectedValue;
                dr[0]["Book_Quantity"] = bookQty.Text;
                dgvbook.DataSource = ds.Tables["B"];//อัพเดทหน้าจอ
            }
        }

        private void deletebookbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["B"].Select("Book_ID='" + bookid.Text + "'");
            if (dr.Length == 0)//ไม่มีข้อมูล id ตัวนั้น
            {
                MessageBox.Show("ไม่พบข้อมูลที่จะลบ", "ERROR");
            }
            else
            {
                dr[0].Delete();

                //บันทึกข้อมูล
                string sql = "SELECT * FROM Book";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "B");
                ds.Tables["B"].AcceptChanges();

                dgvbook.DataSource = ds.Tables["B"];//อัพเดทหน้าจอ

            }
        }

        private void savebookbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Book";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "B");
        }

        private void newbookbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TOP 1 * FROM Book ORDER BY Book_ID DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            int topid = Convert.ToInt32(dt.Rows[0]["Book_ID"]) + 1;
            bookid.Text = topid.ToString();
            bookname.Text = " ";
            booktype.SelectedValue = 1;
        }

        private void dgvbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                dgvbook.Rows[e.RowIndex].Selected = true;
                DataRow dr = ds.Tables["B"].Rows[e.RowIndex];
                bookid.Text = dr["Book_ID"].ToString();
                bookname.Text = dr["Book_Name"].ToString();
                booktype.SelectedValue = dr["Book_Type_ID"].ToString();
                bookQty.Text = dr["Book_Quantity"].ToString();
            }
        }
    }
}
