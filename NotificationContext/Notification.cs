namespace Balta.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            this.property = property;
            Message = message;
        }

        public string property { get; set; }
        public string Message { get; set; }
    }
}
