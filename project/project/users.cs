using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        public static string cn = "Data Source=.; initial Catalog=book; Trusted_Connection=True";

        private void users_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "U");
            dgvusers.DataSource = ds.Tables["U"];
        }

        private void dgvusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                dgvusers.Rows[e.RowIndex].Selected = true;
                DataRow dr = ds.Tables["U"].Rows[e.RowIndex];
                id.Text = dr["ID"].ToString();
                username.Text = dr["Username"].ToString();
                password.Text = dr["Password"].ToString();
                fname.Text = dr["Fname"].ToString();
                lname.Text = dr["Lname"].ToString();
                address.Text = dr["Address"].ToString();
                tel.Text = dr["Tel"].ToString();
                gender.Text = dr["gender"].ToString();
                role.Text = dr["Role"].ToString();
            }
        }

        private void createusersbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["U"].Select("ID='" + id.Text + "'");
            if (dr.Length == 0)
            {
                DataRow drd = ds.Tables["B"].NewRow();
                drd["ID"] = id.Text;
                drd["Username"] = username.Text;
                drd["Password"] = password.Text;
                drd["Fname"] = fname.Text;
                drd["Lname"] = lname.Text;
                drd["Address"] = address.Text;
                drd["Tel"] = tel.Text;
                drd["gender"] = gender.Text;
                drd["Role"] = role.Text;
                ds.Tables["U"].Rows.Add(drd);

            }
            else
            {
                MessageBox.Show("เลข ID ซ้ำ", "ERROR");
            }
            dgvusers.DataSource = ds.Tables["U"];
        }

        private void editbookbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["U"].Select("ID='" + id.Text + "'");
            if (dr.Length == 0)//ไม่มีข้อมูล id ตัวนั้น
            {
                MessageBox.Show("ไม่พบข้อมูลที่จะลบ", "ERROR");
            }
            else
            {
                dr[0]["Username"] = username.Text;
                dr[0]["Password"] = password.Text;
                dr[0]["Fname"] = fname.Text;
                dr[0]["Lname"] = lname.Text;
                dr[0]["Address"] = address.Text;
                dr[0]["Tel"] = tel.Text;
                dr[0]["gender"] = gender.Text;
                dr[0]["Role"] = gender.Text;
                dgvusers.DataSource = ds.Tables["B"];//อัพเดทหน้าจอ
            }
        }

        private void deletebookbtn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds.Tables["U"].Select("ID='" + id.Text + "'");
            if (dr.Length == 0)//ไม่มีข้อมูล id ตัวนั้น
            {
                MessageBox.Show("ไม่พบข้อมูลที่จะลบ", "ERROR");
            }
            else
            {
                dr[0].Delete();

                //บันทึกข้อมูล
                string sql = "SELECT * FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "U");
                ds.Tables["U"].AcceptChanges();

                dgvusers.DataSource = ds.Tables["U"];//อัพเดทหน้าจอ

            }
        }

        private void savebookbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "U");
        }

        private void newbookbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TOP 1 * FROM Users ORDER BY ID DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            int topid = Convert.ToInt32(dt.Rows[0]["ID"]) + 1;
            id.Text = topid.ToString();
            username.Text = " ";
            password.Text = " ";
            fname.Text = " ";
            lname.Text = " ";
            address.Text = " ";
            tel.Text = " ";
            gender.Text = " ";
            role.Text = " ";
        }

        private void seachbtn_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SECH"))
                ds.Tables.Remove("SECH");
            string sql = "SELECT * FROM Users WHERE Username LIKE '%" + txtSearch.Text + "%' OR Fname LIKE '%" + txtSearch.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "SECH");

            dgvusers.DataSource = ds.Tables["SECH"];//อัพเดทหน้าจอ
        }
    }
}
