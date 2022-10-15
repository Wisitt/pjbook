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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string cn = "Data Source=.; initial Catalog=book; Trusted_Connection=True";
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM Users WHERE Username = '{0}' AND Password = '{1}'", usernametbox.Text, passwordtbox.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string name = dt.Rows[0]["Username"].ToString();
                MessageBox.Show("ยินดีต้อนรับคุณ " + name);
                string role = dt.Rows[0]["Role"].ToString();
                string id = dt.Rows[0]["ID"].ToString();
                rent.id = id;
                mmenu.role = role;
                mmenu.loginstat = "1";
                main.name = name;
                this.Close();
            }
            else
                MessageBox.Show("Username หรือ Password ไม่ถูกต้อง", "Error");
        }

    }
}
