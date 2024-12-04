namespace HR_ManagmentSystem_Client.Logic.LeaveRequest.DTOs
{
    public class GetLeaveRequestDTO
    {
        public int id { get; set; }
        public string EmployeeName { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string? Description { get; set; }

        public string? Status { get; set; }
    }
}
