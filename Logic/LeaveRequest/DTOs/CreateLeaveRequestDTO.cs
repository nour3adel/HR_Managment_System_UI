namespace HR_ManagmentSystem_Client.Logic.LeaveRequest.DTOs
{
    public class CreateLeaveRequestDTO
    {
        public string employeeId { get; set; }
        public DateOnly startDate { get; set; }
        public DateOnly endDate { get; set; }
        public string? description { get; set; }
    }
}
