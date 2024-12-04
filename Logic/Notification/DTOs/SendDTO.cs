
namespace HR_ManagmentSystem_Client.Logic.Notification.DTOs
{
    public class SendDTO
    {

        public string subject { get; set; }
        public string EmployeeId { get; set; }

        public string? MessageContent { get; set; }

        public DateTime Date { get; set; }

        public NotificationType Type { get; set; }

        public bool isUrgent { get; set; }

    }
}
