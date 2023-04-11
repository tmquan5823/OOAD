using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PersonBLL
    {
        PersonDAL pDAL = new PersonDAL();
        public string CheckUserInfo(Person p)
        {
            if (p.UserName == "")
            {
                return "Vui lòng nhập tên đăng nhập!";
            }
            else if (p.UserPassword == "")
            {
                return "Vui lòng nhập mật khẩu!";
            }
            else
            {
                if (pDAL.CheckUserInfo(p)) return "Đăng nhập thành công!";
                else return "Tên đăng nhập hoặc mật khẩu không hợp lệ!";
            }
        }
        public List<Person> ListAttendance(int id)
        {
            return pDAL.ListAttendance(id);
        }
        public Person getByID(int ID)
        {
            return pDAL.getById(ID);
        }
        public Person getByUserName(string userName)
        {
            return pDAL.getByUserName(userName);
        }
    }
}
