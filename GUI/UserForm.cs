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
using BAL;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class UserForm : Form
    {
        AppointmentBLL aBLL = new AppointmentBLL();
        AppoinmentAttendanceBLL aaBLL = new AppoinmentAttendanceBLL();
        PersonBLL PersonBLL = new PersonBLL();
        public UserForm()
        {
            InitializeComponent();
        }
        public void HienThi(DateTime d)
        {
            List<Appointment> list = aBLL.ListAppointment(d);
            listApp.Items.Clear();
            foreach(var item in list)
            {
                ListViewItem lvi = new ListViewItem(item.Appointment_ID.ToString());
                lvi.SubItems.Add(item.Title);
                listApp.Items.Add(lvi);
            }
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            HienThi(dtp_date.Value);
        }

        public void ShowAttendance(int ID)
        {
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
    }
}
