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
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class UserForm : Form
    {
        Person person = new Person();
        AppointmentBLL aBLL = new AppointmentBLL();
        AppointmentAttendanceBLL aaBLL = new AppointmentAttendanceBLL();
        PersonBLL PersonBLL = new PersonBLL();
        ReminderBLL rBLL = new ReminderBLL();   
        public UserForm(Person p)
        {
            InitializeComponent();
            person = p;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            HienThi(dtp_date.Value, person);
            ShowReminder();
            checkInvited();
        }
        public void checkInvited()
        {
            List<AppoimentAttendance> list = aaBLL.checkInvited(person);
            if(list != null)
            {
                foreach(var item in list)
                {
                    Appointment app = aBLL.getByID(item.Appointment_ID);
                    DialogResult kq = MessageBox.Show("Bạn có muốn tham gia cuộc họp " + app.Title, "Lời mời tham gia cuộc họp!", MessageBoxButtons.YesNo); ;
                    if(kq == DialogResult.Yes)
                    {
                        aaBLL.AcceptInvite(item.Appointment_ID, person);
                    }
                    else  aaBLL.RejectInvite(item.Appointment_ID, person);
                }
            }
        }
        public void HienThi(DateTime d, Person p)
        {
            List<Appointment> list = aBLL.ListAppointment(d, p);
            listApp.Items.Clear();
            foreach(var item in list)
            {
                ListViewItem lvi = new ListViewItem(item.Appointment_ID.ToString());
                lvi.SubItems.Add(item.Title);
                listApp.Items.Add(lvi);
            }
        }
        
        public void ShowReminder()
        {
            listReminder.Items.Clear();
            foreach(var item in rBLL.ListReminder(person))
            {
                ListViewItem lvi = new ListViewItem(item.ReminderID.ToString());
                lvi.SubItems.Add(aBLL.getByID(item.AppointmentID).Title);
                lvi.SubItems.Add(item.ReminderTime);
                listReminder.Items.Add(lvi);
            }
        }

        public void ShowAttendance(int ID)
        {
            cbb_attendance.DataSource = PersonBLL.ListAttendance(ID);
            cbb_attendance.DisplayMember = "Person_Name";
            cbb_attendance.ValueMember = "Person_ID";
            List<AppoimentAttendance> list = aaBLL.getListByID(ID);
            listAtt.Items.Clear();
            foreach(var item in list)
            {
                ListViewItem lvi = new ListViewItem(item.Attendance_ID.ToString());
                lvi.SubItems.Add(PersonBLL.getByID(item.Attendance_ID).Person_Name);
                lvi.SubItems.Add(item.AttendanceStatus);
                listAtt.Items.Add(lvi);
            }
        }

        private void listApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listApp.SelectedItems.Count == 0) return;
            ListViewItem lvi = listApp.SelectedItems[0];
            txt_title.Text = lvi.SubItems[1].Text;
            Appointment temp = aBLL.getByID(int.Parse(lvi.SubItems[0].Text));
            txt_des.Text = temp.AppointmentDescription;
            txt_loc.Text = temp.AppointmentLocation;
            dtp_appDate.Value = temp.AppointmentDate;
            dtp_endtime.Value = temp.AppointmentDate + temp.EndTime;
            dtp_starttime.Value = temp.AppointmentDate + temp.StartTime;
            ShowAttendance(int.Parse(lvi.SubItems[0].Text));
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            if (panel_taikhoan.Visible == false) panel_taikhoan.Visible = true;
            else panel_taikhoan.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            HienThi(dtp_date.Value, person);
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RemoveAtt_Click(object sender, EventArgs e)
        {
            if(listAtt.SelectedItems.Count == 0) {
                MessageBox.Show("Vui long chon nguoi muon xoa!");
                return;
            }
            DialogResult kq = MessageBox.Show("Ban co muon xoa nguoi nay khoi cuoc hop?", "Xoa khach moi", MessageBoxButtons.YesNoCancel);
            if (kq == DialogResult.Yes) {
                aaBLL.RemoveAtt(int.Parse(listAtt.SelectedItems[0].SubItems[0].Text));
                ShowAttendance(int.Parse(listApp.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void btn_AddAtt_Click(object sender, EventArgs e)
        {
            Person p = (Person)cbb_attendance.SelectedItem;
            if (p != null)
            {
                DialogResult kq = MessageBox.Show("Ban co muon them nguoi nay vao cuoc hop?", "Moi nguoi tham du", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    if(aaBLL.AddAtt(p, int.Parse(listApp.SelectedItems[0].SubItems[0].Text)) == false){
                        MessageBox.Show("Them that bai!");
                    }
                    else
                    {
                        ShowAttendance(int.Parse(listApp.SelectedItems[0].SubItems[0].Text));
                    }
                }
            }
        }

        private void btn_removeRemider_Click(object sender, EventArgs e)
        {
            if(listReminder.SelectedItems.Count > 0) {
                DialogResult kq = MessageBox.Show("Ban co muon xoa loi nhac ve cuoc hop nay?", "Xoa loi nhac", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    rBLL.RemoveReminder(int.Parse(listReminder.SelectedItems[0].SubItems[0].Text));
                    ShowReminder();
                }
            }
        }

        private void btn_addReminder_Click(object sender, EventArgs e)
        {
            string rTime = cbb_reminderTime.SelectedItem.ToString();
            int aID = int.Parse(listApp.SelectedItems[0].SubItems[0].Text);
            rBLL.AddReminder(person, aID, rTime);
            ShowReminder();
        }
    }
}
