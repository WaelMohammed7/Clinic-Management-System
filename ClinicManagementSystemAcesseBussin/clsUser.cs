using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClinicManagementSystemDataAccess;

namespace ClinicManagementSystemAcesseBussin
{
    public class clsUser
    {
        enum enMode { Add, Update }

        enMode Mode = enMode.Add;

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public byte Role { get; set; }
        public byte IsActive { get; set; }

        public clsUser()
        {
            this.UserId = -1;
            this.Username = "";
            this.Password = "";
            //this.Role = 0;
            this.IsActive = 0;
            Mode = enMode.Add;
        }

        public clsUser(int UserId, string Username, string Password/*, byte Role*/, byte IsActive)
        {
            this.UserId = UserId;
            this.Username = Username;
            this.Password = Password;
            //this.Role = Role;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        public static DataTable GetAllUserManagement()
        {
            return clsUserData.GetAllUserManagement();
        }

        public static clsUser FindUserByUserNameAndPassword(string UserName, string Password)
        {
            int UserId = 0;
            byte /*Role = 0,*/ IsActive = 0;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(UserName, Password, ref UserId/*, ref Role*/, ref IsActive);

            if (IsFound)
            {
                return new clsUser(UserId, UserName, Password,/* Role,*/ IsActive);
            }
            else
            {
                return null;
            }

        }

       
    }
}
