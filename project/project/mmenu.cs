using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class mmenu : Form
    {
        public mmenu()
        {
            InitializeComponent();
        }
        public static string loginstat = "";
        public static string role = "";

        private void mmenu_Load(object sender, EventArgs e)
        {
            login f = new login();
            f.ShowDialog();
            //ถ้าไม่กด login โปรแกรมจะปิด
            if (loginstat == "")
            {
                Application.Exit();
            }
            else
            {
                main h = new main();
                h.MdiParent = this;
                h.WindowState = FormWindowState.Maximized;
                h.Show();
                if (role == "admin")
                {
                    mainbtn.Show();
                    bookbtn.Show();
                    userbtn.Show();
                    adminrentbtn.Show();
                    rentbtn.Hide();
                }
                else
                {
                    mainbtn.Hide();
                    bookbtn.Hide();
                    userbtn.Hide();
                    adminrentbtn.Hide();
                    rentbtn.Show();
 

                }

            }
        }

        private void CloseForm(Form frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name != frm.Name) //ชื่อไม่ตรงกับform ที่กำลังเปิด
                {
                    f.Close();
                }
                else
                    return;//เปิดอยู่แล้วไม่เกิดอะไรขึ้น

            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            main f = new main();
            CloseForm(f);
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            book f = new book();
            CloseForm(f);
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            users f = new users();
            CloseForm(f);
        }

        private void adminrentbtn_Click(object sender, EventArgs e)
        {
            adminrent f = new adminrent();
            CloseForm(f);
        }

        private void rentbtn_Click(object sender, EventArgs e)
        {
            rent f = new rent();
            CloseForm(f);
        }




    }
}
