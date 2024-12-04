namespace HR_ManagmentSystem_Client.Logic.Common
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public object Meta { get; set; }
        public bool Succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public T data { get; set; }
    }

}
