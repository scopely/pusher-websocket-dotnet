namespace PusherClient.Messages
{
    [Preserve]
    public class ErrorMessage
    {
        [Preserve]
        public string message { get; set; }
        [Preserve]
        public int? code { get; set; }
    }
}
