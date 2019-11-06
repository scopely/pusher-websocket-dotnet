namespace PusherClient.Messages
{
    [Preserve]
    public class AuthMessage
    {
        [Preserve]
        public string auth { get; set; }
        [Preserve]
        public string channel_data { get; set; }
    }
}
