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
    public partial class rent : Form
    {
        public rent()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        public static string cn = "Data Source=.; initial Catalog=book; Trusted_Connection=True";
        public static string id = "";

        private void rent_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Rent WHERE ID = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "R");
            dgvrent.DataSource = ds.Tables["R"];

            string sql1 = "SELECT Book_Rent_ID, Fname, Book_Name, Book_Type_Name, Date FROM ViewRent WHERE ID = '" + id + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.Fill(ds, "VR");
            dgvrent.DataSource = ds.Tables["VR"];


            string sql2 = "SELECT* FROM ViewBookRemain WHERE Remain > 0";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.Fill(ds, "VB");


            bookname.DisplayMember = "Book_Name";
            bookname.ValueMember = "Book_ID";
            bookname.DataSource = ds.Tables["VB"];
        }

        private void selectbookbtn_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT TOP 1 * FROM ViewRent ORDER BY Book_Rent_ID DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sql3, cn);
            da2.Fill(dt);
            int topid = Convert.ToInt32(dt.Rows[0]["Book_Rent_ID"]) + 1;
            DataRow[] dr = ds.Tables["R"].Select("Book_Rent_ID='" + topid.ToString() + "'");
            if (dr.Length == 0)
            {

                DataRow drd = ds.Tables["R"].NewRow();
                drd["Book_Rent_ID"] = topid.ToString();
                drd["Book_ID"] = bookname.SelectedValue;
                drd["ID"] = id;
                drd["Date"] = DateTime.Now.ToString("D");
                drd["Status"] = "0";
                ds.Tables["R"].Rows.Add(drd);


            }
            else
            {
                MessageBox.Show("เลข ID ซ้ำ", "ERROR");
            }
            dgvrent.DataSource = ds.Tables["R"];
        }

        private void rentbookbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Rent WHERE ID = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "R");
            string sql1 = "SELECT* FROM Rent WHERE ID = '" + id + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da.Fill(ds, "R");
            dgvrent.DataSource = ds.Tables["R"];
        }

        private void seachbtn_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SECH"))
                ds.Tables.Remove("SECH");
            string sql = "SELECT * FROM ViewRent WHERE Book_Name LIKE '%" + txtSearch.Text + "%' AND ID='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "SECH");

            dgvrent.DataSource = ds.Tables["SECH"];//อัพเดทหน้าจอ
        }

    }
}
