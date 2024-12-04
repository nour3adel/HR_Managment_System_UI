namespace HR_ManagmentSystem_Client.Logic.Attendance.DTOs
{
    public class UpdateAttendanceDTO
    {
        public string EmployeeID { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly ClockInTime { get; set; }
        public TimeOnly? ClockOutTime { get; set; }
        //public AttendanceStatus? Status { get; set; }
    }
}

