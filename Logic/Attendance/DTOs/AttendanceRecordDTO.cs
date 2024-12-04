namespace HR_ManagmentSystem_Client.Logic.Attendance.DTOs
{
    public class AttendanceRecordDTO
    {
        public string EmployeeName { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly ClockInTime { get; set; }
        public TimeOnly? ClockOutTime { get; set; }
        public string? Status { get; set; }
    }
}
