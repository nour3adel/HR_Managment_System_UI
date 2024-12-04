namespace HR_ManagmentSystem_Client.Logic.Employee.DTOs
{
    public class ChangePasswordDTO
    {

        public string employeeid { get; set; }


        public string oldpassword { get; set; }

        public string newpassword { get; set; }
        public string confirm_password { get; set; }
    }
}
