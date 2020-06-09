using System;
using System.Threading.Tasks;

namespace DictionaryOfTypes.Clients
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class ChatRoomClientAttribute : Attribute
    {
    }

    public class ChatRoom0Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom0Client
    {
        Task SendAsync(ChatRoom0Message message);
    }

    [ChatRoomClient]
    public class ChatRoom0Client: IChatRoom0Client
    {
        private Guid _sender;

        public ChatRoom0Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom0Message message) => Task.CompletedTask;
    }

    public class ChatRoom1Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom1Client
    {
        Task SendAsync(ChatRoom1Message message);
    }

    [ChatRoomClient]
    public class ChatRoom1Client: IChatRoom1Client
    {
        private Guid _sender;

        public ChatRoom1Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom1Message message) => Task.CompletedTask;
    }

    public class ChatRoom2Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom2Client
    {
        Task SendAsync(ChatRoom2Message message);
    }

    [ChatRoomClient]
    public class ChatRoom2Client: IChatRoom2Client
    {
        private Guid _sender;

        public ChatRoom2Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom2Message message) => Task.CompletedTask;
    }

    public class ChatRoom3Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom3Client
    {
        Task SendAsync(ChatRoom3Message message);
    }

    [ChatRoomClient]
    public class ChatRoom3Client: IChatRoom3Client
    {
        private Guid _sender;

        public ChatRoom3Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom3Message message) => Task.CompletedTask;
    }

    public class ChatRoom4Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom4Client
    {
        Task SendAsync(ChatRoom4Message message);
    }

    [ChatRoomClient]
    public class ChatRoom4Client: IChatRoom4Client
    {
        private Guid _sender;

        public ChatRoom4Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom4Message message) => Task.CompletedTask;
    }

    public class ChatRoom5Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom5Client
    {
        Task SendAsync(ChatRoom5Message message);
    }

    [ChatRoomClient]
    public class ChatRoom5Client: IChatRoom5Client
    {
        private Guid _sender;

        public ChatRoom5Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom5Message message) => Task.CompletedTask;
    }

    public class ChatRoom6Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom6Client
    {
        Task SendAsync(ChatRoom6Message message);
    }

    [ChatRoomClient]
    public class ChatRoom6Client: IChatRoom6Client
    {
        private Guid _sender;

        public ChatRoom6Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom6Message message) => Task.CompletedTask;
    }

    public class ChatRoom7Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom7Client
    {
        Task SendAsync(ChatRoom7Message message);
    }

    [ChatRoomClient]
    public class ChatRoom7Client: IChatRoom7Client
    {
        private Guid _sender;

        public ChatRoom7Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom7Message message) => Task.CompletedTask;
    }

    public class ChatRoom8Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom8Client
    {
        Task SendAsync(ChatRoom8Message message);
    }

    [ChatRoomClient]
    public class ChatRoom8Client: IChatRoom8Client
    {
        private Guid _sender;

        public ChatRoom8Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom8Message message) => Task.CompletedTask;
    }

    public class ChatRoom9Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom9Client
    {
        Task SendAsync(ChatRoom9Message message);
    }

    [ChatRoomClient]
    public class ChatRoom9Client: IChatRoom9Client
    {
        private Guid _sender;

        public ChatRoom9Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom9Message message) => Task.CompletedTask;
    }

    public class ChatRoom10Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom10Client
    {
        Task SendAsync(ChatRoom10Message message);
    }

    [ChatRoomClient]
    public class ChatRoom10Client: IChatRoom10Client
    {
        private Guid _sender;

        public ChatRoom10Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom10Message message) => Task.CompletedTask;
    }

    public class ChatRoom11Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom11Client
    {
        Task SendAsync(ChatRoom11Message message);
    }

    [ChatRoomClient]
    public class ChatRoom11Client: IChatRoom11Client
    {
        private Guid _sender;

        public ChatRoom11Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom11Message message) => Task.CompletedTask;
    }

    public class ChatRoom12Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom12Client
    {
        Task SendAsync(ChatRoom12Message message);
    }

    [ChatRoomClient]
    public class ChatRoom12Client: IChatRoom12Client
    {
        private Guid _sender;

        public ChatRoom12Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom12Message message) => Task.CompletedTask;
    }

    public class ChatRoom13Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom13Client
    {
        Task SendAsync(ChatRoom13Message message);
    }

    [ChatRoomClient]
    public class ChatRoom13Client: IChatRoom13Client
    {
        private Guid _sender;

        public ChatRoom13Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom13Message message) => Task.CompletedTask;
    }

    public class ChatRoom14Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom14Client
    {
        Task SendAsync(ChatRoom14Message message);
    }

    [ChatRoomClient]
    public class ChatRoom14Client: IChatRoom14Client
    {
        private Guid _sender;

        public ChatRoom14Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom14Message message) => Task.CompletedTask;
    }

    public class ChatRoom15Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom15Client
    {
        Task SendAsync(ChatRoom15Message message);
    }

    [ChatRoomClient]
    public class ChatRoom15Client: IChatRoom15Client
    {
        private Guid _sender;

        public ChatRoom15Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom15Message message) => Task.CompletedTask;
    }

    public class ChatRoom16Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom16Client
    {
        Task SendAsync(ChatRoom16Message message);
    }

    [ChatRoomClient]
    public class ChatRoom16Client: IChatRoom16Client
    {
        private Guid _sender;

        public ChatRoom16Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom16Message message) => Task.CompletedTask;
    }

    public class ChatRoom17Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom17Client
    {
        Task SendAsync(ChatRoom17Message message);
    }

    [ChatRoomClient]
    public class ChatRoom17Client: IChatRoom17Client
    {
        private Guid _sender;

        public ChatRoom17Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom17Message message) => Task.CompletedTask;
    }

    public class ChatRoom18Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom18Client
    {
        Task SendAsync(ChatRoom18Message message);
    }

    [ChatRoomClient]
    public class ChatRoom18Client: IChatRoom18Client
    {
        private Guid _sender;

        public ChatRoom18Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom18Message message) => Task.CompletedTask;
    }

    public class ChatRoom19Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom19Client
    {
        Task SendAsync(ChatRoom19Message message);
    }

    [ChatRoomClient]
    public class ChatRoom19Client: IChatRoom19Client
    {
        private Guid _sender;

        public ChatRoom19Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom19Message message) => Task.CompletedTask;
    }

}
