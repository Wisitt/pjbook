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
    public partial class adminrent : Form
    {
        public adminrent()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        public static string cn = "Data Source=.; initial Catalog=book; Trusted_Connection=True";

        private void adminrent_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Rent";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "R");
            dgvrent.DataSource = ds.Tables["R"];

            string sql1 = "SELECT Book_Rent_ID,Date,Fname,Book_Name,Status FROM ViewRent";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.Fill(ds, "VR");
            dgvrent.DataSource = ds.Tables["VR"];
        }

        private void dgvbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                dgvrent.Rows[e.RowIndex].Selected = true;
                DataRow dr = ds.Tables["VR"].Rows[e.RowIndex];
                bookid.Text = dr["Book_Rent_ID"].ToString();
                bookname.Text = dr["Fname"].ToString();
                booktype.Text = dr["Date"].ToString();
                bookQty.Text = dr["Book_Name"].ToString();
            }
        }

        private void returnbookbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["R"].Select("Book_Rent_ID='" + bookid.Text + "'");
            if (dr.Length == 0)//ไม่มีข้อมูล id ตัวนั้น
            {
                MessageBox.Show("ไม่พบข้อมูลการยืม", "ERROR");
            }
            else
            {
                dr[0]["Status"] = "1";
                dgvrent.DataSource = ds.Tables["R"];//อัพเดทหน้าจอ
            }
        }

        private void seachbtn_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SECH"))
                ds.Tables.Remove("SECH");
            string sql = "SELECT * FROM ViewRent WHERE Username LIKE '%" + txtSearch.Text + "%' OR Status LIKE '%" + txtSearch.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "SECH");

            dgvrent.DataSource = ds.Tables["SECH"];//อัพเดทหน้าจอ
        }

        private void newbookbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Rent";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "R");


        }



    }
}
