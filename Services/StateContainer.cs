using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEase.Services
{
    public class UserState
    {
        public bool IsAuthenticated { get; set; }
        public string? UserId { get; set; }
        public string? Username { get; set; }
        public List<int> RegisteredEvents { get; set; } = new();
    }

    public class StateContainer
    {
        private UserState _userState = new();

        public UserState UserState
        {
            get => _userState;
            private set
            {
                _userState = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        public void SetUserState(UserState value)
        {
            UserState = value;
        }

        public void ClearUserState()
        {
            UserState = new UserState();
        }

        public void AddRegisteredEvent(int eventId)
        {
            if (!UserState.RegisteredEvents.Contains(eventId))
            {
                UserState.RegisteredEvents.Add(eventId);
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}