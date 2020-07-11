namespace PusherClient
{
    public interface IRequiresJsonSerializer
    {
        IJsonSerializer JsonSerializer { get; }
    }
}
