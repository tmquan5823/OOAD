using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FormDN : Form
    {
        Person p = new Person();
        PersonBLL pBLL = new PersonBLL();
        public FormDN()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            p.UserName = txt_tenDN.Text;
            p.UserPassword = txt_mk.Text;
            string check = pBLL.CheckUserInfo(p);
            if(check == "Đăng nhập thành công!")
            {
                p = pBLL.getByUserName(p.UserName);
                MessageBox.Show(check);
                UserForm frm = new UserForm(p);
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(check);
            }
        }

        private void FormDN_Load(object sender, EventArgs e)
        {

        }
    }
}
