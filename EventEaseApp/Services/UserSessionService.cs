namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        private List<string> registeredEvents = new List<string>();

        public void RegisterEvent(string eventName)
        {
            if (!registeredEvents.Contains(eventName))
            {
                registeredEvents.Add(eventName);
            }
        }

        public List<string> GetRegisteredEvents()
        {
            return registeredEvents;
        }
    }
}
