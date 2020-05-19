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

    public class ChatRoom20Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom20Client
    {
        Task SendAsync(ChatRoom20Message message);
    }

    [ChatRoomClient]
    public class ChatRoom20Client: IChatRoom20Client
    {
        private Guid _sender;

        public ChatRoom20Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom20Message message) => Task.CompletedTask;
    }

    public class ChatRoom21Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom21Client
    {
        Task SendAsync(ChatRoom21Message message);
    }

    [ChatRoomClient]
    public class ChatRoom21Client: IChatRoom21Client
    {
        private Guid _sender;

        public ChatRoom21Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom21Message message) => Task.CompletedTask;
    }

    public class ChatRoom22Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom22Client
    {
        Task SendAsync(ChatRoom22Message message);
    }

    [ChatRoomClient]
    public class ChatRoom22Client: IChatRoom22Client
    {
        private Guid _sender;

        public ChatRoom22Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom22Message message) => Task.CompletedTask;
    }

    public class ChatRoom23Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom23Client
    {
        Task SendAsync(ChatRoom23Message message);
    }

    [ChatRoomClient]
    public class ChatRoom23Client: IChatRoom23Client
    {
        private Guid _sender;

        public ChatRoom23Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom23Message message) => Task.CompletedTask;
    }

    public class ChatRoom24Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom24Client
    {
        Task SendAsync(ChatRoom24Message message);
    }

    [ChatRoomClient]
    public class ChatRoom24Client: IChatRoom24Client
    {
        private Guid _sender;

        public ChatRoom24Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom24Message message) => Task.CompletedTask;
    }

    public class ChatRoom25Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom25Client
    {
        Task SendAsync(ChatRoom25Message message);
    }

    [ChatRoomClient]
    public class ChatRoom25Client: IChatRoom25Client
    {
        private Guid _sender;

        public ChatRoom25Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom25Message message) => Task.CompletedTask;
    }

    public class ChatRoom26Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom26Client
    {
        Task SendAsync(ChatRoom26Message message);
    }

    [ChatRoomClient]
    public class ChatRoom26Client: IChatRoom26Client
    {
        private Guid _sender;

        public ChatRoom26Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom26Message message) => Task.CompletedTask;
    }

    public class ChatRoom27Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom27Client
    {
        Task SendAsync(ChatRoom27Message message);
    }

    [ChatRoomClient]
    public class ChatRoom27Client: IChatRoom27Client
    {
        private Guid _sender;

        public ChatRoom27Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom27Message message) => Task.CompletedTask;
    }

    public class ChatRoom28Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom28Client
    {
        Task SendAsync(ChatRoom28Message message);
    }

    [ChatRoomClient]
    public class ChatRoom28Client: IChatRoom28Client
    {
        private Guid _sender;

        public ChatRoom28Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom28Message message) => Task.CompletedTask;
    }

    public class ChatRoom29Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom29Client
    {
        Task SendAsync(ChatRoom29Message message);
    }

    [ChatRoomClient]
    public class ChatRoom29Client: IChatRoom29Client
    {
        private Guid _sender;

        public ChatRoom29Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom29Message message) => Task.CompletedTask;
    }

    public class ChatRoom30Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom30Client
    {
        Task SendAsync(ChatRoom30Message message);
    }

    [ChatRoomClient]
    public class ChatRoom30Client: IChatRoom30Client
    {
        private Guid _sender;

        public ChatRoom30Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom30Message message) => Task.CompletedTask;
    }

    public class ChatRoom31Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom31Client
    {
        Task SendAsync(ChatRoom31Message message);
    }

    [ChatRoomClient]
    public class ChatRoom31Client: IChatRoom31Client
    {
        private Guid _sender;

        public ChatRoom31Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom31Message message) => Task.CompletedTask;
    }

    public class ChatRoom32Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom32Client
    {
        Task SendAsync(ChatRoom32Message message);
    }

    [ChatRoomClient]
    public class ChatRoom32Client: IChatRoom32Client
    {
        private Guid _sender;

        public ChatRoom32Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom32Message message) => Task.CompletedTask;
    }

    public class ChatRoom33Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom33Client
    {
        Task SendAsync(ChatRoom33Message message);
    }

    [ChatRoomClient]
    public class ChatRoom33Client: IChatRoom33Client
    {
        private Guid _sender;

        public ChatRoom33Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom33Message message) => Task.CompletedTask;
    }

    public class ChatRoom34Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom34Client
    {
        Task SendAsync(ChatRoom34Message message);
    }

    [ChatRoomClient]
    public class ChatRoom34Client: IChatRoom34Client
    {
        private Guid _sender;

        public ChatRoom34Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom34Message message) => Task.CompletedTask;
    }

    public class ChatRoom35Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom35Client
    {
        Task SendAsync(ChatRoom35Message message);
    }

    [ChatRoomClient]
    public class ChatRoom35Client: IChatRoom35Client
    {
        private Guid _sender;

        public ChatRoom35Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom35Message message) => Task.CompletedTask;
    }

    public class ChatRoom36Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom36Client
    {
        Task SendAsync(ChatRoom36Message message);
    }

    [ChatRoomClient]
    public class ChatRoom36Client: IChatRoom36Client
    {
        private Guid _sender;

        public ChatRoom36Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom36Message message) => Task.CompletedTask;
    }

    public class ChatRoom37Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom37Client
    {
        Task SendAsync(ChatRoom37Message message);
    }

    [ChatRoomClient]
    public class ChatRoom37Client: IChatRoom37Client
    {
        private Guid _sender;

        public ChatRoom37Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom37Message message) => Task.CompletedTask;
    }

    public class ChatRoom38Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom38Client
    {
        Task SendAsync(ChatRoom38Message message);
    }

    [ChatRoomClient]
    public class ChatRoom38Client: IChatRoom38Client
    {
        private Guid _sender;

        public ChatRoom38Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom38Message message) => Task.CompletedTask;
    }

    public class ChatRoom39Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom39Client
    {
        Task SendAsync(ChatRoom39Message message);
    }

    [ChatRoomClient]
    public class ChatRoom39Client: IChatRoom39Client
    {
        private Guid _sender;

        public ChatRoom39Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom39Message message) => Task.CompletedTask;
    }

    public class ChatRoom40Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom40Client
    {
        Task SendAsync(ChatRoom40Message message);
    }

    [ChatRoomClient]
    public class ChatRoom40Client: IChatRoom40Client
    {
        private Guid _sender;

        public ChatRoom40Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom40Message message) => Task.CompletedTask;
    }

    public class ChatRoom41Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom41Client
    {
        Task SendAsync(ChatRoom41Message message);
    }

    [ChatRoomClient]
    public class ChatRoom41Client: IChatRoom41Client
    {
        private Guid _sender;

        public ChatRoom41Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom41Message message) => Task.CompletedTask;
    }

    public class ChatRoom42Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom42Client
    {
        Task SendAsync(ChatRoom42Message message);
    }

    [ChatRoomClient]
    public class ChatRoom42Client: IChatRoom42Client
    {
        private Guid _sender;

        public ChatRoom42Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom42Message message) => Task.CompletedTask;
    }

    public class ChatRoom43Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom43Client
    {
        Task SendAsync(ChatRoom43Message message);
    }

    [ChatRoomClient]
    public class ChatRoom43Client: IChatRoom43Client
    {
        private Guid _sender;

        public ChatRoom43Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom43Message message) => Task.CompletedTask;
    }

    public class ChatRoom44Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom44Client
    {
        Task SendAsync(ChatRoom44Message message);
    }

    [ChatRoomClient]
    public class ChatRoom44Client: IChatRoom44Client
    {
        private Guid _sender;

        public ChatRoom44Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom44Message message) => Task.CompletedTask;
    }

    public class ChatRoom45Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom45Client
    {
        Task SendAsync(ChatRoom45Message message);
    }

    [ChatRoomClient]
    public class ChatRoom45Client: IChatRoom45Client
    {
        private Guid _sender;

        public ChatRoom45Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom45Message message) => Task.CompletedTask;
    }

    public class ChatRoom46Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom46Client
    {
        Task SendAsync(ChatRoom46Message message);
    }

    [ChatRoomClient]
    public class ChatRoom46Client: IChatRoom46Client
    {
        private Guid _sender;

        public ChatRoom46Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom46Message message) => Task.CompletedTask;
    }

    public class ChatRoom47Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom47Client
    {
        Task SendAsync(ChatRoom47Message message);
    }

    [ChatRoomClient]
    public class ChatRoom47Client: IChatRoom47Client
    {
        private Guid _sender;

        public ChatRoom47Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom47Message message) => Task.CompletedTask;
    }

    public class ChatRoom48Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom48Client
    {
        Task SendAsync(ChatRoom48Message message);
    }

    [ChatRoomClient]
    public class ChatRoom48Client: IChatRoom48Client
    {
        private Guid _sender;

        public ChatRoom48Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom48Message message) => Task.CompletedTask;
    }

    public class ChatRoom49Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom49Client
    {
        Task SendAsync(ChatRoom49Message message);
    }

    [ChatRoomClient]
    public class ChatRoom49Client: IChatRoom49Client
    {
        private Guid _sender;

        public ChatRoom49Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom49Message message) => Task.CompletedTask;
    }

    public class ChatRoom50Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom50Client
    {
        Task SendAsync(ChatRoom50Message message);
    }

    [ChatRoomClient]
    public class ChatRoom50Client: IChatRoom50Client
    {
        private Guid _sender;

        public ChatRoom50Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom50Message message) => Task.CompletedTask;
    }

    public class ChatRoom51Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom51Client
    {
        Task SendAsync(ChatRoom51Message message);
    }

    [ChatRoomClient]
    public class ChatRoom51Client: IChatRoom51Client
    {
        private Guid _sender;

        public ChatRoom51Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom51Message message) => Task.CompletedTask;
    }

    public class ChatRoom52Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom52Client
    {
        Task SendAsync(ChatRoom52Message message);
    }

    [ChatRoomClient]
    public class ChatRoom52Client: IChatRoom52Client
    {
        private Guid _sender;

        public ChatRoom52Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom52Message message) => Task.CompletedTask;
    }

    public class ChatRoom53Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom53Client
    {
        Task SendAsync(ChatRoom53Message message);
    }

    [ChatRoomClient]
    public class ChatRoom53Client: IChatRoom53Client
    {
        private Guid _sender;

        public ChatRoom53Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom53Message message) => Task.CompletedTask;
    }

    public class ChatRoom54Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom54Client
    {
        Task SendAsync(ChatRoom54Message message);
    }

    [ChatRoomClient]
    public class ChatRoom54Client: IChatRoom54Client
    {
        private Guid _sender;

        public ChatRoom54Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom54Message message) => Task.CompletedTask;
    }

    public class ChatRoom55Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom55Client
    {
        Task SendAsync(ChatRoom55Message message);
    }

    [ChatRoomClient]
    public class ChatRoom55Client: IChatRoom55Client
    {
        private Guid _sender;

        public ChatRoom55Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom55Message message) => Task.CompletedTask;
    }

    public class ChatRoom56Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom56Client
    {
        Task SendAsync(ChatRoom56Message message);
    }

    [ChatRoomClient]
    public class ChatRoom56Client: IChatRoom56Client
    {
        private Guid _sender;

        public ChatRoom56Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom56Message message) => Task.CompletedTask;
    }

    public class ChatRoom57Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom57Client
    {
        Task SendAsync(ChatRoom57Message message);
    }

    [ChatRoomClient]
    public class ChatRoom57Client: IChatRoom57Client
    {
        private Guid _sender;

        public ChatRoom57Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom57Message message) => Task.CompletedTask;
    }

    public class ChatRoom58Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom58Client
    {
        Task SendAsync(ChatRoom58Message message);
    }

    [ChatRoomClient]
    public class ChatRoom58Client: IChatRoom58Client
    {
        private Guid _sender;

        public ChatRoom58Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom58Message message) => Task.CompletedTask;
    }

    public class ChatRoom59Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom59Client
    {
        Task SendAsync(ChatRoom59Message message);
    }

    [ChatRoomClient]
    public class ChatRoom59Client: IChatRoom59Client
    {
        private Guid _sender;

        public ChatRoom59Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom59Message message) => Task.CompletedTask;
    }

    public class ChatRoom60Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom60Client
    {
        Task SendAsync(ChatRoom60Message message);
    }

    [ChatRoomClient]
    public class ChatRoom60Client: IChatRoom60Client
    {
        private Guid _sender;

        public ChatRoom60Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom60Message message) => Task.CompletedTask;
    }

    public class ChatRoom61Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom61Client
    {
        Task SendAsync(ChatRoom61Message message);
    }

    [ChatRoomClient]
    public class ChatRoom61Client: IChatRoom61Client
    {
        private Guid _sender;

        public ChatRoom61Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom61Message message) => Task.CompletedTask;
    }

    public class ChatRoom62Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom62Client
    {
        Task SendAsync(ChatRoom62Message message);
    }

    [ChatRoomClient]
    public class ChatRoom62Client: IChatRoom62Client
    {
        private Guid _sender;

        public ChatRoom62Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom62Message message) => Task.CompletedTask;
    }

    public class ChatRoom63Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom63Client
    {
        Task SendAsync(ChatRoom63Message message);
    }

    [ChatRoomClient]
    public class ChatRoom63Client: IChatRoom63Client
    {
        private Guid _sender;

        public ChatRoom63Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom63Message message) => Task.CompletedTask;
    }

    public class ChatRoom64Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom64Client
    {
        Task SendAsync(ChatRoom64Message message);
    }

    [ChatRoomClient]
    public class ChatRoom64Client: IChatRoom64Client
    {
        private Guid _sender;

        public ChatRoom64Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom64Message message) => Task.CompletedTask;
    }

    public class ChatRoom65Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom65Client
    {
        Task SendAsync(ChatRoom65Message message);
    }

    [ChatRoomClient]
    public class ChatRoom65Client: IChatRoom65Client
    {
        private Guid _sender;

        public ChatRoom65Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom65Message message) => Task.CompletedTask;
    }

    public class ChatRoom66Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom66Client
    {
        Task SendAsync(ChatRoom66Message message);
    }

    [ChatRoomClient]
    public class ChatRoom66Client: IChatRoom66Client
    {
        private Guid _sender;

        public ChatRoom66Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom66Message message) => Task.CompletedTask;
    }

    public class ChatRoom67Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom67Client
    {
        Task SendAsync(ChatRoom67Message message);
    }

    [ChatRoomClient]
    public class ChatRoom67Client: IChatRoom67Client
    {
        private Guid _sender;

        public ChatRoom67Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom67Message message) => Task.CompletedTask;
    }

    public class ChatRoom68Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom68Client
    {
        Task SendAsync(ChatRoom68Message message);
    }

    [ChatRoomClient]
    public class ChatRoom68Client: IChatRoom68Client
    {
        private Guid _sender;

        public ChatRoom68Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom68Message message) => Task.CompletedTask;
    }

    public class ChatRoom69Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom69Client
    {
        Task SendAsync(ChatRoom69Message message);
    }

    [ChatRoomClient]
    public class ChatRoom69Client: IChatRoom69Client
    {
        private Guid _sender;

        public ChatRoom69Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom69Message message) => Task.CompletedTask;
    }

    public class ChatRoom70Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom70Client
    {
        Task SendAsync(ChatRoom70Message message);
    }

    [ChatRoomClient]
    public class ChatRoom70Client: IChatRoom70Client
    {
        private Guid _sender;

        public ChatRoom70Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom70Message message) => Task.CompletedTask;
    }

    public class ChatRoom71Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom71Client
    {
        Task SendAsync(ChatRoom71Message message);
    }

    [ChatRoomClient]
    public class ChatRoom71Client: IChatRoom71Client
    {
        private Guid _sender;

        public ChatRoom71Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom71Message message) => Task.CompletedTask;
    }

    public class ChatRoom72Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom72Client
    {
        Task SendAsync(ChatRoom72Message message);
    }

    [ChatRoomClient]
    public class ChatRoom72Client: IChatRoom72Client
    {
        private Guid _sender;

        public ChatRoom72Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom72Message message) => Task.CompletedTask;
    }

    public class ChatRoom73Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom73Client
    {
        Task SendAsync(ChatRoom73Message message);
    }

    [ChatRoomClient]
    public class ChatRoom73Client: IChatRoom73Client
    {
        private Guid _sender;

        public ChatRoom73Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom73Message message) => Task.CompletedTask;
    }

    public class ChatRoom74Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom74Client
    {
        Task SendAsync(ChatRoom74Message message);
    }

    [ChatRoomClient]
    public class ChatRoom74Client: IChatRoom74Client
    {
        private Guid _sender;

        public ChatRoom74Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom74Message message) => Task.CompletedTask;
    }

    public class ChatRoom75Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom75Client
    {
        Task SendAsync(ChatRoom75Message message);
    }

    [ChatRoomClient]
    public class ChatRoom75Client: IChatRoom75Client
    {
        private Guid _sender;

        public ChatRoom75Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom75Message message) => Task.CompletedTask;
    }

    public class ChatRoom76Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom76Client
    {
        Task SendAsync(ChatRoom76Message message);
    }

    [ChatRoomClient]
    public class ChatRoom76Client: IChatRoom76Client
    {
        private Guid _sender;

        public ChatRoom76Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom76Message message) => Task.CompletedTask;
    }

    public class ChatRoom77Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom77Client
    {
        Task SendAsync(ChatRoom77Message message);
    }

    [ChatRoomClient]
    public class ChatRoom77Client: IChatRoom77Client
    {
        private Guid _sender;

        public ChatRoom77Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom77Message message) => Task.CompletedTask;
    }

    public class ChatRoom78Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom78Client
    {
        Task SendAsync(ChatRoom78Message message);
    }

    [ChatRoomClient]
    public class ChatRoom78Client: IChatRoom78Client
    {
        private Guid _sender;

        public ChatRoom78Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom78Message message) => Task.CompletedTask;
    }

    public class ChatRoom79Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom79Client
    {
        Task SendAsync(ChatRoom79Message message);
    }

    [ChatRoomClient]
    public class ChatRoom79Client: IChatRoom79Client
    {
        private Guid _sender;

        public ChatRoom79Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom79Message message) => Task.CompletedTask;
    }

    public class ChatRoom80Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom80Client
    {
        Task SendAsync(ChatRoom80Message message);
    }

    [ChatRoomClient]
    public class ChatRoom80Client: IChatRoom80Client
    {
        private Guid _sender;

        public ChatRoom80Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom80Message message) => Task.CompletedTask;
    }

    public class ChatRoom81Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom81Client
    {
        Task SendAsync(ChatRoom81Message message);
    }

    [ChatRoomClient]
    public class ChatRoom81Client: IChatRoom81Client
    {
        private Guid _sender;

        public ChatRoom81Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom81Message message) => Task.CompletedTask;
    }

    public class ChatRoom82Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom82Client
    {
        Task SendAsync(ChatRoom82Message message);
    }

    [ChatRoomClient]
    public class ChatRoom82Client: IChatRoom82Client
    {
        private Guid _sender;

        public ChatRoom82Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom82Message message) => Task.CompletedTask;
    }

    public class ChatRoom83Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom83Client
    {
        Task SendAsync(ChatRoom83Message message);
    }

    [ChatRoomClient]
    public class ChatRoom83Client: IChatRoom83Client
    {
        private Guid _sender;

        public ChatRoom83Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom83Message message) => Task.CompletedTask;
    }

    public class ChatRoom84Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom84Client
    {
        Task SendAsync(ChatRoom84Message message);
    }

    [ChatRoomClient]
    public class ChatRoom84Client: IChatRoom84Client
    {
        private Guid _sender;

        public ChatRoom84Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom84Message message) => Task.CompletedTask;
    }

    public class ChatRoom85Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom85Client
    {
        Task SendAsync(ChatRoom85Message message);
    }

    [ChatRoomClient]
    public class ChatRoom85Client: IChatRoom85Client
    {
        private Guid _sender;

        public ChatRoom85Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom85Message message) => Task.CompletedTask;
    }

    public class ChatRoom86Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom86Client
    {
        Task SendAsync(ChatRoom86Message message);
    }

    [ChatRoomClient]
    public class ChatRoom86Client: IChatRoom86Client
    {
        private Guid _sender;

        public ChatRoom86Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom86Message message) => Task.CompletedTask;
    }

    public class ChatRoom87Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom87Client
    {
        Task SendAsync(ChatRoom87Message message);
    }

    [ChatRoomClient]
    public class ChatRoom87Client: IChatRoom87Client
    {
        private Guid _sender;

        public ChatRoom87Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom87Message message) => Task.CompletedTask;
    }

    public class ChatRoom88Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom88Client
    {
        Task SendAsync(ChatRoom88Message message);
    }

    [ChatRoomClient]
    public class ChatRoom88Client: IChatRoom88Client
    {
        private Guid _sender;

        public ChatRoom88Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom88Message message) => Task.CompletedTask;
    }

    public class ChatRoom89Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom89Client
    {
        Task SendAsync(ChatRoom89Message message);
    }

    [ChatRoomClient]
    public class ChatRoom89Client: IChatRoom89Client
    {
        private Guid _sender;

        public ChatRoom89Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom89Message message) => Task.CompletedTask;
    }

    public class ChatRoom90Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom90Client
    {
        Task SendAsync(ChatRoom90Message message);
    }

    [ChatRoomClient]
    public class ChatRoom90Client: IChatRoom90Client
    {
        private Guid _sender;

        public ChatRoom90Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom90Message message) => Task.CompletedTask;
    }

    public class ChatRoom91Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom91Client
    {
        Task SendAsync(ChatRoom91Message message);
    }

    [ChatRoomClient]
    public class ChatRoom91Client: IChatRoom91Client
    {
        private Guid _sender;

        public ChatRoom91Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom91Message message) => Task.CompletedTask;
    }

    public class ChatRoom92Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom92Client
    {
        Task SendAsync(ChatRoom92Message message);
    }

    [ChatRoomClient]
    public class ChatRoom92Client: IChatRoom92Client
    {
        private Guid _sender;

        public ChatRoom92Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom92Message message) => Task.CompletedTask;
    }

    public class ChatRoom93Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom93Client
    {
        Task SendAsync(ChatRoom93Message message);
    }

    [ChatRoomClient]
    public class ChatRoom93Client: IChatRoom93Client
    {
        private Guid _sender;

        public ChatRoom93Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom93Message message) => Task.CompletedTask;
    }

    public class ChatRoom94Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom94Client
    {
        Task SendAsync(ChatRoom94Message message);
    }

    [ChatRoomClient]
    public class ChatRoom94Client: IChatRoom94Client
    {
        private Guid _sender;

        public ChatRoom94Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom94Message message) => Task.CompletedTask;
    }

    public class ChatRoom95Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom95Client
    {
        Task SendAsync(ChatRoom95Message message);
    }

    [ChatRoomClient]
    public class ChatRoom95Client: IChatRoom95Client
    {
        private Guid _sender;

        public ChatRoom95Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom95Message message) => Task.CompletedTask;
    }

    public class ChatRoom96Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom96Client
    {
        Task SendAsync(ChatRoom96Message message);
    }

    [ChatRoomClient]
    public class ChatRoom96Client: IChatRoom96Client
    {
        private Guid _sender;

        public ChatRoom96Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom96Message message) => Task.CompletedTask;
    }

    public class ChatRoom97Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom97Client
    {
        Task SendAsync(ChatRoom97Message message);
    }

    [ChatRoomClient]
    public class ChatRoom97Client: IChatRoom97Client
    {
        private Guid _sender;

        public ChatRoom97Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom97Message message) => Task.CompletedTask;
    }

    public class ChatRoom98Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom98Client
    {
        Task SendAsync(ChatRoom98Message message);
    }

    [ChatRoomClient]
    public class ChatRoom98Client: IChatRoom98Client
    {
        private Guid _sender;

        public ChatRoom98Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom98Message message) => Task.CompletedTask;
    }

    public class ChatRoom99Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom99Client
    {
        Task SendAsync(ChatRoom99Message message);
    }

    [ChatRoomClient]
    public class ChatRoom99Client: IChatRoom99Client
    {
        private Guid _sender;

        public ChatRoom99Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom99Message message) => Task.CompletedTask;
    }

    public class ChatRoom100Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom100Client
    {
        Task SendAsync(ChatRoom100Message message);
    }

    [ChatRoomClient]
    public class ChatRoom100Client: IChatRoom100Client
    {
        private Guid _sender;

        public ChatRoom100Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom100Message message) => Task.CompletedTask;
    }

    public class ChatRoom101Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom101Client
    {
        Task SendAsync(ChatRoom101Message message);
    }

    [ChatRoomClient]
    public class ChatRoom101Client: IChatRoom101Client
    {
        private Guid _sender;

        public ChatRoom101Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom101Message message) => Task.CompletedTask;
    }

    public class ChatRoom102Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom102Client
    {
        Task SendAsync(ChatRoom102Message message);
    }

    [ChatRoomClient]
    public class ChatRoom102Client: IChatRoom102Client
    {
        private Guid _sender;

        public ChatRoom102Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom102Message message) => Task.CompletedTask;
    }

    public class ChatRoom103Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom103Client
    {
        Task SendAsync(ChatRoom103Message message);
    }

    [ChatRoomClient]
    public class ChatRoom103Client: IChatRoom103Client
    {
        private Guid _sender;

        public ChatRoom103Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom103Message message) => Task.CompletedTask;
    }

    public class ChatRoom104Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom104Client
    {
        Task SendAsync(ChatRoom104Message message);
    }

    [ChatRoomClient]
    public class ChatRoom104Client: IChatRoom104Client
    {
        private Guid _sender;

        public ChatRoom104Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom104Message message) => Task.CompletedTask;
    }

    public class ChatRoom105Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom105Client
    {
        Task SendAsync(ChatRoom105Message message);
    }

    [ChatRoomClient]
    public class ChatRoom105Client: IChatRoom105Client
    {
        private Guid _sender;

        public ChatRoom105Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom105Message message) => Task.CompletedTask;
    }

    public class ChatRoom106Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom106Client
    {
        Task SendAsync(ChatRoom106Message message);
    }

    [ChatRoomClient]
    public class ChatRoom106Client: IChatRoom106Client
    {
        private Guid _sender;

        public ChatRoom106Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom106Message message) => Task.CompletedTask;
    }

    public class ChatRoom107Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom107Client
    {
        Task SendAsync(ChatRoom107Message message);
    }

    [ChatRoomClient]
    public class ChatRoom107Client: IChatRoom107Client
    {
        private Guid _sender;

        public ChatRoom107Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom107Message message) => Task.CompletedTask;
    }

    public class ChatRoom108Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom108Client
    {
        Task SendAsync(ChatRoom108Message message);
    }

    [ChatRoomClient]
    public class ChatRoom108Client: IChatRoom108Client
    {
        private Guid _sender;

        public ChatRoom108Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom108Message message) => Task.CompletedTask;
    }

    public class ChatRoom109Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom109Client
    {
        Task SendAsync(ChatRoom109Message message);
    }

    [ChatRoomClient]
    public class ChatRoom109Client: IChatRoom109Client
    {
        private Guid _sender;

        public ChatRoom109Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom109Message message) => Task.CompletedTask;
    }

    public class ChatRoom110Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom110Client
    {
        Task SendAsync(ChatRoom110Message message);
    }

    [ChatRoomClient]
    public class ChatRoom110Client: IChatRoom110Client
    {
        private Guid _sender;

        public ChatRoom110Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom110Message message) => Task.CompletedTask;
    }

    public class ChatRoom111Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom111Client
    {
        Task SendAsync(ChatRoom111Message message);
    }

    [ChatRoomClient]
    public class ChatRoom111Client: IChatRoom111Client
    {
        private Guid _sender;

        public ChatRoom111Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom111Message message) => Task.CompletedTask;
    }

    public class ChatRoom112Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom112Client
    {
        Task SendAsync(ChatRoom112Message message);
    }

    [ChatRoomClient]
    public class ChatRoom112Client: IChatRoom112Client
    {
        private Guid _sender;

        public ChatRoom112Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom112Message message) => Task.CompletedTask;
    }

    public class ChatRoom113Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom113Client
    {
        Task SendAsync(ChatRoom113Message message);
    }

    [ChatRoomClient]
    public class ChatRoom113Client: IChatRoom113Client
    {
        private Guid _sender;

        public ChatRoom113Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom113Message message) => Task.CompletedTask;
    }

    public class ChatRoom114Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom114Client
    {
        Task SendAsync(ChatRoom114Message message);
    }

    [ChatRoomClient]
    public class ChatRoom114Client: IChatRoom114Client
    {
        private Guid _sender;

        public ChatRoom114Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom114Message message) => Task.CompletedTask;
    }

    public class ChatRoom115Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom115Client
    {
        Task SendAsync(ChatRoom115Message message);
    }

    [ChatRoomClient]
    public class ChatRoom115Client: IChatRoom115Client
    {
        private Guid _sender;

        public ChatRoom115Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom115Message message) => Task.CompletedTask;
    }

    public class ChatRoom116Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom116Client
    {
        Task SendAsync(ChatRoom116Message message);
    }

    [ChatRoomClient]
    public class ChatRoom116Client: IChatRoom116Client
    {
        private Guid _sender;

        public ChatRoom116Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom116Message message) => Task.CompletedTask;
    }

    public class ChatRoom117Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom117Client
    {
        Task SendAsync(ChatRoom117Message message);
    }

    [ChatRoomClient]
    public class ChatRoom117Client: IChatRoom117Client
    {
        private Guid _sender;

        public ChatRoom117Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom117Message message) => Task.CompletedTask;
    }

    public class ChatRoom118Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom118Client
    {
        Task SendAsync(ChatRoom118Message message);
    }

    [ChatRoomClient]
    public class ChatRoom118Client: IChatRoom118Client
    {
        private Guid _sender;

        public ChatRoom118Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom118Message message) => Task.CompletedTask;
    }

    public class ChatRoom119Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom119Client
    {
        Task SendAsync(ChatRoom119Message message);
    }

    [ChatRoomClient]
    public class ChatRoom119Client: IChatRoom119Client
    {
        private Guid _sender;

        public ChatRoom119Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom119Message message) => Task.CompletedTask;
    }

    public class ChatRoom120Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom120Client
    {
        Task SendAsync(ChatRoom120Message message);
    }

    [ChatRoomClient]
    public class ChatRoom120Client: IChatRoom120Client
    {
        private Guid _sender;

        public ChatRoom120Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom120Message message) => Task.CompletedTask;
    }

    public class ChatRoom121Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom121Client
    {
        Task SendAsync(ChatRoom121Message message);
    }

    [ChatRoomClient]
    public class ChatRoom121Client: IChatRoom121Client
    {
        private Guid _sender;

        public ChatRoom121Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom121Message message) => Task.CompletedTask;
    }

    public class ChatRoom122Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom122Client
    {
        Task SendAsync(ChatRoom122Message message);
    }

    [ChatRoomClient]
    public class ChatRoom122Client: IChatRoom122Client
    {
        private Guid _sender;

        public ChatRoom122Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom122Message message) => Task.CompletedTask;
    }

    public class ChatRoom123Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom123Client
    {
        Task SendAsync(ChatRoom123Message message);
    }

    [ChatRoomClient]
    public class ChatRoom123Client: IChatRoom123Client
    {
        private Guid _sender;

        public ChatRoom123Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom123Message message) => Task.CompletedTask;
    }

    public class ChatRoom124Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom124Client
    {
        Task SendAsync(ChatRoom124Message message);
    }

    [ChatRoomClient]
    public class ChatRoom124Client: IChatRoom124Client
    {
        private Guid _sender;

        public ChatRoom124Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom124Message message) => Task.CompletedTask;
    }

    public class ChatRoom125Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom125Client
    {
        Task SendAsync(ChatRoom125Message message);
    }

    [ChatRoomClient]
    public class ChatRoom125Client: IChatRoom125Client
    {
        private Guid _sender;

        public ChatRoom125Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom125Message message) => Task.CompletedTask;
    }

    public class ChatRoom126Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom126Client
    {
        Task SendAsync(ChatRoom126Message message);
    }

    [ChatRoomClient]
    public class ChatRoom126Client: IChatRoom126Client
    {
        private Guid _sender;

        public ChatRoom126Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom126Message message) => Task.CompletedTask;
    }

    public class ChatRoom127Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom127Client
    {
        Task SendAsync(ChatRoom127Message message);
    }

    [ChatRoomClient]
    public class ChatRoom127Client: IChatRoom127Client
    {
        private Guid _sender;

        public ChatRoom127Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom127Message message) => Task.CompletedTask;
    }

    public class ChatRoom128Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom128Client
    {
        Task SendAsync(ChatRoom128Message message);
    }

    [ChatRoomClient]
    public class ChatRoom128Client: IChatRoom128Client
    {
        private Guid _sender;

        public ChatRoom128Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom128Message message) => Task.CompletedTask;
    }

    public class ChatRoom129Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom129Client
    {
        Task SendAsync(ChatRoom129Message message);
    }

    [ChatRoomClient]
    public class ChatRoom129Client: IChatRoom129Client
    {
        private Guid _sender;

        public ChatRoom129Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom129Message message) => Task.CompletedTask;
    }

    public class ChatRoom130Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom130Client
    {
        Task SendAsync(ChatRoom130Message message);
    }

    [ChatRoomClient]
    public class ChatRoom130Client: IChatRoom130Client
    {
        private Guid _sender;

        public ChatRoom130Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom130Message message) => Task.CompletedTask;
    }

    public class ChatRoom131Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom131Client
    {
        Task SendAsync(ChatRoom131Message message);
    }

    [ChatRoomClient]
    public class ChatRoom131Client: IChatRoom131Client
    {
        private Guid _sender;

        public ChatRoom131Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom131Message message) => Task.CompletedTask;
    }

    public class ChatRoom132Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom132Client
    {
        Task SendAsync(ChatRoom132Message message);
    }

    [ChatRoomClient]
    public class ChatRoom132Client: IChatRoom132Client
    {
        private Guid _sender;

        public ChatRoom132Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom132Message message) => Task.CompletedTask;
    }

    public class ChatRoom133Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom133Client
    {
        Task SendAsync(ChatRoom133Message message);
    }

    [ChatRoomClient]
    public class ChatRoom133Client: IChatRoom133Client
    {
        private Guid _sender;

        public ChatRoom133Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom133Message message) => Task.CompletedTask;
    }

    public class ChatRoom134Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom134Client
    {
        Task SendAsync(ChatRoom134Message message);
    }

    [ChatRoomClient]
    public class ChatRoom134Client: IChatRoom134Client
    {
        private Guid _sender;

        public ChatRoom134Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom134Message message) => Task.CompletedTask;
    }

    public class ChatRoom135Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom135Client
    {
        Task SendAsync(ChatRoom135Message message);
    }

    [ChatRoomClient]
    public class ChatRoom135Client: IChatRoom135Client
    {
        private Guid _sender;

        public ChatRoom135Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom135Message message) => Task.CompletedTask;
    }

    public class ChatRoom136Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom136Client
    {
        Task SendAsync(ChatRoom136Message message);
    }

    [ChatRoomClient]
    public class ChatRoom136Client: IChatRoom136Client
    {
        private Guid _sender;

        public ChatRoom136Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom136Message message) => Task.CompletedTask;
    }

    public class ChatRoom137Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom137Client
    {
        Task SendAsync(ChatRoom137Message message);
    }

    [ChatRoomClient]
    public class ChatRoom137Client: IChatRoom137Client
    {
        private Guid _sender;

        public ChatRoom137Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom137Message message) => Task.CompletedTask;
    }

    public class ChatRoom138Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom138Client
    {
        Task SendAsync(ChatRoom138Message message);
    }

    [ChatRoomClient]
    public class ChatRoom138Client: IChatRoom138Client
    {
        private Guid _sender;

        public ChatRoom138Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom138Message message) => Task.CompletedTask;
    }

    public class ChatRoom139Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom139Client
    {
        Task SendAsync(ChatRoom139Message message);
    }

    [ChatRoomClient]
    public class ChatRoom139Client: IChatRoom139Client
    {
        private Guid _sender;

        public ChatRoom139Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom139Message message) => Task.CompletedTask;
    }

    public class ChatRoom140Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom140Client
    {
        Task SendAsync(ChatRoom140Message message);
    }

    [ChatRoomClient]
    public class ChatRoom140Client: IChatRoom140Client
    {
        private Guid _sender;

        public ChatRoom140Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom140Message message) => Task.CompletedTask;
    }

    public class ChatRoom141Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom141Client
    {
        Task SendAsync(ChatRoom141Message message);
    }

    [ChatRoomClient]
    public class ChatRoom141Client: IChatRoom141Client
    {
        private Guid _sender;

        public ChatRoom141Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom141Message message) => Task.CompletedTask;
    }

    public class ChatRoom142Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom142Client
    {
        Task SendAsync(ChatRoom142Message message);
    }

    [ChatRoomClient]
    public class ChatRoom142Client: IChatRoom142Client
    {
        private Guid _sender;

        public ChatRoom142Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom142Message message) => Task.CompletedTask;
    }

    public class ChatRoom143Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom143Client
    {
        Task SendAsync(ChatRoom143Message message);
    }

    [ChatRoomClient]
    public class ChatRoom143Client: IChatRoom143Client
    {
        private Guid _sender;

        public ChatRoom143Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom143Message message) => Task.CompletedTask;
    }

    public class ChatRoom144Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom144Client
    {
        Task SendAsync(ChatRoom144Message message);
    }

    [ChatRoomClient]
    public class ChatRoom144Client: IChatRoom144Client
    {
        private Guid _sender;

        public ChatRoom144Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom144Message message) => Task.CompletedTask;
    }

    public class ChatRoom145Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom145Client
    {
        Task SendAsync(ChatRoom145Message message);
    }

    [ChatRoomClient]
    public class ChatRoom145Client: IChatRoom145Client
    {
        private Guid _sender;

        public ChatRoom145Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom145Message message) => Task.CompletedTask;
    }

    public class ChatRoom146Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom146Client
    {
        Task SendAsync(ChatRoom146Message message);
    }

    [ChatRoomClient]
    public class ChatRoom146Client: IChatRoom146Client
    {
        private Guid _sender;

        public ChatRoom146Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom146Message message) => Task.CompletedTask;
    }

    public class ChatRoom147Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom147Client
    {
        Task SendAsync(ChatRoom147Message message);
    }

    [ChatRoomClient]
    public class ChatRoom147Client: IChatRoom147Client
    {
        private Guid _sender;

        public ChatRoom147Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom147Message message) => Task.CompletedTask;
    }

    public class ChatRoom148Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom148Client
    {
        Task SendAsync(ChatRoom148Message message);
    }

    [ChatRoomClient]
    public class ChatRoom148Client: IChatRoom148Client
    {
        private Guid _sender;

        public ChatRoom148Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom148Message message) => Task.CompletedTask;
    }

    public class ChatRoom149Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom149Client
    {
        Task SendAsync(ChatRoom149Message message);
    }

    [ChatRoomClient]
    public class ChatRoom149Client: IChatRoom149Client
    {
        private Guid _sender;

        public ChatRoom149Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom149Message message) => Task.CompletedTask;
    }

    public class ChatRoom150Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom150Client
    {
        Task SendAsync(ChatRoom150Message message);
    }

    [ChatRoomClient]
    public class ChatRoom150Client: IChatRoom150Client
    {
        private Guid _sender;

        public ChatRoom150Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom150Message message) => Task.CompletedTask;
    }

    public class ChatRoom151Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom151Client
    {
        Task SendAsync(ChatRoom151Message message);
    }

    [ChatRoomClient]
    public class ChatRoom151Client: IChatRoom151Client
    {
        private Guid _sender;

        public ChatRoom151Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom151Message message) => Task.CompletedTask;
    }

    public class ChatRoom152Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom152Client
    {
        Task SendAsync(ChatRoom152Message message);
    }

    [ChatRoomClient]
    public class ChatRoom152Client: IChatRoom152Client
    {
        private Guid _sender;

        public ChatRoom152Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom152Message message) => Task.CompletedTask;
    }

    public class ChatRoom153Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom153Client
    {
        Task SendAsync(ChatRoom153Message message);
    }

    [ChatRoomClient]
    public class ChatRoom153Client: IChatRoom153Client
    {
        private Guid _sender;

        public ChatRoom153Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom153Message message) => Task.CompletedTask;
    }

    public class ChatRoom154Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom154Client
    {
        Task SendAsync(ChatRoom154Message message);
    }

    [ChatRoomClient]
    public class ChatRoom154Client: IChatRoom154Client
    {
        private Guid _sender;

        public ChatRoom154Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom154Message message) => Task.CompletedTask;
    }

    public class ChatRoom155Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom155Client
    {
        Task SendAsync(ChatRoom155Message message);
    }

    [ChatRoomClient]
    public class ChatRoom155Client: IChatRoom155Client
    {
        private Guid _sender;

        public ChatRoom155Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom155Message message) => Task.CompletedTask;
    }

    public class ChatRoom156Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom156Client
    {
        Task SendAsync(ChatRoom156Message message);
    }

    [ChatRoomClient]
    public class ChatRoom156Client: IChatRoom156Client
    {
        private Guid _sender;

        public ChatRoom156Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom156Message message) => Task.CompletedTask;
    }

    public class ChatRoom157Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom157Client
    {
        Task SendAsync(ChatRoom157Message message);
    }

    [ChatRoomClient]
    public class ChatRoom157Client: IChatRoom157Client
    {
        private Guid _sender;

        public ChatRoom157Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom157Message message) => Task.CompletedTask;
    }

    public class ChatRoom158Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom158Client
    {
        Task SendAsync(ChatRoom158Message message);
    }

    [ChatRoomClient]
    public class ChatRoom158Client: IChatRoom158Client
    {
        private Guid _sender;

        public ChatRoom158Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom158Message message) => Task.CompletedTask;
    }

    public class ChatRoom159Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom159Client
    {
        Task SendAsync(ChatRoom159Message message);
    }

    [ChatRoomClient]
    public class ChatRoom159Client: IChatRoom159Client
    {
        private Guid _sender;

        public ChatRoom159Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom159Message message) => Task.CompletedTask;
    }

    public class ChatRoom160Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom160Client
    {
        Task SendAsync(ChatRoom160Message message);
    }

    [ChatRoomClient]
    public class ChatRoom160Client: IChatRoom160Client
    {
        private Guid _sender;

        public ChatRoom160Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom160Message message) => Task.CompletedTask;
    }

    public class ChatRoom161Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom161Client
    {
        Task SendAsync(ChatRoom161Message message);
    }

    [ChatRoomClient]
    public class ChatRoom161Client: IChatRoom161Client
    {
        private Guid _sender;

        public ChatRoom161Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom161Message message) => Task.CompletedTask;
    }

    public class ChatRoom162Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom162Client
    {
        Task SendAsync(ChatRoom162Message message);
    }

    [ChatRoomClient]
    public class ChatRoom162Client: IChatRoom162Client
    {
        private Guid _sender;

        public ChatRoom162Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom162Message message) => Task.CompletedTask;
    }

    public class ChatRoom163Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom163Client
    {
        Task SendAsync(ChatRoom163Message message);
    }

    [ChatRoomClient]
    public class ChatRoom163Client: IChatRoom163Client
    {
        private Guid _sender;

        public ChatRoom163Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom163Message message) => Task.CompletedTask;
    }

    public class ChatRoom164Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom164Client
    {
        Task SendAsync(ChatRoom164Message message);
    }

    [ChatRoomClient]
    public class ChatRoom164Client: IChatRoom164Client
    {
        private Guid _sender;

        public ChatRoom164Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom164Message message) => Task.CompletedTask;
    }

    public class ChatRoom165Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom165Client
    {
        Task SendAsync(ChatRoom165Message message);
    }

    [ChatRoomClient]
    public class ChatRoom165Client: IChatRoom165Client
    {
        private Guid _sender;

        public ChatRoom165Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom165Message message) => Task.CompletedTask;
    }

    public class ChatRoom166Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom166Client
    {
        Task SendAsync(ChatRoom166Message message);
    }

    [ChatRoomClient]
    public class ChatRoom166Client: IChatRoom166Client
    {
        private Guid _sender;

        public ChatRoom166Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom166Message message) => Task.CompletedTask;
    }

    public class ChatRoom167Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom167Client
    {
        Task SendAsync(ChatRoom167Message message);
    }

    [ChatRoomClient]
    public class ChatRoom167Client: IChatRoom167Client
    {
        private Guid _sender;

        public ChatRoom167Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom167Message message) => Task.CompletedTask;
    }

    public class ChatRoom168Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom168Client
    {
        Task SendAsync(ChatRoom168Message message);
    }

    [ChatRoomClient]
    public class ChatRoom168Client: IChatRoom168Client
    {
        private Guid _sender;

        public ChatRoom168Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom168Message message) => Task.CompletedTask;
    }

    public class ChatRoom169Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom169Client
    {
        Task SendAsync(ChatRoom169Message message);
    }

    [ChatRoomClient]
    public class ChatRoom169Client: IChatRoom169Client
    {
        private Guid _sender;

        public ChatRoom169Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom169Message message) => Task.CompletedTask;
    }

    public class ChatRoom170Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom170Client
    {
        Task SendAsync(ChatRoom170Message message);
    }

    [ChatRoomClient]
    public class ChatRoom170Client: IChatRoom170Client
    {
        private Guid _sender;

        public ChatRoom170Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom170Message message) => Task.CompletedTask;
    }

    public class ChatRoom171Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom171Client
    {
        Task SendAsync(ChatRoom171Message message);
    }

    [ChatRoomClient]
    public class ChatRoom171Client: IChatRoom171Client
    {
        private Guid _sender;

        public ChatRoom171Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom171Message message) => Task.CompletedTask;
    }

    public class ChatRoom172Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom172Client
    {
        Task SendAsync(ChatRoom172Message message);
    }

    [ChatRoomClient]
    public class ChatRoom172Client: IChatRoom172Client
    {
        private Guid _sender;

        public ChatRoom172Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom172Message message) => Task.CompletedTask;
    }

    public class ChatRoom173Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom173Client
    {
        Task SendAsync(ChatRoom173Message message);
    }

    [ChatRoomClient]
    public class ChatRoom173Client: IChatRoom173Client
    {
        private Guid _sender;

        public ChatRoom173Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom173Message message) => Task.CompletedTask;
    }

    public class ChatRoom174Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom174Client
    {
        Task SendAsync(ChatRoom174Message message);
    }

    [ChatRoomClient]
    public class ChatRoom174Client: IChatRoom174Client
    {
        private Guid _sender;

        public ChatRoom174Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom174Message message) => Task.CompletedTask;
    }

    public class ChatRoom175Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom175Client
    {
        Task SendAsync(ChatRoom175Message message);
    }

    [ChatRoomClient]
    public class ChatRoom175Client: IChatRoom175Client
    {
        private Guid _sender;

        public ChatRoom175Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom175Message message) => Task.CompletedTask;
    }

    public class ChatRoom176Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom176Client
    {
        Task SendAsync(ChatRoom176Message message);
    }

    [ChatRoomClient]
    public class ChatRoom176Client: IChatRoom176Client
    {
        private Guid _sender;

        public ChatRoom176Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom176Message message) => Task.CompletedTask;
    }

    public class ChatRoom177Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom177Client
    {
        Task SendAsync(ChatRoom177Message message);
    }

    [ChatRoomClient]
    public class ChatRoom177Client: IChatRoom177Client
    {
        private Guid _sender;

        public ChatRoom177Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom177Message message) => Task.CompletedTask;
    }

    public class ChatRoom178Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom178Client
    {
        Task SendAsync(ChatRoom178Message message);
    }

    [ChatRoomClient]
    public class ChatRoom178Client: IChatRoom178Client
    {
        private Guid _sender;

        public ChatRoom178Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom178Message message) => Task.CompletedTask;
    }

    public class ChatRoom179Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom179Client
    {
        Task SendAsync(ChatRoom179Message message);
    }

    [ChatRoomClient]
    public class ChatRoom179Client: IChatRoom179Client
    {
        private Guid _sender;

        public ChatRoom179Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom179Message message) => Task.CompletedTask;
    }

    public class ChatRoom180Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom180Client
    {
        Task SendAsync(ChatRoom180Message message);
    }

    [ChatRoomClient]
    public class ChatRoom180Client: IChatRoom180Client
    {
        private Guid _sender;

        public ChatRoom180Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom180Message message) => Task.CompletedTask;
    }

    public class ChatRoom181Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom181Client
    {
        Task SendAsync(ChatRoom181Message message);
    }

    [ChatRoomClient]
    public class ChatRoom181Client: IChatRoom181Client
    {
        private Guid _sender;

        public ChatRoom181Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom181Message message) => Task.CompletedTask;
    }

    public class ChatRoom182Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom182Client
    {
        Task SendAsync(ChatRoom182Message message);
    }

    [ChatRoomClient]
    public class ChatRoom182Client: IChatRoom182Client
    {
        private Guid _sender;

        public ChatRoom182Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom182Message message) => Task.CompletedTask;
    }

    public class ChatRoom183Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom183Client
    {
        Task SendAsync(ChatRoom183Message message);
    }

    [ChatRoomClient]
    public class ChatRoom183Client: IChatRoom183Client
    {
        private Guid _sender;

        public ChatRoom183Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom183Message message) => Task.CompletedTask;
    }

    public class ChatRoom184Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom184Client
    {
        Task SendAsync(ChatRoom184Message message);
    }

    [ChatRoomClient]
    public class ChatRoom184Client: IChatRoom184Client
    {
        private Guid _sender;

        public ChatRoom184Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom184Message message) => Task.CompletedTask;
    }

    public class ChatRoom185Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom185Client
    {
        Task SendAsync(ChatRoom185Message message);
    }

    [ChatRoomClient]
    public class ChatRoom185Client: IChatRoom185Client
    {
        private Guid _sender;

        public ChatRoom185Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom185Message message) => Task.CompletedTask;
    }

    public class ChatRoom186Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom186Client
    {
        Task SendAsync(ChatRoom186Message message);
    }

    [ChatRoomClient]
    public class ChatRoom186Client: IChatRoom186Client
    {
        private Guid _sender;

        public ChatRoom186Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom186Message message) => Task.CompletedTask;
    }

    public class ChatRoom187Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom187Client
    {
        Task SendAsync(ChatRoom187Message message);
    }

    [ChatRoomClient]
    public class ChatRoom187Client: IChatRoom187Client
    {
        private Guid _sender;

        public ChatRoom187Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom187Message message) => Task.CompletedTask;
    }

    public class ChatRoom188Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom188Client
    {
        Task SendAsync(ChatRoom188Message message);
    }

    [ChatRoomClient]
    public class ChatRoom188Client: IChatRoom188Client
    {
        private Guid _sender;

        public ChatRoom188Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom188Message message) => Task.CompletedTask;
    }

    public class ChatRoom189Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom189Client
    {
        Task SendAsync(ChatRoom189Message message);
    }

    [ChatRoomClient]
    public class ChatRoom189Client: IChatRoom189Client
    {
        private Guid _sender;

        public ChatRoom189Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom189Message message) => Task.CompletedTask;
    }

    public class ChatRoom190Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom190Client
    {
        Task SendAsync(ChatRoom190Message message);
    }

    [ChatRoomClient]
    public class ChatRoom190Client: IChatRoom190Client
    {
        private Guid _sender;

        public ChatRoom190Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom190Message message) => Task.CompletedTask;
    }

    public class ChatRoom191Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom191Client
    {
        Task SendAsync(ChatRoom191Message message);
    }

    [ChatRoomClient]
    public class ChatRoom191Client: IChatRoom191Client
    {
        private Guid _sender;

        public ChatRoom191Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom191Message message) => Task.CompletedTask;
    }

    public class ChatRoom192Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom192Client
    {
        Task SendAsync(ChatRoom192Message message);
    }

    [ChatRoomClient]
    public class ChatRoom192Client: IChatRoom192Client
    {
        private Guid _sender;

        public ChatRoom192Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom192Message message) => Task.CompletedTask;
    }

    public class ChatRoom193Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom193Client
    {
        Task SendAsync(ChatRoom193Message message);
    }

    [ChatRoomClient]
    public class ChatRoom193Client: IChatRoom193Client
    {
        private Guid _sender;

        public ChatRoom193Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom193Message message) => Task.CompletedTask;
    }

    public class ChatRoom194Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom194Client
    {
        Task SendAsync(ChatRoom194Message message);
    }

    [ChatRoomClient]
    public class ChatRoom194Client: IChatRoom194Client
    {
        private Guid _sender;

        public ChatRoom194Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom194Message message) => Task.CompletedTask;
    }

    public class ChatRoom195Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom195Client
    {
        Task SendAsync(ChatRoom195Message message);
    }

    [ChatRoomClient]
    public class ChatRoom195Client: IChatRoom195Client
    {
        private Guid _sender;

        public ChatRoom195Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom195Message message) => Task.CompletedTask;
    }

    public class ChatRoom196Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom196Client
    {
        Task SendAsync(ChatRoom196Message message);
    }

    [ChatRoomClient]
    public class ChatRoom196Client: IChatRoom196Client
    {
        private Guid _sender;

        public ChatRoom196Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom196Message message) => Task.CompletedTask;
    }

    public class ChatRoom197Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom197Client
    {
        Task SendAsync(ChatRoom197Message message);
    }

    [ChatRoomClient]
    public class ChatRoom197Client: IChatRoom197Client
    {
        private Guid _sender;

        public ChatRoom197Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom197Message message) => Task.CompletedTask;
    }

    public class ChatRoom198Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom198Client
    {
        Task SendAsync(ChatRoom198Message message);
    }

    [ChatRoomClient]
    public class ChatRoom198Client: IChatRoom198Client
    {
        private Guid _sender;

        public ChatRoom198Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom198Message message) => Task.CompletedTask;
    }

    public class ChatRoom199Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom199Client
    {
        Task SendAsync(ChatRoom199Message message);
    }

    [ChatRoomClient]
    public class ChatRoom199Client: IChatRoom199Client
    {
        private Guid _sender;

        public ChatRoom199Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom199Message message) => Task.CompletedTask;
    }

    public class ChatRoom200Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom200Client
    {
        Task SendAsync(ChatRoom200Message message);
    }

    [ChatRoomClient]
    public class ChatRoom200Client: IChatRoom200Client
    {
        private Guid _sender;

        public ChatRoom200Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom200Message message) => Task.CompletedTask;
    }

    public class ChatRoom201Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom201Client
    {
        Task SendAsync(ChatRoom201Message message);
    }

    [ChatRoomClient]
    public class ChatRoom201Client: IChatRoom201Client
    {
        private Guid _sender;

        public ChatRoom201Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom201Message message) => Task.CompletedTask;
    }

    public class ChatRoom202Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom202Client
    {
        Task SendAsync(ChatRoom202Message message);
    }

    [ChatRoomClient]
    public class ChatRoom202Client: IChatRoom202Client
    {
        private Guid _sender;

        public ChatRoom202Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom202Message message) => Task.CompletedTask;
    }

    public class ChatRoom203Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom203Client
    {
        Task SendAsync(ChatRoom203Message message);
    }

    [ChatRoomClient]
    public class ChatRoom203Client: IChatRoom203Client
    {
        private Guid _sender;

        public ChatRoom203Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom203Message message) => Task.CompletedTask;
    }

    public class ChatRoom204Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom204Client
    {
        Task SendAsync(ChatRoom204Message message);
    }

    [ChatRoomClient]
    public class ChatRoom204Client: IChatRoom204Client
    {
        private Guid _sender;

        public ChatRoom204Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom204Message message) => Task.CompletedTask;
    }

    public class ChatRoom205Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom205Client
    {
        Task SendAsync(ChatRoom205Message message);
    }

    [ChatRoomClient]
    public class ChatRoom205Client: IChatRoom205Client
    {
        private Guid _sender;

        public ChatRoom205Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom205Message message) => Task.CompletedTask;
    }

    public class ChatRoom206Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom206Client
    {
        Task SendAsync(ChatRoom206Message message);
    }

    [ChatRoomClient]
    public class ChatRoom206Client: IChatRoom206Client
    {
        private Guid _sender;

        public ChatRoom206Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom206Message message) => Task.CompletedTask;
    }

    public class ChatRoom207Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom207Client
    {
        Task SendAsync(ChatRoom207Message message);
    }

    [ChatRoomClient]
    public class ChatRoom207Client: IChatRoom207Client
    {
        private Guid _sender;

        public ChatRoom207Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom207Message message) => Task.CompletedTask;
    }

    public class ChatRoom208Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom208Client
    {
        Task SendAsync(ChatRoom208Message message);
    }

    [ChatRoomClient]
    public class ChatRoom208Client: IChatRoom208Client
    {
        private Guid _sender;

        public ChatRoom208Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom208Message message) => Task.CompletedTask;
    }

    public class ChatRoom209Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom209Client
    {
        Task SendAsync(ChatRoom209Message message);
    }

    [ChatRoomClient]
    public class ChatRoom209Client: IChatRoom209Client
    {
        private Guid _sender;

        public ChatRoom209Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom209Message message) => Task.CompletedTask;
    }

    public class ChatRoom210Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom210Client
    {
        Task SendAsync(ChatRoom210Message message);
    }

    [ChatRoomClient]
    public class ChatRoom210Client: IChatRoom210Client
    {
        private Guid _sender;

        public ChatRoom210Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom210Message message) => Task.CompletedTask;
    }

    public class ChatRoom211Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom211Client
    {
        Task SendAsync(ChatRoom211Message message);
    }

    [ChatRoomClient]
    public class ChatRoom211Client: IChatRoom211Client
    {
        private Guid _sender;

        public ChatRoom211Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom211Message message) => Task.CompletedTask;
    }

    public class ChatRoom212Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom212Client
    {
        Task SendAsync(ChatRoom212Message message);
    }

    [ChatRoomClient]
    public class ChatRoom212Client: IChatRoom212Client
    {
        private Guid _sender;

        public ChatRoom212Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom212Message message) => Task.CompletedTask;
    }

    public class ChatRoom213Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom213Client
    {
        Task SendAsync(ChatRoom213Message message);
    }

    [ChatRoomClient]
    public class ChatRoom213Client: IChatRoom213Client
    {
        private Guid _sender;

        public ChatRoom213Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom213Message message) => Task.CompletedTask;
    }

    public class ChatRoom214Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom214Client
    {
        Task SendAsync(ChatRoom214Message message);
    }

    [ChatRoomClient]
    public class ChatRoom214Client: IChatRoom214Client
    {
        private Guid _sender;

        public ChatRoom214Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom214Message message) => Task.CompletedTask;
    }

    public class ChatRoom215Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom215Client
    {
        Task SendAsync(ChatRoom215Message message);
    }

    [ChatRoomClient]
    public class ChatRoom215Client: IChatRoom215Client
    {
        private Guid _sender;

        public ChatRoom215Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom215Message message) => Task.CompletedTask;
    }

    public class ChatRoom216Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom216Client
    {
        Task SendAsync(ChatRoom216Message message);
    }

    [ChatRoomClient]
    public class ChatRoom216Client: IChatRoom216Client
    {
        private Guid _sender;

        public ChatRoom216Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom216Message message) => Task.CompletedTask;
    }

    public class ChatRoom217Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom217Client
    {
        Task SendAsync(ChatRoom217Message message);
    }

    [ChatRoomClient]
    public class ChatRoom217Client: IChatRoom217Client
    {
        private Guid _sender;

        public ChatRoom217Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom217Message message) => Task.CompletedTask;
    }

    public class ChatRoom218Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom218Client
    {
        Task SendAsync(ChatRoom218Message message);
    }

    [ChatRoomClient]
    public class ChatRoom218Client: IChatRoom218Client
    {
        private Guid _sender;

        public ChatRoom218Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom218Message message) => Task.CompletedTask;
    }

    public class ChatRoom219Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom219Client
    {
        Task SendAsync(ChatRoom219Message message);
    }

    [ChatRoomClient]
    public class ChatRoom219Client: IChatRoom219Client
    {
        private Guid _sender;

        public ChatRoom219Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom219Message message) => Task.CompletedTask;
    }

    public class ChatRoom220Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom220Client
    {
        Task SendAsync(ChatRoom220Message message);
    }

    [ChatRoomClient]
    public class ChatRoom220Client: IChatRoom220Client
    {
        private Guid _sender;

        public ChatRoom220Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom220Message message) => Task.CompletedTask;
    }

    public class ChatRoom221Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom221Client
    {
        Task SendAsync(ChatRoom221Message message);
    }

    [ChatRoomClient]
    public class ChatRoom221Client: IChatRoom221Client
    {
        private Guid _sender;

        public ChatRoom221Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom221Message message) => Task.CompletedTask;
    }

    public class ChatRoom222Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom222Client
    {
        Task SendAsync(ChatRoom222Message message);
    }

    [ChatRoomClient]
    public class ChatRoom222Client: IChatRoom222Client
    {
        private Guid _sender;

        public ChatRoom222Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom222Message message) => Task.CompletedTask;
    }

    public class ChatRoom223Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom223Client
    {
        Task SendAsync(ChatRoom223Message message);
    }

    [ChatRoomClient]
    public class ChatRoom223Client: IChatRoom223Client
    {
        private Guid _sender;

        public ChatRoom223Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom223Message message) => Task.CompletedTask;
    }

    public class ChatRoom224Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom224Client
    {
        Task SendAsync(ChatRoom224Message message);
    }

    [ChatRoomClient]
    public class ChatRoom224Client: IChatRoom224Client
    {
        private Guid _sender;

        public ChatRoom224Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom224Message message) => Task.CompletedTask;
    }

    public class ChatRoom225Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom225Client
    {
        Task SendAsync(ChatRoom225Message message);
    }

    [ChatRoomClient]
    public class ChatRoom225Client: IChatRoom225Client
    {
        private Guid _sender;

        public ChatRoom225Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom225Message message) => Task.CompletedTask;
    }

    public class ChatRoom226Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom226Client
    {
        Task SendAsync(ChatRoom226Message message);
    }

    [ChatRoomClient]
    public class ChatRoom226Client: IChatRoom226Client
    {
        private Guid _sender;

        public ChatRoom226Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom226Message message) => Task.CompletedTask;
    }

    public class ChatRoom227Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom227Client
    {
        Task SendAsync(ChatRoom227Message message);
    }

    [ChatRoomClient]
    public class ChatRoom227Client: IChatRoom227Client
    {
        private Guid _sender;

        public ChatRoom227Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom227Message message) => Task.CompletedTask;
    }

    public class ChatRoom228Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom228Client
    {
        Task SendAsync(ChatRoom228Message message);
    }

    [ChatRoomClient]
    public class ChatRoom228Client: IChatRoom228Client
    {
        private Guid _sender;

        public ChatRoom228Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom228Message message) => Task.CompletedTask;
    }

    public class ChatRoom229Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom229Client
    {
        Task SendAsync(ChatRoom229Message message);
    }

    [ChatRoomClient]
    public class ChatRoom229Client: IChatRoom229Client
    {
        private Guid _sender;

        public ChatRoom229Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom229Message message) => Task.CompletedTask;
    }

    public class ChatRoom230Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom230Client
    {
        Task SendAsync(ChatRoom230Message message);
    }

    [ChatRoomClient]
    public class ChatRoom230Client: IChatRoom230Client
    {
        private Guid _sender;

        public ChatRoom230Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom230Message message) => Task.CompletedTask;
    }

    public class ChatRoom231Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom231Client
    {
        Task SendAsync(ChatRoom231Message message);
    }

    [ChatRoomClient]
    public class ChatRoom231Client: IChatRoom231Client
    {
        private Guid _sender;

        public ChatRoom231Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom231Message message) => Task.CompletedTask;
    }

    public class ChatRoom232Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom232Client
    {
        Task SendAsync(ChatRoom232Message message);
    }

    [ChatRoomClient]
    public class ChatRoom232Client: IChatRoom232Client
    {
        private Guid _sender;

        public ChatRoom232Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom232Message message) => Task.CompletedTask;
    }

    public class ChatRoom233Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom233Client
    {
        Task SendAsync(ChatRoom233Message message);
    }

    [ChatRoomClient]
    public class ChatRoom233Client: IChatRoom233Client
    {
        private Guid _sender;

        public ChatRoom233Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom233Message message) => Task.CompletedTask;
    }

    public class ChatRoom234Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom234Client
    {
        Task SendAsync(ChatRoom234Message message);
    }

    [ChatRoomClient]
    public class ChatRoom234Client: IChatRoom234Client
    {
        private Guid _sender;

        public ChatRoom234Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom234Message message) => Task.CompletedTask;
    }

    public class ChatRoom235Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom235Client
    {
        Task SendAsync(ChatRoom235Message message);
    }

    [ChatRoomClient]
    public class ChatRoom235Client: IChatRoom235Client
    {
        private Guid _sender;

        public ChatRoom235Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom235Message message) => Task.CompletedTask;
    }

    public class ChatRoom236Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom236Client
    {
        Task SendAsync(ChatRoom236Message message);
    }

    [ChatRoomClient]
    public class ChatRoom236Client: IChatRoom236Client
    {
        private Guid _sender;

        public ChatRoom236Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom236Message message) => Task.CompletedTask;
    }

    public class ChatRoom237Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom237Client
    {
        Task SendAsync(ChatRoom237Message message);
    }

    [ChatRoomClient]
    public class ChatRoom237Client: IChatRoom237Client
    {
        private Guid _sender;

        public ChatRoom237Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom237Message message) => Task.CompletedTask;
    }

    public class ChatRoom238Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom238Client
    {
        Task SendAsync(ChatRoom238Message message);
    }

    [ChatRoomClient]
    public class ChatRoom238Client: IChatRoom238Client
    {
        private Guid _sender;

        public ChatRoom238Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom238Message message) => Task.CompletedTask;
    }

    public class ChatRoom239Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom239Client
    {
        Task SendAsync(ChatRoom239Message message);
    }

    [ChatRoomClient]
    public class ChatRoom239Client: IChatRoom239Client
    {
        private Guid _sender;

        public ChatRoom239Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom239Message message) => Task.CompletedTask;
    }

    public class ChatRoom240Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom240Client
    {
        Task SendAsync(ChatRoom240Message message);
    }

    [ChatRoomClient]
    public class ChatRoom240Client: IChatRoom240Client
    {
        private Guid _sender;

        public ChatRoom240Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom240Message message) => Task.CompletedTask;
    }

    public class ChatRoom241Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom241Client
    {
        Task SendAsync(ChatRoom241Message message);
    }

    [ChatRoomClient]
    public class ChatRoom241Client: IChatRoom241Client
    {
        private Guid _sender;

        public ChatRoom241Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom241Message message) => Task.CompletedTask;
    }

    public class ChatRoom242Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom242Client
    {
        Task SendAsync(ChatRoom242Message message);
    }

    [ChatRoomClient]
    public class ChatRoom242Client: IChatRoom242Client
    {
        private Guid _sender;

        public ChatRoom242Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom242Message message) => Task.CompletedTask;
    }

    public class ChatRoom243Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom243Client
    {
        Task SendAsync(ChatRoom243Message message);
    }

    [ChatRoomClient]
    public class ChatRoom243Client: IChatRoom243Client
    {
        private Guid _sender;

        public ChatRoom243Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom243Message message) => Task.CompletedTask;
    }

    public class ChatRoom244Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom244Client
    {
        Task SendAsync(ChatRoom244Message message);
    }

    [ChatRoomClient]
    public class ChatRoom244Client: IChatRoom244Client
    {
        private Guid _sender;

        public ChatRoom244Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom244Message message) => Task.CompletedTask;
    }

    public class ChatRoom245Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom245Client
    {
        Task SendAsync(ChatRoom245Message message);
    }

    [ChatRoomClient]
    public class ChatRoom245Client: IChatRoom245Client
    {
        private Guid _sender;

        public ChatRoom245Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom245Message message) => Task.CompletedTask;
    }

    public class ChatRoom246Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom246Client
    {
        Task SendAsync(ChatRoom246Message message);
    }

    [ChatRoomClient]
    public class ChatRoom246Client: IChatRoom246Client
    {
        private Guid _sender;

        public ChatRoom246Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom246Message message) => Task.CompletedTask;
    }

    public class ChatRoom247Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom247Client
    {
        Task SendAsync(ChatRoom247Message message);
    }

    [ChatRoomClient]
    public class ChatRoom247Client: IChatRoom247Client
    {
        private Guid _sender;

        public ChatRoom247Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom247Message message) => Task.CompletedTask;
    }

    public class ChatRoom248Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom248Client
    {
        Task SendAsync(ChatRoom248Message message);
    }

    [ChatRoomClient]
    public class ChatRoom248Client: IChatRoom248Client
    {
        private Guid _sender;

        public ChatRoom248Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom248Message message) => Task.CompletedTask;
    }

    public class ChatRoom249Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom249Client
    {
        Task SendAsync(ChatRoom249Message message);
    }

    [ChatRoomClient]
    public class ChatRoom249Client: IChatRoom249Client
    {
        private Guid _sender;

        public ChatRoom249Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom249Message message) => Task.CompletedTask;
    }

    public class ChatRoom250Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom250Client
    {
        Task SendAsync(ChatRoom250Message message);
    }

    [ChatRoomClient]
    public class ChatRoom250Client: IChatRoom250Client
    {
        private Guid _sender;

        public ChatRoom250Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom250Message message) => Task.CompletedTask;
    }

    public class ChatRoom251Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom251Client
    {
        Task SendAsync(ChatRoom251Message message);
    }

    [ChatRoomClient]
    public class ChatRoom251Client: IChatRoom251Client
    {
        private Guid _sender;

        public ChatRoom251Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom251Message message) => Task.CompletedTask;
    }

    public class ChatRoom252Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom252Client
    {
        Task SendAsync(ChatRoom252Message message);
    }

    [ChatRoomClient]
    public class ChatRoom252Client: IChatRoom252Client
    {
        private Guid _sender;

        public ChatRoom252Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom252Message message) => Task.CompletedTask;
    }

    public class ChatRoom253Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom253Client
    {
        Task SendAsync(ChatRoom253Message message);
    }

    [ChatRoomClient]
    public class ChatRoom253Client: IChatRoom253Client
    {
        private Guid _sender;

        public ChatRoom253Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom253Message message) => Task.CompletedTask;
    }

    public class ChatRoom254Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom254Client
    {
        Task SendAsync(ChatRoom254Message message);
    }

    [ChatRoomClient]
    public class ChatRoom254Client: IChatRoom254Client
    {
        private Guid _sender;

        public ChatRoom254Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom254Message message) => Task.CompletedTask;
    }

    public class ChatRoom255Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom255Client
    {
        Task SendAsync(ChatRoom255Message message);
    }

    [ChatRoomClient]
    public class ChatRoom255Client: IChatRoom255Client
    {
        private Guid _sender;

        public ChatRoom255Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom255Message message) => Task.CompletedTask;
    }

    public class ChatRoom256Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom256Client
    {
        Task SendAsync(ChatRoom256Message message);
    }

    [ChatRoomClient]
    public class ChatRoom256Client: IChatRoom256Client
    {
        private Guid _sender;

        public ChatRoom256Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom256Message message) => Task.CompletedTask;
    }

    public class ChatRoom257Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom257Client
    {
        Task SendAsync(ChatRoom257Message message);
    }

    [ChatRoomClient]
    public class ChatRoom257Client: IChatRoom257Client
    {
        private Guid _sender;

        public ChatRoom257Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom257Message message) => Task.CompletedTask;
    }

    public class ChatRoom258Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom258Client
    {
        Task SendAsync(ChatRoom258Message message);
    }

    [ChatRoomClient]
    public class ChatRoom258Client: IChatRoom258Client
    {
        private Guid _sender;

        public ChatRoom258Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom258Message message) => Task.CompletedTask;
    }

    public class ChatRoom259Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom259Client
    {
        Task SendAsync(ChatRoom259Message message);
    }

    [ChatRoomClient]
    public class ChatRoom259Client: IChatRoom259Client
    {
        private Guid _sender;

        public ChatRoom259Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom259Message message) => Task.CompletedTask;
    }

    public class ChatRoom260Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom260Client
    {
        Task SendAsync(ChatRoom260Message message);
    }

    [ChatRoomClient]
    public class ChatRoom260Client: IChatRoom260Client
    {
        private Guid _sender;

        public ChatRoom260Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom260Message message) => Task.CompletedTask;
    }

    public class ChatRoom261Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom261Client
    {
        Task SendAsync(ChatRoom261Message message);
    }

    [ChatRoomClient]
    public class ChatRoom261Client: IChatRoom261Client
    {
        private Guid _sender;

        public ChatRoom261Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom261Message message) => Task.CompletedTask;
    }

    public class ChatRoom262Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom262Client
    {
        Task SendAsync(ChatRoom262Message message);
    }

    [ChatRoomClient]
    public class ChatRoom262Client: IChatRoom262Client
    {
        private Guid _sender;

        public ChatRoom262Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom262Message message) => Task.CompletedTask;
    }

    public class ChatRoom263Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom263Client
    {
        Task SendAsync(ChatRoom263Message message);
    }

    [ChatRoomClient]
    public class ChatRoom263Client: IChatRoom263Client
    {
        private Guid _sender;

        public ChatRoom263Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom263Message message) => Task.CompletedTask;
    }

    public class ChatRoom264Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom264Client
    {
        Task SendAsync(ChatRoom264Message message);
    }

    [ChatRoomClient]
    public class ChatRoom264Client: IChatRoom264Client
    {
        private Guid _sender;

        public ChatRoom264Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom264Message message) => Task.CompletedTask;
    }

    public class ChatRoom265Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom265Client
    {
        Task SendAsync(ChatRoom265Message message);
    }

    [ChatRoomClient]
    public class ChatRoom265Client: IChatRoom265Client
    {
        private Guid _sender;

        public ChatRoom265Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom265Message message) => Task.CompletedTask;
    }

    public class ChatRoom266Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom266Client
    {
        Task SendAsync(ChatRoom266Message message);
    }

    [ChatRoomClient]
    public class ChatRoom266Client: IChatRoom266Client
    {
        private Guid _sender;

        public ChatRoom266Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom266Message message) => Task.CompletedTask;
    }

    public class ChatRoom267Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom267Client
    {
        Task SendAsync(ChatRoom267Message message);
    }

    [ChatRoomClient]
    public class ChatRoom267Client: IChatRoom267Client
    {
        private Guid _sender;

        public ChatRoom267Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom267Message message) => Task.CompletedTask;
    }

    public class ChatRoom268Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom268Client
    {
        Task SendAsync(ChatRoom268Message message);
    }

    [ChatRoomClient]
    public class ChatRoom268Client: IChatRoom268Client
    {
        private Guid _sender;

        public ChatRoom268Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom268Message message) => Task.CompletedTask;
    }

    public class ChatRoom269Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom269Client
    {
        Task SendAsync(ChatRoom269Message message);
    }

    [ChatRoomClient]
    public class ChatRoom269Client: IChatRoom269Client
    {
        private Guid _sender;

        public ChatRoom269Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom269Message message) => Task.CompletedTask;
    }

    public class ChatRoom270Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom270Client
    {
        Task SendAsync(ChatRoom270Message message);
    }

    [ChatRoomClient]
    public class ChatRoom270Client: IChatRoom270Client
    {
        private Guid _sender;

        public ChatRoom270Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom270Message message) => Task.CompletedTask;
    }

    public class ChatRoom271Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom271Client
    {
        Task SendAsync(ChatRoom271Message message);
    }

    [ChatRoomClient]
    public class ChatRoom271Client: IChatRoom271Client
    {
        private Guid _sender;

        public ChatRoom271Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom271Message message) => Task.CompletedTask;
    }

    public class ChatRoom272Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom272Client
    {
        Task SendAsync(ChatRoom272Message message);
    }

    [ChatRoomClient]
    public class ChatRoom272Client: IChatRoom272Client
    {
        private Guid _sender;

        public ChatRoom272Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom272Message message) => Task.CompletedTask;
    }

    public class ChatRoom273Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom273Client
    {
        Task SendAsync(ChatRoom273Message message);
    }

    [ChatRoomClient]
    public class ChatRoom273Client: IChatRoom273Client
    {
        private Guid _sender;

        public ChatRoom273Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom273Message message) => Task.CompletedTask;
    }

    public class ChatRoom274Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom274Client
    {
        Task SendAsync(ChatRoom274Message message);
    }

    [ChatRoomClient]
    public class ChatRoom274Client: IChatRoom274Client
    {
        private Guid _sender;

        public ChatRoom274Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom274Message message) => Task.CompletedTask;
    }

    public class ChatRoom275Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom275Client
    {
        Task SendAsync(ChatRoom275Message message);
    }

    [ChatRoomClient]
    public class ChatRoom275Client: IChatRoom275Client
    {
        private Guid _sender;

        public ChatRoom275Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom275Message message) => Task.CompletedTask;
    }

    public class ChatRoom276Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom276Client
    {
        Task SendAsync(ChatRoom276Message message);
    }

    [ChatRoomClient]
    public class ChatRoom276Client: IChatRoom276Client
    {
        private Guid _sender;

        public ChatRoom276Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom276Message message) => Task.CompletedTask;
    }

    public class ChatRoom277Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom277Client
    {
        Task SendAsync(ChatRoom277Message message);
    }

    [ChatRoomClient]
    public class ChatRoom277Client: IChatRoom277Client
    {
        private Guid _sender;

        public ChatRoom277Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom277Message message) => Task.CompletedTask;
    }

    public class ChatRoom278Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom278Client
    {
        Task SendAsync(ChatRoom278Message message);
    }

    [ChatRoomClient]
    public class ChatRoom278Client: IChatRoom278Client
    {
        private Guid _sender;

        public ChatRoom278Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom278Message message) => Task.CompletedTask;
    }

    public class ChatRoom279Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom279Client
    {
        Task SendAsync(ChatRoom279Message message);
    }

    [ChatRoomClient]
    public class ChatRoom279Client: IChatRoom279Client
    {
        private Guid _sender;

        public ChatRoom279Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom279Message message) => Task.CompletedTask;
    }

    public class ChatRoom280Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom280Client
    {
        Task SendAsync(ChatRoom280Message message);
    }

    [ChatRoomClient]
    public class ChatRoom280Client: IChatRoom280Client
    {
        private Guid _sender;

        public ChatRoom280Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom280Message message) => Task.CompletedTask;
    }

    public class ChatRoom281Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom281Client
    {
        Task SendAsync(ChatRoom281Message message);
    }

    [ChatRoomClient]
    public class ChatRoom281Client: IChatRoom281Client
    {
        private Guid _sender;

        public ChatRoom281Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom281Message message) => Task.CompletedTask;
    }

    public class ChatRoom282Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom282Client
    {
        Task SendAsync(ChatRoom282Message message);
    }

    [ChatRoomClient]
    public class ChatRoom282Client: IChatRoom282Client
    {
        private Guid _sender;

        public ChatRoom282Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom282Message message) => Task.CompletedTask;
    }

    public class ChatRoom283Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom283Client
    {
        Task SendAsync(ChatRoom283Message message);
    }

    [ChatRoomClient]
    public class ChatRoom283Client: IChatRoom283Client
    {
        private Guid _sender;

        public ChatRoom283Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom283Message message) => Task.CompletedTask;
    }

    public class ChatRoom284Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom284Client
    {
        Task SendAsync(ChatRoom284Message message);
    }

    [ChatRoomClient]
    public class ChatRoom284Client: IChatRoom284Client
    {
        private Guid _sender;

        public ChatRoom284Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom284Message message) => Task.CompletedTask;
    }

    public class ChatRoom285Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom285Client
    {
        Task SendAsync(ChatRoom285Message message);
    }

    [ChatRoomClient]
    public class ChatRoom285Client: IChatRoom285Client
    {
        private Guid _sender;

        public ChatRoom285Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom285Message message) => Task.CompletedTask;
    }

    public class ChatRoom286Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom286Client
    {
        Task SendAsync(ChatRoom286Message message);
    }

    [ChatRoomClient]
    public class ChatRoom286Client: IChatRoom286Client
    {
        private Guid _sender;

        public ChatRoom286Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom286Message message) => Task.CompletedTask;
    }

    public class ChatRoom287Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom287Client
    {
        Task SendAsync(ChatRoom287Message message);
    }

    [ChatRoomClient]
    public class ChatRoom287Client: IChatRoom287Client
    {
        private Guid _sender;

        public ChatRoom287Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom287Message message) => Task.CompletedTask;
    }

    public class ChatRoom288Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom288Client
    {
        Task SendAsync(ChatRoom288Message message);
    }

    [ChatRoomClient]
    public class ChatRoom288Client: IChatRoom288Client
    {
        private Guid _sender;

        public ChatRoom288Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom288Message message) => Task.CompletedTask;
    }

    public class ChatRoom289Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom289Client
    {
        Task SendAsync(ChatRoom289Message message);
    }

    [ChatRoomClient]
    public class ChatRoom289Client: IChatRoom289Client
    {
        private Guid _sender;

        public ChatRoom289Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom289Message message) => Task.CompletedTask;
    }

    public class ChatRoom290Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom290Client
    {
        Task SendAsync(ChatRoom290Message message);
    }

    [ChatRoomClient]
    public class ChatRoom290Client: IChatRoom290Client
    {
        private Guid _sender;

        public ChatRoom290Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom290Message message) => Task.CompletedTask;
    }

    public class ChatRoom291Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom291Client
    {
        Task SendAsync(ChatRoom291Message message);
    }

    [ChatRoomClient]
    public class ChatRoom291Client: IChatRoom291Client
    {
        private Guid _sender;

        public ChatRoom291Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom291Message message) => Task.CompletedTask;
    }

    public class ChatRoom292Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom292Client
    {
        Task SendAsync(ChatRoom292Message message);
    }

    [ChatRoomClient]
    public class ChatRoom292Client: IChatRoom292Client
    {
        private Guid _sender;

        public ChatRoom292Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom292Message message) => Task.CompletedTask;
    }

    public class ChatRoom293Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom293Client
    {
        Task SendAsync(ChatRoom293Message message);
    }

    [ChatRoomClient]
    public class ChatRoom293Client: IChatRoom293Client
    {
        private Guid _sender;

        public ChatRoom293Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom293Message message) => Task.CompletedTask;
    }

    public class ChatRoom294Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom294Client
    {
        Task SendAsync(ChatRoom294Message message);
    }

    [ChatRoomClient]
    public class ChatRoom294Client: IChatRoom294Client
    {
        private Guid _sender;

        public ChatRoom294Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom294Message message) => Task.CompletedTask;
    }

    public class ChatRoom295Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom295Client
    {
        Task SendAsync(ChatRoom295Message message);
    }

    [ChatRoomClient]
    public class ChatRoom295Client: IChatRoom295Client
    {
        private Guid _sender;

        public ChatRoom295Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom295Message message) => Task.CompletedTask;
    }

    public class ChatRoom296Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom296Client
    {
        Task SendAsync(ChatRoom296Message message);
    }

    [ChatRoomClient]
    public class ChatRoom296Client: IChatRoom296Client
    {
        private Guid _sender;

        public ChatRoom296Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom296Message message) => Task.CompletedTask;
    }

    public class ChatRoom297Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom297Client
    {
        Task SendAsync(ChatRoom297Message message);
    }

    [ChatRoomClient]
    public class ChatRoom297Client: IChatRoom297Client
    {
        private Guid _sender;

        public ChatRoom297Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom297Message message) => Task.CompletedTask;
    }

    public class ChatRoom298Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom298Client
    {
        Task SendAsync(ChatRoom298Message message);
    }

    [ChatRoomClient]
    public class ChatRoom298Client: IChatRoom298Client
    {
        private Guid _sender;

        public ChatRoom298Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom298Message message) => Task.CompletedTask;
    }

    public class ChatRoom299Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom299Client
    {
        Task SendAsync(ChatRoom299Message message);
    }

    [ChatRoomClient]
    public class ChatRoom299Client: IChatRoom299Client
    {
        private Guid _sender;

        public ChatRoom299Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom299Message message) => Task.CompletedTask;
    }

    public class ChatRoom300Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom300Client
    {
        Task SendAsync(ChatRoom300Message message);
    }

    [ChatRoomClient]
    public class ChatRoom300Client: IChatRoom300Client
    {
        private Guid _sender;

        public ChatRoom300Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom300Message message) => Task.CompletedTask;
    }

    public class ChatRoom301Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom301Client
    {
        Task SendAsync(ChatRoom301Message message);
    }

    [ChatRoomClient]
    public class ChatRoom301Client: IChatRoom301Client
    {
        private Guid _sender;

        public ChatRoom301Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom301Message message) => Task.CompletedTask;
    }

    public class ChatRoom302Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom302Client
    {
        Task SendAsync(ChatRoom302Message message);
    }

    [ChatRoomClient]
    public class ChatRoom302Client: IChatRoom302Client
    {
        private Guid _sender;

        public ChatRoom302Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom302Message message) => Task.CompletedTask;
    }

    public class ChatRoom303Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom303Client
    {
        Task SendAsync(ChatRoom303Message message);
    }

    [ChatRoomClient]
    public class ChatRoom303Client: IChatRoom303Client
    {
        private Guid _sender;

        public ChatRoom303Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom303Message message) => Task.CompletedTask;
    }

    public class ChatRoom304Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom304Client
    {
        Task SendAsync(ChatRoom304Message message);
    }

    [ChatRoomClient]
    public class ChatRoom304Client: IChatRoom304Client
    {
        private Guid _sender;

        public ChatRoom304Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom304Message message) => Task.CompletedTask;
    }

    public class ChatRoom305Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom305Client
    {
        Task SendAsync(ChatRoom305Message message);
    }

    [ChatRoomClient]
    public class ChatRoom305Client: IChatRoom305Client
    {
        private Guid _sender;

        public ChatRoom305Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom305Message message) => Task.CompletedTask;
    }

    public class ChatRoom306Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom306Client
    {
        Task SendAsync(ChatRoom306Message message);
    }

    [ChatRoomClient]
    public class ChatRoom306Client: IChatRoom306Client
    {
        private Guid _sender;

        public ChatRoom306Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom306Message message) => Task.CompletedTask;
    }

    public class ChatRoom307Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom307Client
    {
        Task SendAsync(ChatRoom307Message message);
    }

    [ChatRoomClient]
    public class ChatRoom307Client: IChatRoom307Client
    {
        private Guid _sender;

        public ChatRoom307Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom307Message message) => Task.CompletedTask;
    }

    public class ChatRoom308Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom308Client
    {
        Task SendAsync(ChatRoom308Message message);
    }

    [ChatRoomClient]
    public class ChatRoom308Client: IChatRoom308Client
    {
        private Guid _sender;

        public ChatRoom308Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom308Message message) => Task.CompletedTask;
    }

    public class ChatRoom309Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom309Client
    {
        Task SendAsync(ChatRoom309Message message);
    }

    [ChatRoomClient]
    public class ChatRoom309Client: IChatRoom309Client
    {
        private Guid _sender;

        public ChatRoom309Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom309Message message) => Task.CompletedTask;
    }

    public class ChatRoom310Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom310Client
    {
        Task SendAsync(ChatRoom310Message message);
    }

    [ChatRoomClient]
    public class ChatRoom310Client: IChatRoom310Client
    {
        private Guid _sender;

        public ChatRoom310Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom310Message message) => Task.CompletedTask;
    }

    public class ChatRoom311Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom311Client
    {
        Task SendAsync(ChatRoom311Message message);
    }

    [ChatRoomClient]
    public class ChatRoom311Client: IChatRoom311Client
    {
        private Guid _sender;

        public ChatRoom311Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom311Message message) => Task.CompletedTask;
    }

    public class ChatRoom312Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom312Client
    {
        Task SendAsync(ChatRoom312Message message);
    }

    [ChatRoomClient]
    public class ChatRoom312Client: IChatRoom312Client
    {
        private Guid _sender;

        public ChatRoom312Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom312Message message) => Task.CompletedTask;
    }

    public class ChatRoom313Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom313Client
    {
        Task SendAsync(ChatRoom313Message message);
    }

    [ChatRoomClient]
    public class ChatRoom313Client: IChatRoom313Client
    {
        private Guid _sender;

        public ChatRoom313Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom313Message message) => Task.CompletedTask;
    }

    public class ChatRoom314Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom314Client
    {
        Task SendAsync(ChatRoom314Message message);
    }

    [ChatRoomClient]
    public class ChatRoom314Client: IChatRoom314Client
    {
        private Guid _sender;

        public ChatRoom314Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom314Message message) => Task.CompletedTask;
    }

    public class ChatRoom315Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom315Client
    {
        Task SendAsync(ChatRoom315Message message);
    }

    [ChatRoomClient]
    public class ChatRoom315Client: IChatRoom315Client
    {
        private Guid _sender;

        public ChatRoom315Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom315Message message) => Task.CompletedTask;
    }

    public class ChatRoom316Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom316Client
    {
        Task SendAsync(ChatRoom316Message message);
    }

    [ChatRoomClient]
    public class ChatRoom316Client: IChatRoom316Client
    {
        private Guid _sender;

        public ChatRoom316Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom316Message message) => Task.CompletedTask;
    }

    public class ChatRoom317Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom317Client
    {
        Task SendAsync(ChatRoom317Message message);
    }

    [ChatRoomClient]
    public class ChatRoom317Client: IChatRoom317Client
    {
        private Guid _sender;

        public ChatRoom317Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom317Message message) => Task.CompletedTask;
    }

    public class ChatRoom318Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom318Client
    {
        Task SendAsync(ChatRoom318Message message);
    }

    [ChatRoomClient]
    public class ChatRoom318Client: IChatRoom318Client
    {
        private Guid _sender;

        public ChatRoom318Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom318Message message) => Task.CompletedTask;
    }

    public class ChatRoom319Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom319Client
    {
        Task SendAsync(ChatRoom319Message message);
    }

    [ChatRoomClient]
    public class ChatRoom319Client: IChatRoom319Client
    {
        private Guid _sender;

        public ChatRoom319Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom319Message message) => Task.CompletedTask;
    }

    public class ChatRoom320Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom320Client
    {
        Task SendAsync(ChatRoom320Message message);
    }

    [ChatRoomClient]
    public class ChatRoom320Client: IChatRoom320Client
    {
        private Guid _sender;

        public ChatRoom320Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom320Message message) => Task.CompletedTask;
    }

    public class ChatRoom321Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom321Client
    {
        Task SendAsync(ChatRoom321Message message);
    }

    [ChatRoomClient]
    public class ChatRoom321Client: IChatRoom321Client
    {
        private Guid _sender;

        public ChatRoom321Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom321Message message) => Task.CompletedTask;
    }

    public class ChatRoom322Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom322Client
    {
        Task SendAsync(ChatRoom322Message message);
    }

    [ChatRoomClient]
    public class ChatRoom322Client: IChatRoom322Client
    {
        private Guid _sender;

        public ChatRoom322Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom322Message message) => Task.CompletedTask;
    }

    public class ChatRoom323Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom323Client
    {
        Task SendAsync(ChatRoom323Message message);
    }

    [ChatRoomClient]
    public class ChatRoom323Client: IChatRoom323Client
    {
        private Guid _sender;

        public ChatRoom323Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom323Message message) => Task.CompletedTask;
    }

    public class ChatRoom324Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom324Client
    {
        Task SendAsync(ChatRoom324Message message);
    }

    [ChatRoomClient]
    public class ChatRoom324Client: IChatRoom324Client
    {
        private Guid _sender;

        public ChatRoom324Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom324Message message) => Task.CompletedTask;
    }

    public class ChatRoom325Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom325Client
    {
        Task SendAsync(ChatRoom325Message message);
    }

    [ChatRoomClient]
    public class ChatRoom325Client: IChatRoom325Client
    {
        private Guid _sender;

        public ChatRoom325Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom325Message message) => Task.CompletedTask;
    }

    public class ChatRoom326Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom326Client
    {
        Task SendAsync(ChatRoom326Message message);
    }

    [ChatRoomClient]
    public class ChatRoom326Client: IChatRoom326Client
    {
        private Guid _sender;

        public ChatRoom326Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom326Message message) => Task.CompletedTask;
    }

    public class ChatRoom327Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom327Client
    {
        Task SendAsync(ChatRoom327Message message);
    }

    [ChatRoomClient]
    public class ChatRoom327Client: IChatRoom327Client
    {
        private Guid _sender;

        public ChatRoom327Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom327Message message) => Task.CompletedTask;
    }

    public class ChatRoom328Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom328Client
    {
        Task SendAsync(ChatRoom328Message message);
    }

    [ChatRoomClient]
    public class ChatRoom328Client: IChatRoom328Client
    {
        private Guid _sender;

        public ChatRoom328Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom328Message message) => Task.CompletedTask;
    }

    public class ChatRoom329Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom329Client
    {
        Task SendAsync(ChatRoom329Message message);
    }

    [ChatRoomClient]
    public class ChatRoom329Client: IChatRoom329Client
    {
        private Guid _sender;

        public ChatRoom329Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom329Message message) => Task.CompletedTask;
    }

    public class ChatRoom330Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom330Client
    {
        Task SendAsync(ChatRoom330Message message);
    }

    [ChatRoomClient]
    public class ChatRoom330Client: IChatRoom330Client
    {
        private Guid _sender;

        public ChatRoom330Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom330Message message) => Task.CompletedTask;
    }

    public class ChatRoom331Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom331Client
    {
        Task SendAsync(ChatRoom331Message message);
    }

    [ChatRoomClient]
    public class ChatRoom331Client: IChatRoom331Client
    {
        private Guid _sender;

        public ChatRoom331Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom331Message message) => Task.CompletedTask;
    }

    public class ChatRoom332Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom332Client
    {
        Task SendAsync(ChatRoom332Message message);
    }

    [ChatRoomClient]
    public class ChatRoom332Client: IChatRoom332Client
    {
        private Guid _sender;

        public ChatRoom332Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom332Message message) => Task.CompletedTask;
    }

    public class ChatRoom333Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom333Client
    {
        Task SendAsync(ChatRoom333Message message);
    }

    [ChatRoomClient]
    public class ChatRoom333Client: IChatRoom333Client
    {
        private Guid _sender;

        public ChatRoom333Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom333Message message) => Task.CompletedTask;
    }

    public class ChatRoom334Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom334Client
    {
        Task SendAsync(ChatRoom334Message message);
    }

    [ChatRoomClient]
    public class ChatRoom334Client: IChatRoom334Client
    {
        private Guid _sender;

        public ChatRoom334Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom334Message message) => Task.CompletedTask;
    }

    public class ChatRoom335Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom335Client
    {
        Task SendAsync(ChatRoom335Message message);
    }

    [ChatRoomClient]
    public class ChatRoom335Client: IChatRoom335Client
    {
        private Guid _sender;

        public ChatRoom335Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom335Message message) => Task.CompletedTask;
    }

    public class ChatRoom336Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom336Client
    {
        Task SendAsync(ChatRoom336Message message);
    }

    [ChatRoomClient]
    public class ChatRoom336Client: IChatRoom336Client
    {
        private Guid _sender;

        public ChatRoom336Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom336Message message) => Task.CompletedTask;
    }

    public class ChatRoom337Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom337Client
    {
        Task SendAsync(ChatRoom337Message message);
    }

    [ChatRoomClient]
    public class ChatRoom337Client: IChatRoom337Client
    {
        private Guid _sender;

        public ChatRoom337Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom337Message message) => Task.CompletedTask;
    }

    public class ChatRoom338Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom338Client
    {
        Task SendAsync(ChatRoom338Message message);
    }

    [ChatRoomClient]
    public class ChatRoom338Client: IChatRoom338Client
    {
        private Guid _sender;

        public ChatRoom338Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom338Message message) => Task.CompletedTask;
    }

    public class ChatRoom339Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom339Client
    {
        Task SendAsync(ChatRoom339Message message);
    }

    [ChatRoomClient]
    public class ChatRoom339Client: IChatRoom339Client
    {
        private Guid _sender;

        public ChatRoom339Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom339Message message) => Task.CompletedTask;
    }

    public class ChatRoom340Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom340Client
    {
        Task SendAsync(ChatRoom340Message message);
    }

    [ChatRoomClient]
    public class ChatRoom340Client: IChatRoom340Client
    {
        private Guid _sender;

        public ChatRoom340Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom340Message message) => Task.CompletedTask;
    }

    public class ChatRoom341Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom341Client
    {
        Task SendAsync(ChatRoom341Message message);
    }

    [ChatRoomClient]
    public class ChatRoom341Client: IChatRoom341Client
    {
        private Guid _sender;

        public ChatRoom341Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom341Message message) => Task.CompletedTask;
    }

    public class ChatRoom342Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom342Client
    {
        Task SendAsync(ChatRoom342Message message);
    }

    [ChatRoomClient]
    public class ChatRoom342Client: IChatRoom342Client
    {
        private Guid _sender;

        public ChatRoom342Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom342Message message) => Task.CompletedTask;
    }

    public class ChatRoom343Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom343Client
    {
        Task SendAsync(ChatRoom343Message message);
    }

    [ChatRoomClient]
    public class ChatRoom343Client: IChatRoom343Client
    {
        private Guid _sender;

        public ChatRoom343Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom343Message message) => Task.CompletedTask;
    }

    public class ChatRoom344Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom344Client
    {
        Task SendAsync(ChatRoom344Message message);
    }

    [ChatRoomClient]
    public class ChatRoom344Client: IChatRoom344Client
    {
        private Guid _sender;

        public ChatRoom344Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom344Message message) => Task.CompletedTask;
    }

    public class ChatRoom345Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom345Client
    {
        Task SendAsync(ChatRoom345Message message);
    }

    [ChatRoomClient]
    public class ChatRoom345Client: IChatRoom345Client
    {
        private Guid _sender;

        public ChatRoom345Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom345Message message) => Task.CompletedTask;
    }

    public class ChatRoom346Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom346Client
    {
        Task SendAsync(ChatRoom346Message message);
    }

    [ChatRoomClient]
    public class ChatRoom346Client: IChatRoom346Client
    {
        private Guid _sender;

        public ChatRoom346Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom346Message message) => Task.CompletedTask;
    }

    public class ChatRoom347Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom347Client
    {
        Task SendAsync(ChatRoom347Message message);
    }

    [ChatRoomClient]
    public class ChatRoom347Client: IChatRoom347Client
    {
        private Guid _sender;

        public ChatRoom347Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom347Message message) => Task.CompletedTask;
    }

    public class ChatRoom348Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom348Client
    {
        Task SendAsync(ChatRoom348Message message);
    }

    [ChatRoomClient]
    public class ChatRoom348Client: IChatRoom348Client
    {
        private Guid _sender;

        public ChatRoom348Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom348Message message) => Task.CompletedTask;
    }

    public class ChatRoom349Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom349Client
    {
        Task SendAsync(ChatRoom349Message message);
    }

    [ChatRoomClient]
    public class ChatRoom349Client: IChatRoom349Client
    {
        private Guid _sender;

        public ChatRoom349Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom349Message message) => Task.CompletedTask;
    }

    public class ChatRoom350Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom350Client
    {
        Task SendAsync(ChatRoom350Message message);
    }

    [ChatRoomClient]
    public class ChatRoom350Client: IChatRoom350Client
    {
        private Guid _sender;

        public ChatRoom350Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom350Message message) => Task.CompletedTask;
    }

    public class ChatRoom351Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom351Client
    {
        Task SendAsync(ChatRoom351Message message);
    }

    [ChatRoomClient]
    public class ChatRoom351Client: IChatRoom351Client
    {
        private Guid _sender;

        public ChatRoom351Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom351Message message) => Task.CompletedTask;
    }

    public class ChatRoom352Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom352Client
    {
        Task SendAsync(ChatRoom352Message message);
    }

    [ChatRoomClient]
    public class ChatRoom352Client: IChatRoom352Client
    {
        private Guid _sender;

        public ChatRoom352Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom352Message message) => Task.CompletedTask;
    }

    public class ChatRoom353Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom353Client
    {
        Task SendAsync(ChatRoom353Message message);
    }

    [ChatRoomClient]
    public class ChatRoom353Client: IChatRoom353Client
    {
        private Guid _sender;

        public ChatRoom353Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom353Message message) => Task.CompletedTask;
    }

    public class ChatRoom354Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom354Client
    {
        Task SendAsync(ChatRoom354Message message);
    }

    [ChatRoomClient]
    public class ChatRoom354Client: IChatRoom354Client
    {
        private Guid _sender;

        public ChatRoom354Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom354Message message) => Task.CompletedTask;
    }

    public class ChatRoom355Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom355Client
    {
        Task SendAsync(ChatRoom355Message message);
    }

    [ChatRoomClient]
    public class ChatRoom355Client: IChatRoom355Client
    {
        private Guid _sender;

        public ChatRoom355Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom355Message message) => Task.CompletedTask;
    }

    public class ChatRoom356Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom356Client
    {
        Task SendAsync(ChatRoom356Message message);
    }

    [ChatRoomClient]
    public class ChatRoom356Client: IChatRoom356Client
    {
        private Guid _sender;

        public ChatRoom356Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom356Message message) => Task.CompletedTask;
    }

    public class ChatRoom357Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom357Client
    {
        Task SendAsync(ChatRoom357Message message);
    }

    [ChatRoomClient]
    public class ChatRoom357Client: IChatRoom357Client
    {
        private Guid _sender;

        public ChatRoom357Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom357Message message) => Task.CompletedTask;
    }

    public class ChatRoom358Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom358Client
    {
        Task SendAsync(ChatRoom358Message message);
    }

    [ChatRoomClient]
    public class ChatRoom358Client: IChatRoom358Client
    {
        private Guid _sender;

        public ChatRoom358Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom358Message message) => Task.CompletedTask;
    }

    public class ChatRoom359Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom359Client
    {
        Task SendAsync(ChatRoom359Message message);
    }

    [ChatRoomClient]
    public class ChatRoom359Client: IChatRoom359Client
    {
        private Guid _sender;

        public ChatRoom359Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom359Message message) => Task.CompletedTask;
    }

    public class ChatRoom360Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom360Client
    {
        Task SendAsync(ChatRoom360Message message);
    }

    [ChatRoomClient]
    public class ChatRoom360Client: IChatRoom360Client
    {
        private Guid _sender;

        public ChatRoom360Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom360Message message) => Task.CompletedTask;
    }

    public class ChatRoom361Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom361Client
    {
        Task SendAsync(ChatRoom361Message message);
    }

    [ChatRoomClient]
    public class ChatRoom361Client: IChatRoom361Client
    {
        private Guid _sender;

        public ChatRoom361Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom361Message message) => Task.CompletedTask;
    }

    public class ChatRoom362Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom362Client
    {
        Task SendAsync(ChatRoom362Message message);
    }

    [ChatRoomClient]
    public class ChatRoom362Client: IChatRoom362Client
    {
        private Guid _sender;

        public ChatRoom362Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom362Message message) => Task.CompletedTask;
    }

    public class ChatRoom363Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom363Client
    {
        Task SendAsync(ChatRoom363Message message);
    }

    [ChatRoomClient]
    public class ChatRoom363Client: IChatRoom363Client
    {
        private Guid _sender;

        public ChatRoom363Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom363Message message) => Task.CompletedTask;
    }

    public class ChatRoom364Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom364Client
    {
        Task SendAsync(ChatRoom364Message message);
    }

    [ChatRoomClient]
    public class ChatRoom364Client: IChatRoom364Client
    {
        private Guid _sender;

        public ChatRoom364Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom364Message message) => Task.CompletedTask;
    }

    public class ChatRoom365Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom365Client
    {
        Task SendAsync(ChatRoom365Message message);
    }

    [ChatRoomClient]
    public class ChatRoom365Client: IChatRoom365Client
    {
        private Guid _sender;

        public ChatRoom365Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom365Message message) => Task.CompletedTask;
    }

    public class ChatRoom366Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom366Client
    {
        Task SendAsync(ChatRoom366Message message);
    }

    [ChatRoomClient]
    public class ChatRoom366Client: IChatRoom366Client
    {
        private Guid _sender;

        public ChatRoom366Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom366Message message) => Task.CompletedTask;
    }

    public class ChatRoom367Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom367Client
    {
        Task SendAsync(ChatRoom367Message message);
    }

    [ChatRoomClient]
    public class ChatRoom367Client: IChatRoom367Client
    {
        private Guid _sender;

        public ChatRoom367Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom367Message message) => Task.CompletedTask;
    }

    public class ChatRoom368Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom368Client
    {
        Task SendAsync(ChatRoom368Message message);
    }

    [ChatRoomClient]
    public class ChatRoom368Client: IChatRoom368Client
    {
        private Guid _sender;

        public ChatRoom368Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom368Message message) => Task.CompletedTask;
    }

    public class ChatRoom369Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom369Client
    {
        Task SendAsync(ChatRoom369Message message);
    }

    [ChatRoomClient]
    public class ChatRoom369Client: IChatRoom369Client
    {
        private Guid _sender;

        public ChatRoom369Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom369Message message) => Task.CompletedTask;
    }

    public class ChatRoom370Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom370Client
    {
        Task SendAsync(ChatRoom370Message message);
    }

    [ChatRoomClient]
    public class ChatRoom370Client: IChatRoom370Client
    {
        private Guid _sender;

        public ChatRoom370Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom370Message message) => Task.CompletedTask;
    }

    public class ChatRoom371Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom371Client
    {
        Task SendAsync(ChatRoom371Message message);
    }

    [ChatRoomClient]
    public class ChatRoom371Client: IChatRoom371Client
    {
        private Guid _sender;

        public ChatRoom371Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom371Message message) => Task.CompletedTask;
    }

    public class ChatRoom372Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom372Client
    {
        Task SendAsync(ChatRoom372Message message);
    }

    [ChatRoomClient]
    public class ChatRoom372Client: IChatRoom372Client
    {
        private Guid _sender;

        public ChatRoom372Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom372Message message) => Task.CompletedTask;
    }

    public class ChatRoom373Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom373Client
    {
        Task SendAsync(ChatRoom373Message message);
    }

    [ChatRoomClient]
    public class ChatRoom373Client: IChatRoom373Client
    {
        private Guid _sender;

        public ChatRoom373Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom373Message message) => Task.CompletedTask;
    }

    public class ChatRoom374Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom374Client
    {
        Task SendAsync(ChatRoom374Message message);
    }

    [ChatRoomClient]
    public class ChatRoom374Client: IChatRoom374Client
    {
        private Guid _sender;

        public ChatRoom374Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom374Message message) => Task.CompletedTask;
    }

    public class ChatRoom375Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom375Client
    {
        Task SendAsync(ChatRoom375Message message);
    }

    [ChatRoomClient]
    public class ChatRoom375Client: IChatRoom375Client
    {
        private Guid _sender;

        public ChatRoom375Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom375Message message) => Task.CompletedTask;
    }

    public class ChatRoom376Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom376Client
    {
        Task SendAsync(ChatRoom376Message message);
    }

    [ChatRoomClient]
    public class ChatRoom376Client: IChatRoom376Client
    {
        private Guid _sender;

        public ChatRoom376Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom376Message message) => Task.CompletedTask;
    }

    public class ChatRoom377Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom377Client
    {
        Task SendAsync(ChatRoom377Message message);
    }

    [ChatRoomClient]
    public class ChatRoom377Client: IChatRoom377Client
    {
        private Guid _sender;

        public ChatRoom377Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom377Message message) => Task.CompletedTask;
    }

    public class ChatRoom378Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom378Client
    {
        Task SendAsync(ChatRoom378Message message);
    }

    [ChatRoomClient]
    public class ChatRoom378Client: IChatRoom378Client
    {
        private Guid _sender;

        public ChatRoom378Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom378Message message) => Task.CompletedTask;
    }

    public class ChatRoom379Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom379Client
    {
        Task SendAsync(ChatRoom379Message message);
    }

    [ChatRoomClient]
    public class ChatRoom379Client: IChatRoom379Client
    {
        private Guid _sender;

        public ChatRoom379Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom379Message message) => Task.CompletedTask;
    }

    public class ChatRoom380Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom380Client
    {
        Task SendAsync(ChatRoom380Message message);
    }

    [ChatRoomClient]
    public class ChatRoom380Client: IChatRoom380Client
    {
        private Guid _sender;

        public ChatRoom380Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom380Message message) => Task.CompletedTask;
    }

    public class ChatRoom381Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom381Client
    {
        Task SendAsync(ChatRoom381Message message);
    }

    [ChatRoomClient]
    public class ChatRoom381Client: IChatRoom381Client
    {
        private Guid _sender;

        public ChatRoom381Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom381Message message) => Task.CompletedTask;
    }

    public class ChatRoom382Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom382Client
    {
        Task SendAsync(ChatRoom382Message message);
    }

    [ChatRoomClient]
    public class ChatRoom382Client: IChatRoom382Client
    {
        private Guid _sender;

        public ChatRoom382Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom382Message message) => Task.CompletedTask;
    }

    public class ChatRoom383Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom383Client
    {
        Task SendAsync(ChatRoom383Message message);
    }

    [ChatRoomClient]
    public class ChatRoom383Client: IChatRoom383Client
    {
        private Guid _sender;

        public ChatRoom383Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom383Message message) => Task.CompletedTask;
    }

    public class ChatRoom384Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom384Client
    {
        Task SendAsync(ChatRoom384Message message);
    }

    [ChatRoomClient]
    public class ChatRoom384Client: IChatRoom384Client
    {
        private Guid _sender;

        public ChatRoom384Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom384Message message) => Task.CompletedTask;
    }

    public class ChatRoom385Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom385Client
    {
        Task SendAsync(ChatRoom385Message message);
    }

    [ChatRoomClient]
    public class ChatRoom385Client: IChatRoom385Client
    {
        private Guid _sender;

        public ChatRoom385Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom385Message message) => Task.CompletedTask;
    }

    public class ChatRoom386Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom386Client
    {
        Task SendAsync(ChatRoom386Message message);
    }

    [ChatRoomClient]
    public class ChatRoom386Client: IChatRoom386Client
    {
        private Guid _sender;

        public ChatRoom386Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom386Message message) => Task.CompletedTask;
    }

    public class ChatRoom387Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom387Client
    {
        Task SendAsync(ChatRoom387Message message);
    }

    [ChatRoomClient]
    public class ChatRoom387Client: IChatRoom387Client
    {
        private Guid _sender;

        public ChatRoom387Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom387Message message) => Task.CompletedTask;
    }

    public class ChatRoom388Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom388Client
    {
        Task SendAsync(ChatRoom388Message message);
    }

    [ChatRoomClient]
    public class ChatRoom388Client: IChatRoom388Client
    {
        private Guid _sender;

        public ChatRoom388Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom388Message message) => Task.CompletedTask;
    }

    public class ChatRoom389Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom389Client
    {
        Task SendAsync(ChatRoom389Message message);
    }

    [ChatRoomClient]
    public class ChatRoom389Client: IChatRoom389Client
    {
        private Guid _sender;

        public ChatRoom389Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom389Message message) => Task.CompletedTask;
    }

    public class ChatRoom390Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom390Client
    {
        Task SendAsync(ChatRoom390Message message);
    }

    [ChatRoomClient]
    public class ChatRoom390Client: IChatRoom390Client
    {
        private Guid _sender;

        public ChatRoom390Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom390Message message) => Task.CompletedTask;
    }

    public class ChatRoom391Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom391Client
    {
        Task SendAsync(ChatRoom391Message message);
    }

    [ChatRoomClient]
    public class ChatRoom391Client: IChatRoom391Client
    {
        private Guid _sender;

        public ChatRoom391Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom391Message message) => Task.CompletedTask;
    }

    public class ChatRoom392Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom392Client
    {
        Task SendAsync(ChatRoom392Message message);
    }

    [ChatRoomClient]
    public class ChatRoom392Client: IChatRoom392Client
    {
        private Guid _sender;

        public ChatRoom392Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom392Message message) => Task.CompletedTask;
    }

    public class ChatRoom393Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom393Client
    {
        Task SendAsync(ChatRoom393Message message);
    }

    [ChatRoomClient]
    public class ChatRoom393Client: IChatRoom393Client
    {
        private Guid _sender;

        public ChatRoom393Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom393Message message) => Task.CompletedTask;
    }

    public class ChatRoom394Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom394Client
    {
        Task SendAsync(ChatRoom394Message message);
    }

    [ChatRoomClient]
    public class ChatRoom394Client: IChatRoom394Client
    {
        private Guid _sender;

        public ChatRoom394Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom394Message message) => Task.CompletedTask;
    }

    public class ChatRoom395Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom395Client
    {
        Task SendAsync(ChatRoom395Message message);
    }

    [ChatRoomClient]
    public class ChatRoom395Client: IChatRoom395Client
    {
        private Guid _sender;

        public ChatRoom395Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom395Message message) => Task.CompletedTask;
    }

    public class ChatRoom396Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom396Client
    {
        Task SendAsync(ChatRoom396Message message);
    }

    [ChatRoomClient]
    public class ChatRoom396Client: IChatRoom396Client
    {
        private Guid _sender;

        public ChatRoom396Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom396Message message) => Task.CompletedTask;
    }

    public class ChatRoom397Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom397Client
    {
        Task SendAsync(ChatRoom397Message message);
    }

    [ChatRoomClient]
    public class ChatRoom397Client: IChatRoom397Client
    {
        private Guid _sender;

        public ChatRoom397Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom397Message message) => Task.CompletedTask;
    }

    public class ChatRoom398Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom398Client
    {
        Task SendAsync(ChatRoom398Message message);
    }

    [ChatRoomClient]
    public class ChatRoom398Client: IChatRoom398Client
    {
        private Guid _sender;

        public ChatRoom398Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom398Message message) => Task.CompletedTask;
    }

    public class ChatRoom399Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom399Client
    {
        Task SendAsync(ChatRoom399Message message);
    }

    [ChatRoomClient]
    public class ChatRoom399Client: IChatRoom399Client
    {
        private Guid _sender;

        public ChatRoom399Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom399Message message) => Task.CompletedTask;
    }

    public class ChatRoom400Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom400Client
    {
        Task SendAsync(ChatRoom400Message message);
    }

    [ChatRoomClient]
    public class ChatRoom400Client: IChatRoom400Client
    {
        private Guid _sender;

        public ChatRoom400Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom400Message message) => Task.CompletedTask;
    }

    public class ChatRoom401Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom401Client
    {
        Task SendAsync(ChatRoom401Message message);
    }

    [ChatRoomClient]
    public class ChatRoom401Client: IChatRoom401Client
    {
        private Guid _sender;

        public ChatRoom401Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom401Message message) => Task.CompletedTask;
    }

    public class ChatRoom402Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom402Client
    {
        Task SendAsync(ChatRoom402Message message);
    }

    [ChatRoomClient]
    public class ChatRoom402Client: IChatRoom402Client
    {
        private Guid _sender;

        public ChatRoom402Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom402Message message) => Task.CompletedTask;
    }

    public class ChatRoom403Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom403Client
    {
        Task SendAsync(ChatRoom403Message message);
    }

    [ChatRoomClient]
    public class ChatRoom403Client: IChatRoom403Client
    {
        private Guid _sender;

        public ChatRoom403Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom403Message message) => Task.CompletedTask;
    }

    public class ChatRoom404Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom404Client
    {
        Task SendAsync(ChatRoom404Message message);
    }

    [ChatRoomClient]
    public class ChatRoom404Client: IChatRoom404Client
    {
        private Guid _sender;

        public ChatRoom404Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom404Message message) => Task.CompletedTask;
    }

    public class ChatRoom405Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom405Client
    {
        Task SendAsync(ChatRoom405Message message);
    }

    [ChatRoomClient]
    public class ChatRoom405Client: IChatRoom405Client
    {
        private Guid _sender;

        public ChatRoom405Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom405Message message) => Task.CompletedTask;
    }

    public class ChatRoom406Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom406Client
    {
        Task SendAsync(ChatRoom406Message message);
    }

    [ChatRoomClient]
    public class ChatRoom406Client: IChatRoom406Client
    {
        private Guid _sender;

        public ChatRoom406Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom406Message message) => Task.CompletedTask;
    }

    public class ChatRoom407Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom407Client
    {
        Task SendAsync(ChatRoom407Message message);
    }

    [ChatRoomClient]
    public class ChatRoom407Client: IChatRoom407Client
    {
        private Guid _sender;

        public ChatRoom407Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom407Message message) => Task.CompletedTask;
    }

    public class ChatRoom408Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom408Client
    {
        Task SendAsync(ChatRoom408Message message);
    }

    [ChatRoomClient]
    public class ChatRoom408Client: IChatRoom408Client
    {
        private Guid _sender;

        public ChatRoom408Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom408Message message) => Task.CompletedTask;
    }

    public class ChatRoom409Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom409Client
    {
        Task SendAsync(ChatRoom409Message message);
    }

    [ChatRoomClient]
    public class ChatRoom409Client: IChatRoom409Client
    {
        private Guid _sender;

        public ChatRoom409Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom409Message message) => Task.CompletedTask;
    }

    public class ChatRoom410Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom410Client
    {
        Task SendAsync(ChatRoom410Message message);
    }

    [ChatRoomClient]
    public class ChatRoom410Client: IChatRoom410Client
    {
        private Guid _sender;

        public ChatRoom410Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom410Message message) => Task.CompletedTask;
    }

    public class ChatRoom411Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom411Client
    {
        Task SendAsync(ChatRoom411Message message);
    }

    [ChatRoomClient]
    public class ChatRoom411Client: IChatRoom411Client
    {
        private Guid _sender;

        public ChatRoom411Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom411Message message) => Task.CompletedTask;
    }

    public class ChatRoom412Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom412Client
    {
        Task SendAsync(ChatRoom412Message message);
    }

    [ChatRoomClient]
    public class ChatRoom412Client: IChatRoom412Client
    {
        private Guid _sender;

        public ChatRoom412Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom412Message message) => Task.CompletedTask;
    }

    public class ChatRoom413Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom413Client
    {
        Task SendAsync(ChatRoom413Message message);
    }

    [ChatRoomClient]
    public class ChatRoom413Client: IChatRoom413Client
    {
        private Guid _sender;

        public ChatRoom413Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom413Message message) => Task.CompletedTask;
    }

    public class ChatRoom414Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom414Client
    {
        Task SendAsync(ChatRoom414Message message);
    }

    [ChatRoomClient]
    public class ChatRoom414Client: IChatRoom414Client
    {
        private Guid _sender;

        public ChatRoom414Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom414Message message) => Task.CompletedTask;
    }

    public class ChatRoom415Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom415Client
    {
        Task SendAsync(ChatRoom415Message message);
    }

    [ChatRoomClient]
    public class ChatRoom415Client: IChatRoom415Client
    {
        private Guid _sender;

        public ChatRoom415Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom415Message message) => Task.CompletedTask;
    }

    public class ChatRoom416Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom416Client
    {
        Task SendAsync(ChatRoom416Message message);
    }

    [ChatRoomClient]
    public class ChatRoom416Client: IChatRoom416Client
    {
        private Guid _sender;

        public ChatRoom416Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom416Message message) => Task.CompletedTask;
    }

    public class ChatRoom417Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom417Client
    {
        Task SendAsync(ChatRoom417Message message);
    }

    [ChatRoomClient]
    public class ChatRoom417Client: IChatRoom417Client
    {
        private Guid _sender;

        public ChatRoom417Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom417Message message) => Task.CompletedTask;
    }

    public class ChatRoom418Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom418Client
    {
        Task SendAsync(ChatRoom418Message message);
    }

    [ChatRoomClient]
    public class ChatRoom418Client: IChatRoom418Client
    {
        private Guid _sender;

        public ChatRoom418Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom418Message message) => Task.CompletedTask;
    }

    public class ChatRoom419Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom419Client
    {
        Task SendAsync(ChatRoom419Message message);
    }

    [ChatRoomClient]
    public class ChatRoom419Client: IChatRoom419Client
    {
        private Guid _sender;

        public ChatRoom419Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom419Message message) => Task.CompletedTask;
    }

    public class ChatRoom420Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom420Client
    {
        Task SendAsync(ChatRoom420Message message);
    }

    [ChatRoomClient]
    public class ChatRoom420Client: IChatRoom420Client
    {
        private Guid _sender;

        public ChatRoom420Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom420Message message) => Task.CompletedTask;
    }

    public class ChatRoom421Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom421Client
    {
        Task SendAsync(ChatRoom421Message message);
    }

    [ChatRoomClient]
    public class ChatRoom421Client: IChatRoom421Client
    {
        private Guid _sender;

        public ChatRoom421Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom421Message message) => Task.CompletedTask;
    }

    public class ChatRoom422Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom422Client
    {
        Task SendAsync(ChatRoom422Message message);
    }

    [ChatRoomClient]
    public class ChatRoom422Client: IChatRoom422Client
    {
        private Guid _sender;

        public ChatRoom422Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom422Message message) => Task.CompletedTask;
    }

    public class ChatRoom423Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom423Client
    {
        Task SendAsync(ChatRoom423Message message);
    }

    [ChatRoomClient]
    public class ChatRoom423Client: IChatRoom423Client
    {
        private Guid _sender;

        public ChatRoom423Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom423Message message) => Task.CompletedTask;
    }

    public class ChatRoom424Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom424Client
    {
        Task SendAsync(ChatRoom424Message message);
    }

    [ChatRoomClient]
    public class ChatRoom424Client: IChatRoom424Client
    {
        private Guid _sender;

        public ChatRoom424Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom424Message message) => Task.CompletedTask;
    }

    public class ChatRoom425Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom425Client
    {
        Task SendAsync(ChatRoom425Message message);
    }

    [ChatRoomClient]
    public class ChatRoom425Client: IChatRoom425Client
    {
        private Guid _sender;

        public ChatRoom425Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom425Message message) => Task.CompletedTask;
    }

    public class ChatRoom426Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom426Client
    {
        Task SendAsync(ChatRoom426Message message);
    }

    [ChatRoomClient]
    public class ChatRoom426Client: IChatRoom426Client
    {
        private Guid _sender;

        public ChatRoom426Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom426Message message) => Task.CompletedTask;
    }

    public class ChatRoom427Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom427Client
    {
        Task SendAsync(ChatRoom427Message message);
    }

    [ChatRoomClient]
    public class ChatRoom427Client: IChatRoom427Client
    {
        private Guid _sender;

        public ChatRoom427Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom427Message message) => Task.CompletedTask;
    }

    public class ChatRoom428Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom428Client
    {
        Task SendAsync(ChatRoom428Message message);
    }

    [ChatRoomClient]
    public class ChatRoom428Client: IChatRoom428Client
    {
        private Guid _sender;

        public ChatRoom428Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom428Message message) => Task.CompletedTask;
    }

    public class ChatRoom429Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom429Client
    {
        Task SendAsync(ChatRoom429Message message);
    }

    [ChatRoomClient]
    public class ChatRoom429Client: IChatRoom429Client
    {
        private Guid _sender;

        public ChatRoom429Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom429Message message) => Task.CompletedTask;
    }

    public class ChatRoom430Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom430Client
    {
        Task SendAsync(ChatRoom430Message message);
    }

    [ChatRoomClient]
    public class ChatRoom430Client: IChatRoom430Client
    {
        private Guid _sender;

        public ChatRoom430Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom430Message message) => Task.CompletedTask;
    }

    public class ChatRoom431Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom431Client
    {
        Task SendAsync(ChatRoom431Message message);
    }

    [ChatRoomClient]
    public class ChatRoom431Client: IChatRoom431Client
    {
        private Guid _sender;

        public ChatRoom431Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom431Message message) => Task.CompletedTask;
    }

    public class ChatRoom432Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom432Client
    {
        Task SendAsync(ChatRoom432Message message);
    }

    [ChatRoomClient]
    public class ChatRoom432Client: IChatRoom432Client
    {
        private Guid _sender;

        public ChatRoom432Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom432Message message) => Task.CompletedTask;
    }

    public class ChatRoom433Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom433Client
    {
        Task SendAsync(ChatRoom433Message message);
    }

    [ChatRoomClient]
    public class ChatRoom433Client: IChatRoom433Client
    {
        private Guid _sender;

        public ChatRoom433Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom433Message message) => Task.CompletedTask;
    }

    public class ChatRoom434Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom434Client
    {
        Task SendAsync(ChatRoom434Message message);
    }

    [ChatRoomClient]
    public class ChatRoom434Client: IChatRoom434Client
    {
        private Guid _sender;

        public ChatRoom434Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom434Message message) => Task.CompletedTask;
    }

    public class ChatRoom435Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom435Client
    {
        Task SendAsync(ChatRoom435Message message);
    }

    [ChatRoomClient]
    public class ChatRoom435Client: IChatRoom435Client
    {
        private Guid _sender;

        public ChatRoom435Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom435Message message) => Task.CompletedTask;
    }

    public class ChatRoom436Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom436Client
    {
        Task SendAsync(ChatRoom436Message message);
    }

    [ChatRoomClient]
    public class ChatRoom436Client: IChatRoom436Client
    {
        private Guid _sender;

        public ChatRoom436Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom436Message message) => Task.CompletedTask;
    }

    public class ChatRoom437Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom437Client
    {
        Task SendAsync(ChatRoom437Message message);
    }

    [ChatRoomClient]
    public class ChatRoom437Client: IChatRoom437Client
    {
        private Guid _sender;

        public ChatRoom437Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom437Message message) => Task.CompletedTask;
    }

    public class ChatRoom438Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom438Client
    {
        Task SendAsync(ChatRoom438Message message);
    }

    [ChatRoomClient]
    public class ChatRoom438Client: IChatRoom438Client
    {
        private Guid _sender;

        public ChatRoom438Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom438Message message) => Task.CompletedTask;
    }

    public class ChatRoom439Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom439Client
    {
        Task SendAsync(ChatRoom439Message message);
    }

    [ChatRoomClient]
    public class ChatRoom439Client: IChatRoom439Client
    {
        private Guid _sender;

        public ChatRoom439Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom439Message message) => Task.CompletedTask;
    }

    public class ChatRoom440Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom440Client
    {
        Task SendAsync(ChatRoom440Message message);
    }

    [ChatRoomClient]
    public class ChatRoom440Client: IChatRoom440Client
    {
        private Guid _sender;

        public ChatRoom440Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom440Message message) => Task.CompletedTask;
    }

    public class ChatRoom441Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom441Client
    {
        Task SendAsync(ChatRoom441Message message);
    }

    [ChatRoomClient]
    public class ChatRoom441Client: IChatRoom441Client
    {
        private Guid _sender;

        public ChatRoom441Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom441Message message) => Task.CompletedTask;
    }

    public class ChatRoom442Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom442Client
    {
        Task SendAsync(ChatRoom442Message message);
    }

    [ChatRoomClient]
    public class ChatRoom442Client: IChatRoom442Client
    {
        private Guid _sender;

        public ChatRoom442Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom442Message message) => Task.CompletedTask;
    }

    public class ChatRoom443Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom443Client
    {
        Task SendAsync(ChatRoom443Message message);
    }

    [ChatRoomClient]
    public class ChatRoom443Client: IChatRoom443Client
    {
        private Guid _sender;

        public ChatRoom443Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom443Message message) => Task.CompletedTask;
    }

    public class ChatRoom444Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom444Client
    {
        Task SendAsync(ChatRoom444Message message);
    }

    [ChatRoomClient]
    public class ChatRoom444Client: IChatRoom444Client
    {
        private Guid _sender;

        public ChatRoom444Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom444Message message) => Task.CompletedTask;
    }

    public class ChatRoom445Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom445Client
    {
        Task SendAsync(ChatRoom445Message message);
    }

    [ChatRoomClient]
    public class ChatRoom445Client: IChatRoom445Client
    {
        private Guid _sender;

        public ChatRoom445Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom445Message message) => Task.CompletedTask;
    }

    public class ChatRoom446Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom446Client
    {
        Task SendAsync(ChatRoom446Message message);
    }

    [ChatRoomClient]
    public class ChatRoom446Client: IChatRoom446Client
    {
        private Guid _sender;

        public ChatRoom446Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom446Message message) => Task.CompletedTask;
    }

    public class ChatRoom447Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom447Client
    {
        Task SendAsync(ChatRoom447Message message);
    }

    [ChatRoomClient]
    public class ChatRoom447Client: IChatRoom447Client
    {
        private Guid _sender;

        public ChatRoom447Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom447Message message) => Task.CompletedTask;
    }

    public class ChatRoom448Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom448Client
    {
        Task SendAsync(ChatRoom448Message message);
    }

    [ChatRoomClient]
    public class ChatRoom448Client: IChatRoom448Client
    {
        private Guid _sender;

        public ChatRoom448Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom448Message message) => Task.CompletedTask;
    }

    public class ChatRoom449Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom449Client
    {
        Task SendAsync(ChatRoom449Message message);
    }

    [ChatRoomClient]
    public class ChatRoom449Client: IChatRoom449Client
    {
        private Guid _sender;

        public ChatRoom449Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom449Message message) => Task.CompletedTask;
    }

    public class ChatRoom450Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom450Client
    {
        Task SendAsync(ChatRoom450Message message);
    }

    [ChatRoomClient]
    public class ChatRoom450Client: IChatRoom450Client
    {
        private Guid _sender;

        public ChatRoom450Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom450Message message) => Task.CompletedTask;
    }

    public class ChatRoom451Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom451Client
    {
        Task SendAsync(ChatRoom451Message message);
    }

    [ChatRoomClient]
    public class ChatRoom451Client: IChatRoom451Client
    {
        private Guid _sender;

        public ChatRoom451Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom451Message message) => Task.CompletedTask;
    }

    public class ChatRoom452Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom452Client
    {
        Task SendAsync(ChatRoom452Message message);
    }

    [ChatRoomClient]
    public class ChatRoom452Client: IChatRoom452Client
    {
        private Guid _sender;

        public ChatRoom452Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom452Message message) => Task.CompletedTask;
    }

    public class ChatRoom453Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom453Client
    {
        Task SendAsync(ChatRoom453Message message);
    }

    [ChatRoomClient]
    public class ChatRoom453Client: IChatRoom453Client
    {
        private Guid _sender;

        public ChatRoom453Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom453Message message) => Task.CompletedTask;
    }

    public class ChatRoom454Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom454Client
    {
        Task SendAsync(ChatRoom454Message message);
    }

    [ChatRoomClient]
    public class ChatRoom454Client: IChatRoom454Client
    {
        private Guid _sender;

        public ChatRoom454Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom454Message message) => Task.CompletedTask;
    }

    public class ChatRoom455Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom455Client
    {
        Task SendAsync(ChatRoom455Message message);
    }

    [ChatRoomClient]
    public class ChatRoom455Client: IChatRoom455Client
    {
        private Guid _sender;

        public ChatRoom455Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom455Message message) => Task.CompletedTask;
    }

    public class ChatRoom456Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom456Client
    {
        Task SendAsync(ChatRoom456Message message);
    }

    [ChatRoomClient]
    public class ChatRoom456Client: IChatRoom456Client
    {
        private Guid _sender;

        public ChatRoom456Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom456Message message) => Task.CompletedTask;
    }

    public class ChatRoom457Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom457Client
    {
        Task SendAsync(ChatRoom457Message message);
    }

    [ChatRoomClient]
    public class ChatRoom457Client: IChatRoom457Client
    {
        private Guid _sender;

        public ChatRoom457Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom457Message message) => Task.CompletedTask;
    }

    public class ChatRoom458Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom458Client
    {
        Task SendAsync(ChatRoom458Message message);
    }

    [ChatRoomClient]
    public class ChatRoom458Client: IChatRoom458Client
    {
        private Guid _sender;

        public ChatRoom458Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom458Message message) => Task.CompletedTask;
    }

    public class ChatRoom459Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom459Client
    {
        Task SendAsync(ChatRoom459Message message);
    }

    [ChatRoomClient]
    public class ChatRoom459Client: IChatRoom459Client
    {
        private Guid _sender;

        public ChatRoom459Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom459Message message) => Task.CompletedTask;
    }

    public class ChatRoom460Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom460Client
    {
        Task SendAsync(ChatRoom460Message message);
    }

    [ChatRoomClient]
    public class ChatRoom460Client: IChatRoom460Client
    {
        private Guid _sender;

        public ChatRoom460Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom460Message message) => Task.CompletedTask;
    }

    public class ChatRoom461Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom461Client
    {
        Task SendAsync(ChatRoom461Message message);
    }

    [ChatRoomClient]
    public class ChatRoom461Client: IChatRoom461Client
    {
        private Guid _sender;

        public ChatRoom461Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom461Message message) => Task.CompletedTask;
    }

    public class ChatRoom462Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom462Client
    {
        Task SendAsync(ChatRoom462Message message);
    }

    [ChatRoomClient]
    public class ChatRoom462Client: IChatRoom462Client
    {
        private Guid _sender;

        public ChatRoom462Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom462Message message) => Task.CompletedTask;
    }

    public class ChatRoom463Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom463Client
    {
        Task SendAsync(ChatRoom463Message message);
    }

    [ChatRoomClient]
    public class ChatRoom463Client: IChatRoom463Client
    {
        private Guid _sender;

        public ChatRoom463Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom463Message message) => Task.CompletedTask;
    }

    public class ChatRoom464Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom464Client
    {
        Task SendAsync(ChatRoom464Message message);
    }

    [ChatRoomClient]
    public class ChatRoom464Client: IChatRoom464Client
    {
        private Guid _sender;

        public ChatRoom464Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom464Message message) => Task.CompletedTask;
    }

    public class ChatRoom465Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom465Client
    {
        Task SendAsync(ChatRoom465Message message);
    }

    [ChatRoomClient]
    public class ChatRoom465Client: IChatRoom465Client
    {
        private Guid _sender;

        public ChatRoom465Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom465Message message) => Task.CompletedTask;
    }

    public class ChatRoom466Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom466Client
    {
        Task SendAsync(ChatRoom466Message message);
    }

    [ChatRoomClient]
    public class ChatRoom466Client: IChatRoom466Client
    {
        private Guid _sender;

        public ChatRoom466Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom466Message message) => Task.CompletedTask;
    }

    public class ChatRoom467Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom467Client
    {
        Task SendAsync(ChatRoom467Message message);
    }

    [ChatRoomClient]
    public class ChatRoom467Client: IChatRoom467Client
    {
        private Guid _sender;

        public ChatRoom467Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom467Message message) => Task.CompletedTask;
    }

    public class ChatRoom468Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom468Client
    {
        Task SendAsync(ChatRoom468Message message);
    }

    [ChatRoomClient]
    public class ChatRoom468Client: IChatRoom468Client
    {
        private Guid _sender;

        public ChatRoom468Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom468Message message) => Task.CompletedTask;
    }

    public class ChatRoom469Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom469Client
    {
        Task SendAsync(ChatRoom469Message message);
    }

    [ChatRoomClient]
    public class ChatRoom469Client: IChatRoom469Client
    {
        private Guid _sender;

        public ChatRoom469Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom469Message message) => Task.CompletedTask;
    }

    public class ChatRoom470Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom470Client
    {
        Task SendAsync(ChatRoom470Message message);
    }

    [ChatRoomClient]
    public class ChatRoom470Client: IChatRoom470Client
    {
        private Guid _sender;

        public ChatRoom470Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom470Message message) => Task.CompletedTask;
    }

    public class ChatRoom471Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom471Client
    {
        Task SendAsync(ChatRoom471Message message);
    }

    [ChatRoomClient]
    public class ChatRoom471Client: IChatRoom471Client
    {
        private Guid _sender;

        public ChatRoom471Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom471Message message) => Task.CompletedTask;
    }

    public class ChatRoom472Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom472Client
    {
        Task SendAsync(ChatRoom472Message message);
    }

    [ChatRoomClient]
    public class ChatRoom472Client: IChatRoom472Client
    {
        private Guid _sender;

        public ChatRoom472Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom472Message message) => Task.CompletedTask;
    }

    public class ChatRoom473Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom473Client
    {
        Task SendAsync(ChatRoom473Message message);
    }

    [ChatRoomClient]
    public class ChatRoom473Client: IChatRoom473Client
    {
        private Guid _sender;

        public ChatRoom473Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom473Message message) => Task.CompletedTask;
    }

    public class ChatRoom474Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom474Client
    {
        Task SendAsync(ChatRoom474Message message);
    }

    [ChatRoomClient]
    public class ChatRoom474Client: IChatRoom474Client
    {
        private Guid _sender;

        public ChatRoom474Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom474Message message) => Task.CompletedTask;
    }

    public class ChatRoom475Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom475Client
    {
        Task SendAsync(ChatRoom475Message message);
    }

    [ChatRoomClient]
    public class ChatRoom475Client: IChatRoom475Client
    {
        private Guid _sender;

        public ChatRoom475Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom475Message message) => Task.CompletedTask;
    }

    public class ChatRoom476Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom476Client
    {
        Task SendAsync(ChatRoom476Message message);
    }

    [ChatRoomClient]
    public class ChatRoom476Client: IChatRoom476Client
    {
        private Guid _sender;

        public ChatRoom476Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom476Message message) => Task.CompletedTask;
    }

    public class ChatRoom477Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom477Client
    {
        Task SendAsync(ChatRoom477Message message);
    }

    [ChatRoomClient]
    public class ChatRoom477Client: IChatRoom477Client
    {
        private Guid _sender;

        public ChatRoom477Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom477Message message) => Task.CompletedTask;
    }

    public class ChatRoom478Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom478Client
    {
        Task SendAsync(ChatRoom478Message message);
    }

    [ChatRoomClient]
    public class ChatRoom478Client: IChatRoom478Client
    {
        private Guid _sender;

        public ChatRoom478Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom478Message message) => Task.CompletedTask;
    }

    public class ChatRoom479Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom479Client
    {
        Task SendAsync(ChatRoom479Message message);
    }

    [ChatRoomClient]
    public class ChatRoom479Client: IChatRoom479Client
    {
        private Guid _sender;

        public ChatRoom479Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom479Message message) => Task.CompletedTask;
    }

    public class ChatRoom480Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom480Client
    {
        Task SendAsync(ChatRoom480Message message);
    }

    [ChatRoomClient]
    public class ChatRoom480Client: IChatRoom480Client
    {
        private Guid _sender;

        public ChatRoom480Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom480Message message) => Task.CompletedTask;
    }

    public class ChatRoom481Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom481Client
    {
        Task SendAsync(ChatRoom481Message message);
    }

    [ChatRoomClient]
    public class ChatRoom481Client: IChatRoom481Client
    {
        private Guid _sender;

        public ChatRoom481Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom481Message message) => Task.CompletedTask;
    }

    public class ChatRoom482Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom482Client
    {
        Task SendAsync(ChatRoom482Message message);
    }

    [ChatRoomClient]
    public class ChatRoom482Client: IChatRoom482Client
    {
        private Guid _sender;

        public ChatRoom482Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom482Message message) => Task.CompletedTask;
    }

    public class ChatRoom483Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom483Client
    {
        Task SendAsync(ChatRoom483Message message);
    }

    [ChatRoomClient]
    public class ChatRoom483Client: IChatRoom483Client
    {
        private Guid _sender;

        public ChatRoom483Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom483Message message) => Task.CompletedTask;
    }

    public class ChatRoom484Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom484Client
    {
        Task SendAsync(ChatRoom484Message message);
    }

    [ChatRoomClient]
    public class ChatRoom484Client: IChatRoom484Client
    {
        private Guid _sender;

        public ChatRoom484Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom484Message message) => Task.CompletedTask;
    }

    public class ChatRoom485Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom485Client
    {
        Task SendAsync(ChatRoom485Message message);
    }

    [ChatRoomClient]
    public class ChatRoom485Client: IChatRoom485Client
    {
        private Guid _sender;

        public ChatRoom485Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom485Message message) => Task.CompletedTask;
    }

    public class ChatRoom486Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom486Client
    {
        Task SendAsync(ChatRoom486Message message);
    }

    [ChatRoomClient]
    public class ChatRoom486Client: IChatRoom486Client
    {
        private Guid _sender;

        public ChatRoom486Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom486Message message) => Task.CompletedTask;
    }

    public class ChatRoom487Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom487Client
    {
        Task SendAsync(ChatRoom487Message message);
    }

    [ChatRoomClient]
    public class ChatRoom487Client: IChatRoom487Client
    {
        private Guid _sender;

        public ChatRoom487Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom487Message message) => Task.CompletedTask;
    }

    public class ChatRoom488Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom488Client
    {
        Task SendAsync(ChatRoom488Message message);
    }

    [ChatRoomClient]
    public class ChatRoom488Client: IChatRoom488Client
    {
        private Guid _sender;

        public ChatRoom488Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom488Message message) => Task.CompletedTask;
    }

    public class ChatRoom489Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom489Client
    {
        Task SendAsync(ChatRoom489Message message);
    }

    [ChatRoomClient]
    public class ChatRoom489Client: IChatRoom489Client
    {
        private Guid _sender;

        public ChatRoom489Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom489Message message) => Task.CompletedTask;
    }

    public class ChatRoom490Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom490Client
    {
        Task SendAsync(ChatRoom490Message message);
    }

    [ChatRoomClient]
    public class ChatRoom490Client: IChatRoom490Client
    {
        private Guid _sender;

        public ChatRoom490Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom490Message message) => Task.CompletedTask;
    }

    public class ChatRoom491Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom491Client
    {
        Task SendAsync(ChatRoom491Message message);
    }

    [ChatRoomClient]
    public class ChatRoom491Client: IChatRoom491Client
    {
        private Guid _sender;

        public ChatRoom491Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom491Message message) => Task.CompletedTask;
    }

    public class ChatRoom492Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom492Client
    {
        Task SendAsync(ChatRoom492Message message);
    }

    [ChatRoomClient]
    public class ChatRoom492Client: IChatRoom492Client
    {
        private Guid _sender;

        public ChatRoom492Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom492Message message) => Task.CompletedTask;
    }

    public class ChatRoom493Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom493Client
    {
        Task SendAsync(ChatRoom493Message message);
    }

    [ChatRoomClient]
    public class ChatRoom493Client: IChatRoom493Client
    {
        private Guid _sender;

        public ChatRoom493Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom493Message message) => Task.CompletedTask;
    }

    public class ChatRoom494Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom494Client
    {
        Task SendAsync(ChatRoom494Message message);
    }

    [ChatRoomClient]
    public class ChatRoom494Client: IChatRoom494Client
    {
        private Guid _sender;

        public ChatRoom494Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom494Message message) => Task.CompletedTask;
    }

    public class ChatRoom495Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom495Client
    {
        Task SendAsync(ChatRoom495Message message);
    }

    [ChatRoomClient]
    public class ChatRoom495Client: IChatRoom495Client
    {
        private Guid _sender;

        public ChatRoom495Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom495Message message) => Task.CompletedTask;
    }

    public class ChatRoom496Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom496Client
    {
        Task SendAsync(ChatRoom496Message message);
    }

    [ChatRoomClient]
    public class ChatRoom496Client: IChatRoom496Client
    {
        private Guid _sender;

        public ChatRoom496Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom496Message message) => Task.CompletedTask;
    }

    public class ChatRoom497Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom497Client
    {
        Task SendAsync(ChatRoom497Message message);
    }

    [ChatRoomClient]
    public class ChatRoom497Client: IChatRoom497Client
    {
        private Guid _sender;

        public ChatRoom497Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom497Message message) => Task.CompletedTask;
    }

    public class ChatRoom498Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom498Client
    {
        Task SendAsync(ChatRoom498Message message);
    }

    [ChatRoomClient]
    public class ChatRoom498Client: IChatRoom498Client
    {
        private Guid _sender;

        public ChatRoom498Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom498Message message) => Task.CompletedTask;
    }

    public class ChatRoom499Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom499Client
    {
        Task SendAsync(ChatRoom499Message message);
    }

    [ChatRoomClient]
    public class ChatRoom499Client: IChatRoom499Client
    {
        private Guid _sender;

        public ChatRoom499Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom499Message message) => Task.CompletedTask;
    }

    public class ChatRoom500Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom500Client
    {
        Task SendAsync(ChatRoom500Message message);
    }

    [ChatRoomClient]
    public class ChatRoom500Client: IChatRoom500Client
    {
        private Guid _sender;

        public ChatRoom500Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom500Message message) => Task.CompletedTask;
    }

    public class ChatRoom501Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom501Client
    {
        Task SendAsync(ChatRoom501Message message);
    }

    [ChatRoomClient]
    public class ChatRoom501Client: IChatRoom501Client
    {
        private Guid _sender;

        public ChatRoom501Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom501Message message) => Task.CompletedTask;
    }

    public class ChatRoom502Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom502Client
    {
        Task SendAsync(ChatRoom502Message message);
    }

    [ChatRoomClient]
    public class ChatRoom502Client: IChatRoom502Client
    {
        private Guid _sender;

        public ChatRoom502Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom502Message message) => Task.CompletedTask;
    }

    public class ChatRoom503Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom503Client
    {
        Task SendAsync(ChatRoom503Message message);
    }

    [ChatRoomClient]
    public class ChatRoom503Client: IChatRoom503Client
    {
        private Guid _sender;

        public ChatRoom503Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom503Message message) => Task.CompletedTask;
    }

    public class ChatRoom504Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom504Client
    {
        Task SendAsync(ChatRoom504Message message);
    }

    [ChatRoomClient]
    public class ChatRoom504Client: IChatRoom504Client
    {
        private Guid _sender;

        public ChatRoom504Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom504Message message) => Task.CompletedTask;
    }

    public class ChatRoom505Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom505Client
    {
        Task SendAsync(ChatRoom505Message message);
    }

    [ChatRoomClient]
    public class ChatRoom505Client: IChatRoom505Client
    {
        private Guid _sender;

        public ChatRoom505Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom505Message message) => Task.CompletedTask;
    }

    public class ChatRoom506Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom506Client
    {
        Task SendAsync(ChatRoom506Message message);
    }

    [ChatRoomClient]
    public class ChatRoom506Client: IChatRoom506Client
    {
        private Guid _sender;

        public ChatRoom506Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom506Message message) => Task.CompletedTask;
    }

    public class ChatRoom507Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom507Client
    {
        Task SendAsync(ChatRoom507Message message);
    }

    [ChatRoomClient]
    public class ChatRoom507Client: IChatRoom507Client
    {
        private Guid _sender;

        public ChatRoom507Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom507Message message) => Task.CompletedTask;
    }

    public class ChatRoom508Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom508Client
    {
        Task SendAsync(ChatRoom508Message message);
    }

    [ChatRoomClient]
    public class ChatRoom508Client: IChatRoom508Client
    {
        private Guid _sender;

        public ChatRoom508Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom508Message message) => Task.CompletedTask;
    }

    public class ChatRoom509Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom509Client
    {
        Task SendAsync(ChatRoom509Message message);
    }

    [ChatRoomClient]
    public class ChatRoom509Client: IChatRoom509Client
    {
        private Guid _sender;

        public ChatRoom509Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom509Message message) => Task.CompletedTask;
    }

    public class ChatRoom510Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom510Client
    {
        Task SendAsync(ChatRoom510Message message);
    }

    [ChatRoomClient]
    public class ChatRoom510Client: IChatRoom510Client
    {
        private Guid _sender;

        public ChatRoom510Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom510Message message) => Task.CompletedTask;
    }

    public class ChatRoom511Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom511Client
    {
        Task SendAsync(ChatRoom511Message message);
    }

    [ChatRoomClient]
    public class ChatRoom511Client: IChatRoom511Client
    {
        private Guid _sender;

        public ChatRoom511Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom511Message message) => Task.CompletedTask;
    }

    public class ChatRoom512Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom512Client
    {
        Task SendAsync(ChatRoom512Message message);
    }

    [ChatRoomClient]
    public class ChatRoom512Client: IChatRoom512Client
    {
        private Guid _sender;

        public ChatRoom512Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom512Message message) => Task.CompletedTask;
    }

    public class ChatRoom513Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom513Client
    {
        Task SendAsync(ChatRoom513Message message);
    }

    [ChatRoomClient]
    public class ChatRoom513Client: IChatRoom513Client
    {
        private Guid _sender;

        public ChatRoom513Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom513Message message) => Task.CompletedTask;
    }

    public class ChatRoom514Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom514Client
    {
        Task SendAsync(ChatRoom514Message message);
    }

    [ChatRoomClient]
    public class ChatRoom514Client: IChatRoom514Client
    {
        private Guid _sender;

        public ChatRoom514Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom514Message message) => Task.CompletedTask;
    }

    public class ChatRoom515Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom515Client
    {
        Task SendAsync(ChatRoom515Message message);
    }

    [ChatRoomClient]
    public class ChatRoom515Client: IChatRoom515Client
    {
        private Guid _sender;

        public ChatRoom515Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom515Message message) => Task.CompletedTask;
    }

    public class ChatRoom516Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom516Client
    {
        Task SendAsync(ChatRoom516Message message);
    }

    [ChatRoomClient]
    public class ChatRoom516Client: IChatRoom516Client
    {
        private Guid _sender;

        public ChatRoom516Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom516Message message) => Task.CompletedTask;
    }

    public class ChatRoom517Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom517Client
    {
        Task SendAsync(ChatRoom517Message message);
    }

    [ChatRoomClient]
    public class ChatRoom517Client: IChatRoom517Client
    {
        private Guid _sender;

        public ChatRoom517Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom517Message message) => Task.CompletedTask;
    }

    public class ChatRoom518Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom518Client
    {
        Task SendAsync(ChatRoom518Message message);
    }

    [ChatRoomClient]
    public class ChatRoom518Client: IChatRoom518Client
    {
        private Guid _sender;

        public ChatRoom518Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom518Message message) => Task.CompletedTask;
    }

    public class ChatRoom519Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom519Client
    {
        Task SendAsync(ChatRoom519Message message);
    }

    [ChatRoomClient]
    public class ChatRoom519Client: IChatRoom519Client
    {
        private Guid _sender;

        public ChatRoom519Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom519Message message) => Task.CompletedTask;
    }

    public class ChatRoom520Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom520Client
    {
        Task SendAsync(ChatRoom520Message message);
    }

    [ChatRoomClient]
    public class ChatRoom520Client: IChatRoom520Client
    {
        private Guid _sender;

        public ChatRoom520Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom520Message message) => Task.CompletedTask;
    }

    public class ChatRoom521Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom521Client
    {
        Task SendAsync(ChatRoom521Message message);
    }

    [ChatRoomClient]
    public class ChatRoom521Client: IChatRoom521Client
    {
        private Guid _sender;

        public ChatRoom521Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom521Message message) => Task.CompletedTask;
    }

    public class ChatRoom522Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom522Client
    {
        Task SendAsync(ChatRoom522Message message);
    }

    [ChatRoomClient]
    public class ChatRoom522Client: IChatRoom522Client
    {
        private Guid _sender;

        public ChatRoom522Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom522Message message) => Task.CompletedTask;
    }

    public class ChatRoom523Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom523Client
    {
        Task SendAsync(ChatRoom523Message message);
    }

    [ChatRoomClient]
    public class ChatRoom523Client: IChatRoom523Client
    {
        private Guid _sender;

        public ChatRoom523Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom523Message message) => Task.CompletedTask;
    }

    public class ChatRoom524Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom524Client
    {
        Task SendAsync(ChatRoom524Message message);
    }

    [ChatRoomClient]
    public class ChatRoom524Client: IChatRoom524Client
    {
        private Guid _sender;

        public ChatRoom524Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom524Message message) => Task.CompletedTask;
    }

    public class ChatRoom525Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom525Client
    {
        Task SendAsync(ChatRoom525Message message);
    }

    [ChatRoomClient]
    public class ChatRoom525Client: IChatRoom525Client
    {
        private Guid _sender;

        public ChatRoom525Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom525Message message) => Task.CompletedTask;
    }

    public class ChatRoom526Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom526Client
    {
        Task SendAsync(ChatRoom526Message message);
    }

    [ChatRoomClient]
    public class ChatRoom526Client: IChatRoom526Client
    {
        private Guid _sender;

        public ChatRoom526Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom526Message message) => Task.CompletedTask;
    }

    public class ChatRoom527Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom527Client
    {
        Task SendAsync(ChatRoom527Message message);
    }

    [ChatRoomClient]
    public class ChatRoom527Client: IChatRoom527Client
    {
        private Guid _sender;

        public ChatRoom527Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom527Message message) => Task.CompletedTask;
    }

    public class ChatRoom528Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom528Client
    {
        Task SendAsync(ChatRoom528Message message);
    }

    [ChatRoomClient]
    public class ChatRoom528Client: IChatRoom528Client
    {
        private Guid _sender;

        public ChatRoom528Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom528Message message) => Task.CompletedTask;
    }

    public class ChatRoom529Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom529Client
    {
        Task SendAsync(ChatRoom529Message message);
    }

    [ChatRoomClient]
    public class ChatRoom529Client: IChatRoom529Client
    {
        private Guid _sender;

        public ChatRoom529Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom529Message message) => Task.CompletedTask;
    }

    public class ChatRoom530Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom530Client
    {
        Task SendAsync(ChatRoom530Message message);
    }

    [ChatRoomClient]
    public class ChatRoom530Client: IChatRoom530Client
    {
        private Guid _sender;

        public ChatRoom530Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom530Message message) => Task.CompletedTask;
    }

    public class ChatRoom531Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom531Client
    {
        Task SendAsync(ChatRoom531Message message);
    }

    [ChatRoomClient]
    public class ChatRoom531Client: IChatRoom531Client
    {
        private Guid _sender;

        public ChatRoom531Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom531Message message) => Task.CompletedTask;
    }

    public class ChatRoom532Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom532Client
    {
        Task SendAsync(ChatRoom532Message message);
    }

    [ChatRoomClient]
    public class ChatRoom532Client: IChatRoom532Client
    {
        private Guid _sender;

        public ChatRoom532Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom532Message message) => Task.CompletedTask;
    }

    public class ChatRoom533Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom533Client
    {
        Task SendAsync(ChatRoom533Message message);
    }

    [ChatRoomClient]
    public class ChatRoom533Client: IChatRoom533Client
    {
        private Guid _sender;

        public ChatRoom533Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom533Message message) => Task.CompletedTask;
    }

    public class ChatRoom534Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom534Client
    {
        Task SendAsync(ChatRoom534Message message);
    }

    [ChatRoomClient]
    public class ChatRoom534Client: IChatRoom534Client
    {
        private Guid _sender;

        public ChatRoom534Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom534Message message) => Task.CompletedTask;
    }

    public class ChatRoom535Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom535Client
    {
        Task SendAsync(ChatRoom535Message message);
    }

    [ChatRoomClient]
    public class ChatRoom535Client: IChatRoom535Client
    {
        private Guid _sender;

        public ChatRoom535Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom535Message message) => Task.CompletedTask;
    }

    public class ChatRoom536Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom536Client
    {
        Task SendAsync(ChatRoom536Message message);
    }

    [ChatRoomClient]
    public class ChatRoom536Client: IChatRoom536Client
    {
        private Guid _sender;

        public ChatRoom536Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom536Message message) => Task.CompletedTask;
    }

    public class ChatRoom537Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom537Client
    {
        Task SendAsync(ChatRoom537Message message);
    }

    [ChatRoomClient]
    public class ChatRoom537Client: IChatRoom537Client
    {
        private Guid _sender;

        public ChatRoom537Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom537Message message) => Task.CompletedTask;
    }

    public class ChatRoom538Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom538Client
    {
        Task SendAsync(ChatRoom538Message message);
    }

    [ChatRoomClient]
    public class ChatRoom538Client: IChatRoom538Client
    {
        private Guid _sender;

        public ChatRoom538Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom538Message message) => Task.CompletedTask;
    }

    public class ChatRoom539Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom539Client
    {
        Task SendAsync(ChatRoom539Message message);
    }

    [ChatRoomClient]
    public class ChatRoom539Client: IChatRoom539Client
    {
        private Guid _sender;

        public ChatRoom539Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom539Message message) => Task.CompletedTask;
    }

    public class ChatRoom540Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom540Client
    {
        Task SendAsync(ChatRoom540Message message);
    }

    [ChatRoomClient]
    public class ChatRoom540Client: IChatRoom540Client
    {
        private Guid _sender;

        public ChatRoom540Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom540Message message) => Task.CompletedTask;
    }

    public class ChatRoom541Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom541Client
    {
        Task SendAsync(ChatRoom541Message message);
    }

    [ChatRoomClient]
    public class ChatRoom541Client: IChatRoom541Client
    {
        private Guid _sender;

        public ChatRoom541Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom541Message message) => Task.CompletedTask;
    }

    public class ChatRoom542Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom542Client
    {
        Task SendAsync(ChatRoom542Message message);
    }

    [ChatRoomClient]
    public class ChatRoom542Client: IChatRoom542Client
    {
        private Guid _sender;

        public ChatRoom542Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom542Message message) => Task.CompletedTask;
    }

    public class ChatRoom543Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom543Client
    {
        Task SendAsync(ChatRoom543Message message);
    }

    [ChatRoomClient]
    public class ChatRoom543Client: IChatRoom543Client
    {
        private Guid _sender;

        public ChatRoom543Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom543Message message) => Task.CompletedTask;
    }

    public class ChatRoom544Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom544Client
    {
        Task SendAsync(ChatRoom544Message message);
    }

    [ChatRoomClient]
    public class ChatRoom544Client: IChatRoom544Client
    {
        private Guid _sender;

        public ChatRoom544Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom544Message message) => Task.CompletedTask;
    }

    public class ChatRoom545Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom545Client
    {
        Task SendAsync(ChatRoom545Message message);
    }

    [ChatRoomClient]
    public class ChatRoom545Client: IChatRoom545Client
    {
        private Guid _sender;

        public ChatRoom545Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom545Message message) => Task.CompletedTask;
    }

    public class ChatRoom546Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom546Client
    {
        Task SendAsync(ChatRoom546Message message);
    }

    [ChatRoomClient]
    public class ChatRoom546Client: IChatRoom546Client
    {
        private Guid _sender;

        public ChatRoom546Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom546Message message) => Task.CompletedTask;
    }

    public class ChatRoom547Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom547Client
    {
        Task SendAsync(ChatRoom547Message message);
    }

    [ChatRoomClient]
    public class ChatRoom547Client: IChatRoom547Client
    {
        private Guid _sender;

        public ChatRoom547Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom547Message message) => Task.CompletedTask;
    }

    public class ChatRoom548Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom548Client
    {
        Task SendAsync(ChatRoom548Message message);
    }

    [ChatRoomClient]
    public class ChatRoom548Client: IChatRoom548Client
    {
        private Guid _sender;

        public ChatRoom548Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom548Message message) => Task.CompletedTask;
    }

    public class ChatRoom549Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom549Client
    {
        Task SendAsync(ChatRoom549Message message);
    }

    [ChatRoomClient]
    public class ChatRoom549Client: IChatRoom549Client
    {
        private Guid _sender;

        public ChatRoom549Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom549Message message) => Task.CompletedTask;
    }

    public class ChatRoom550Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom550Client
    {
        Task SendAsync(ChatRoom550Message message);
    }

    [ChatRoomClient]
    public class ChatRoom550Client: IChatRoom550Client
    {
        private Guid _sender;

        public ChatRoom550Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom550Message message) => Task.CompletedTask;
    }

    public class ChatRoom551Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom551Client
    {
        Task SendAsync(ChatRoom551Message message);
    }

    [ChatRoomClient]
    public class ChatRoom551Client: IChatRoom551Client
    {
        private Guid _sender;

        public ChatRoom551Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom551Message message) => Task.CompletedTask;
    }

    public class ChatRoom552Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom552Client
    {
        Task SendAsync(ChatRoom552Message message);
    }

    [ChatRoomClient]
    public class ChatRoom552Client: IChatRoom552Client
    {
        private Guid _sender;

        public ChatRoom552Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom552Message message) => Task.CompletedTask;
    }

    public class ChatRoom553Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom553Client
    {
        Task SendAsync(ChatRoom553Message message);
    }

    [ChatRoomClient]
    public class ChatRoom553Client: IChatRoom553Client
    {
        private Guid _sender;

        public ChatRoom553Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom553Message message) => Task.CompletedTask;
    }

    public class ChatRoom554Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom554Client
    {
        Task SendAsync(ChatRoom554Message message);
    }

    [ChatRoomClient]
    public class ChatRoom554Client: IChatRoom554Client
    {
        private Guid _sender;

        public ChatRoom554Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom554Message message) => Task.CompletedTask;
    }

    public class ChatRoom555Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom555Client
    {
        Task SendAsync(ChatRoom555Message message);
    }

    [ChatRoomClient]
    public class ChatRoom555Client: IChatRoom555Client
    {
        private Guid _sender;

        public ChatRoom555Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom555Message message) => Task.CompletedTask;
    }

    public class ChatRoom556Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom556Client
    {
        Task SendAsync(ChatRoom556Message message);
    }

    [ChatRoomClient]
    public class ChatRoom556Client: IChatRoom556Client
    {
        private Guid _sender;

        public ChatRoom556Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom556Message message) => Task.CompletedTask;
    }

    public class ChatRoom557Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom557Client
    {
        Task SendAsync(ChatRoom557Message message);
    }

    [ChatRoomClient]
    public class ChatRoom557Client: IChatRoom557Client
    {
        private Guid _sender;

        public ChatRoom557Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom557Message message) => Task.CompletedTask;
    }

    public class ChatRoom558Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom558Client
    {
        Task SendAsync(ChatRoom558Message message);
    }

    [ChatRoomClient]
    public class ChatRoom558Client: IChatRoom558Client
    {
        private Guid _sender;

        public ChatRoom558Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom558Message message) => Task.CompletedTask;
    }

    public class ChatRoom559Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom559Client
    {
        Task SendAsync(ChatRoom559Message message);
    }

    [ChatRoomClient]
    public class ChatRoom559Client: IChatRoom559Client
    {
        private Guid _sender;

        public ChatRoom559Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom559Message message) => Task.CompletedTask;
    }

    public class ChatRoom560Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom560Client
    {
        Task SendAsync(ChatRoom560Message message);
    }

    [ChatRoomClient]
    public class ChatRoom560Client: IChatRoom560Client
    {
        private Guid _sender;

        public ChatRoom560Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom560Message message) => Task.CompletedTask;
    }

    public class ChatRoom561Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom561Client
    {
        Task SendAsync(ChatRoom561Message message);
    }

    [ChatRoomClient]
    public class ChatRoom561Client: IChatRoom561Client
    {
        private Guid _sender;

        public ChatRoom561Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom561Message message) => Task.CompletedTask;
    }

    public class ChatRoom562Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom562Client
    {
        Task SendAsync(ChatRoom562Message message);
    }

    [ChatRoomClient]
    public class ChatRoom562Client: IChatRoom562Client
    {
        private Guid _sender;

        public ChatRoom562Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom562Message message) => Task.CompletedTask;
    }

    public class ChatRoom563Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom563Client
    {
        Task SendAsync(ChatRoom563Message message);
    }

    [ChatRoomClient]
    public class ChatRoom563Client: IChatRoom563Client
    {
        private Guid _sender;

        public ChatRoom563Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom563Message message) => Task.CompletedTask;
    }

    public class ChatRoom564Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom564Client
    {
        Task SendAsync(ChatRoom564Message message);
    }

    [ChatRoomClient]
    public class ChatRoom564Client: IChatRoom564Client
    {
        private Guid _sender;

        public ChatRoom564Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom564Message message) => Task.CompletedTask;
    }

    public class ChatRoom565Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom565Client
    {
        Task SendAsync(ChatRoom565Message message);
    }

    [ChatRoomClient]
    public class ChatRoom565Client: IChatRoom565Client
    {
        private Guid _sender;

        public ChatRoom565Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom565Message message) => Task.CompletedTask;
    }

    public class ChatRoom566Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom566Client
    {
        Task SendAsync(ChatRoom566Message message);
    }

    [ChatRoomClient]
    public class ChatRoom566Client: IChatRoom566Client
    {
        private Guid _sender;

        public ChatRoom566Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom566Message message) => Task.CompletedTask;
    }

    public class ChatRoom567Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom567Client
    {
        Task SendAsync(ChatRoom567Message message);
    }

    [ChatRoomClient]
    public class ChatRoom567Client: IChatRoom567Client
    {
        private Guid _sender;

        public ChatRoom567Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom567Message message) => Task.CompletedTask;
    }

    public class ChatRoom568Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom568Client
    {
        Task SendAsync(ChatRoom568Message message);
    }

    [ChatRoomClient]
    public class ChatRoom568Client: IChatRoom568Client
    {
        private Guid _sender;

        public ChatRoom568Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom568Message message) => Task.CompletedTask;
    }

    public class ChatRoom569Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom569Client
    {
        Task SendAsync(ChatRoom569Message message);
    }

    [ChatRoomClient]
    public class ChatRoom569Client: IChatRoom569Client
    {
        private Guid _sender;

        public ChatRoom569Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom569Message message) => Task.CompletedTask;
    }

    public class ChatRoom570Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom570Client
    {
        Task SendAsync(ChatRoom570Message message);
    }

    [ChatRoomClient]
    public class ChatRoom570Client: IChatRoom570Client
    {
        private Guid _sender;

        public ChatRoom570Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom570Message message) => Task.CompletedTask;
    }

    public class ChatRoom571Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom571Client
    {
        Task SendAsync(ChatRoom571Message message);
    }

    [ChatRoomClient]
    public class ChatRoom571Client: IChatRoom571Client
    {
        private Guid _sender;

        public ChatRoom571Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom571Message message) => Task.CompletedTask;
    }

    public class ChatRoom572Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom572Client
    {
        Task SendAsync(ChatRoom572Message message);
    }

    [ChatRoomClient]
    public class ChatRoom572Client: IChatRoom572Client
    {
        private Guid _sender;

        public ChatRoom572Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom572Message message) => Task.CompletedTask;
    }

    public class ChatRoom573Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom573Client
    {
        Task SendAsync(ChatRoom573Message message);
    }

    [ChatRoomClient]
    public class ChatRoom573Client: IChatRoom573Client
    {
        private Guid _sender;

        public ChatRoom573Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom573Message message) => Task.CompletedTask;
    }

    public class ChatRoom574Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom574Client
    {
        Task SendAsync(ChatRoom574Message message);
    }

    [ChatRoomClient]
    public class ChatRoom574Client: IChatRoom574Client
    {
        private Guid _sender;

        public ChatRoom574Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom574Message message) => Task.CompletedTask;
    }

    public class ChatRoom575Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom575Client
    {
        Task SendAsync(ChatRoom575Message message);
    }

    [ChatRoomClient]
    public class ChatRoom575Client: IChatRoom575Client
    {
        private Guid _sender;

        public ChatRoom575Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom575Message message) => Task.CompletedTask;
    }

    public class ChatRoom576Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom576Client
    {
        Task SendAsync(ChatRoom576Message message);
    }

    [ChatRoomClient]
    public class ChatRoom576Client: IChatRoom576Client
    {
        private Guid _sender;

        public ChatRoom576Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom576Message message) => Task.CompletedTask;
    }

    public class ChatRoom577Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom577Client
    {
        Task SendAsync(ChatRoom577Message message);
    }

    [ChatRoomClient]
    public class ChatRoom577Client: IChatRoom577Client
    {
        private Guid _sender;

        public ChatRoom577Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom577Message message) => Task.CompletedTask;
    }

    public class ChatRoom578Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom578Client
    {
        Task SendAsync(ChatRoom578Message message);
    }

    [ChatRoomClient]
    public class ChatRoom578Client: IChatRoom578Client
    {
        private Guid _sender;

        public ChatRoom578Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom578Message message) => Task.CompletedTask;
    }

    public class ChatRoom579Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom579Client
    {
        Task SendAsync(ChatRoom579Message message);
    }

    [ChatRoomClient]
    public class ChatRoom579Client: IChatRoom579Client
    {
        private Guid _sender;

        public ChatRoom579Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom579Message message) => Task.CompletedTask;
    }

    public class ChatRoom580Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom580Client
    {
        Task SendAsync(ChatRoom580Message message);
    }

    [ChatRoomClient]
    public class ChatRoom580Client: IChatRoom580Client
    {
        private Guid _sender;

        public ChatRoom580Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom580Message message) => Task.CompletedTask;
    }

    public class ChatRoom581Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom581Client
    {
        Task SendAsync(ChatRoom581Message message);
    }

    [ChatRoomClient]
    public class ChatRoom581Client: IChatRoom581Client
    {
        private Guid _sender;

        public ChatRoom581Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom581Message message) => Task.CompletedTask;
    }

    public class ChatRoom582Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom582Client
    {
        Task SendAsync(ChatRoom582Message message);
    }

    [ChatRoomClient]
    public class ChatRoom582Client: IChatRoom582Client
    {
        private Guid _sender;

        public ChatRoom582Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom582Message message) => Task.CompletedTask;
    }

    public class ChatRoom583Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom583Client
    {
        Task SendAsync(ChatRoom583Message message);
    }

    [ChatRoomClient]
    public class ChatRoom583Client: IChatRoom583Client
    {
        private Guid _sender;

        public ChatRoom583Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom583Message message) => Task.CompletedTask;
    }

    public class ChatRoom584Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom584Client
    {
        Task SendAsync(ChatRoom584Message message);
    }

    [ChatRoomClient]
    public class ChatRoom584Client: IChatRoom584Client
    {
        private Guid _sender;

        public ChatRoom584Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom584Message message) => Task.CompletedTask;
    }

    public class ChatRoom585Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom585Client
    {
        Task SendAsync(ChatRoom585Message message);
    }

    [ChatRoomClient]
    public class ChatRoom585Client: IChatRoom585Client
    {
        private Guid _sender;

        public ChatRoom585Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom585Message message) => Task.CompletedTask;
    }

    public class ChatRoom586Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom586Client
    {
        Task SendAsync(ChatRoom586Message message);
    }

    [ChatRoomClient]
    public class ChatRoom586Client: IChatRoom586Client
    {
        private Guid _sender;

        public ChatRoom586Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom586Message message) => Task.CompletedTask;
    }

    public class ChatRoom587Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom587Client
    {
        Task SendAsync(ChatRoom587Message message);
    }

    [ChatRoomClient]
    public class ChatRoom587Client: IChatRoom587Client
    {
        private Guid _sender;

        public ChatRoom587Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom587Message message) => Task.CompletedTask;
    }

    public class ChatRoom588Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom588Client
    {
        Task SendAsync(ChatRoom588Message message);
    }

    [ChatRoomClient]
    public class ChatRoom588Client: IChatRoom588Client
    {
        private Guid _sender;

        public ChatRoom588Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom588Message message) => Task.CompletedTask;
    }

    public class ChatRoom589Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom589Client
    {
        Task SendAsync(ChatRoom589Message message);
    }

    [ChatRoomClient]
    public class ChatRoom589Client: IChatRoom589Client
    {
        private Guid _sender;

        public ChatRoom589Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom589Message message) => Task.CompletedTask;
    }

    public class ChatRoom590Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom590Client
    {
        Task SendAsync(ChatRoom590Message message);
    }

    [ChatRoomClient]
    public class ChatRoom590Client: IChatRoom590Client
    {
        private Guid _sender;

        public ChatRoom590Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom590Message message) => Task.CompletedTask;
    }

    public class ChatRoom591Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom591Client
    {
        Task SendAsync(ChatRoom591Message message);
    }

    [ChatRoomClient]
    public class ChatRoom591Client: IChatRoom591Client
    {
        private Guid _sender;

        public ChatRoom591Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom591Message message) => Task.CompletedTask;
    }

    public class ChatRoom592Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom592Client
    {
        Task SendAsync(ChatRoom592Message message);
    }

    [ChatRoomClient]
    public class ChatRoom592Client: IChatRoom592Client
    {
        private Guid _sender;

        public ChatRoom592Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom592Message message) => Task.CompletedTask;
    }

    public class ChatRoom593Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom593Client
    {
        Task SendAsync(ChatRoom593Message message);
    }

    [ChatRoomClient]
    public class ChatRoom593Client: IChatRoom593Client
    {
        private Guid _sender;

        public ChatRoom593Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom593Message message) => Task.CompletedTask;
    }

    public class ChatRoom594Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom594Client
    {
        Task SendAsync(ChatRoom594Message message);
    }

    [ChatRoomClient]
    public class ChatRoom594Client: IChatRoom594Client
    {
        private Guid _sender;

        public ChatRoom594Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom594Message message) => Task.CompletedTask;
    }

    public class ChatRoom595Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom595Client
    {
        Task SendAsync(ChatRoom595Message message);
    }

    [ChatRoomClient]
    public class ChatRoom595Client: IChatRoom595Client
    {
        private Guid _sender;

        public ChatRoom595Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom595Message message) => Task.CompletedTask;
    }

    public class ChatRoom596Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom596Client
    {
        Task SendAsync(ChatRoom596Message message);
    }

    [ChatRoomClient]
    public class ChatRoom596Client: IChatRoom596Client
    {
        private Guid _sender;

        public ChatRoom596Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom596Message message) => Task.CompletedTask;
    }

    public class ChatRoom597Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom597Client
    {
        Task SendAsync(ChatRoom597Message message);
    }

    [ChatRoomClient]
    public class ChatRoom597Client: IChatRoom597Client
    {
        private Guid _sender;

        public ChatRoom597Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom597Message message) => Task.CompletedTask;
    }

    public class ChatRoom598Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom598Client
    {
        Task SendAsync(ChatRoom598Message message);
    }

    [ChatRoomClient]
    public class ChatRoom598Client: IChatRoom598Client
    {
        private Guid _sender;

        public ChatRoom598Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom598Message message) => Task.CompletedTask;
    }

    public class ChatRoom599Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom599Client
    {
        Task SendAsync(ChatRoom599Message message);
    }

    [ChatRoomClient]
    public class ChatRoom599Client: IChatRoom599Client
    {
        private Guid _sender;

        public ChatRoom599Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom599Message message) => Task.CompletedTask;
    }

    public class ChatRoom600Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom600Client
    {
        Task SendAsync(ChatRoom600Message message);
    }

    [ChatRoomClient]
    public class ChatRoom600Client: IChatRoom600Client
    {
        private Guid _sender;

        public ChatRoom600Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom600Message message) => Task.CompletedTask;
    }

    public class ChatRoom601Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom601Client
    {
        Task SendAsync(ChatRoom601Message message);
    }

    [ChatRoomClient]
    public class ChatRoom601Client: IChatRoom601Client
    {
        private Guid _sender;

        public ChatRoom601Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom601Message message) => Task.CompletedTask;
    }

    public class ChatRoom602Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom602Client
    {
        Task SendAsync(ChatRoom602Message message);
    }

    [ChatRoomClient]
    public class ChatRoom602Client: IChatRoom602Client
    {
        private Guid _sender;

        public ChatRoom602Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom602Message message) => Task.CompletedTask;
    }

    public class ChatRoom603Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom603Client
    {
        Task SendAsync(ChatRoom603Message message);
    }

    [ChatRoomClient]
    public class ChatRoom603Client: IChatRoom603Client
    {
        private Guid _sender;

        public ChatRoom603Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom603Message message) => Task.CompletedTask;
    }

    public class ChatRoom604Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom604Client
    {
        Task SendAsync(ChatRoom604Message message);
    }

    [ChatRoomClient]
    public class ChatRoom604Client: IChatRoom604Client
    {
        private Guid _sender;

        public ChatRoom604Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom604Message message) => Task.CompletedTask;
    }

    public class ChatRoom605Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom605Client
    {
        Task SendAsync(ChatRoom605Message message);
    }

    [ChatRoomClient]
    public class ChatRoom605Client: IChatRoom605Client
    {
        private Guid _sender;

        public ChatRoom605Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom605Message message) => Task.CompletedTask;
    }

    public class ChatRoom606Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom606Client
    {
        Task SendAsync(ChatRoom606Message message);
    }

    [ChatRoomClient]
    public class ChatRoom606Client: IChatRoom606Client
    {
        private Guid _sender;

        public ChatRoom606Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom606Message message) => Task.CompletedTask;
    }

    public class ChatRoom607Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom607Client
    {
        Task SendAsync(ChatRoom607Message message);
    }

    [ChatRoomClient]
    public class ChatRoom607Client: IChatRoom607Client
    {
        private Guid _sender;

        public ChatRoom607Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom607Message message) => Task.CompletedTask;
    }

    public class ChatRoom608Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom608Client
    {
        Task SendAsync(ChatRoom608Message message);
    }

    [ChatRoomClient]
    public class ChatRoom608Client: IChatRoom608Client
    {
        private Guid _sender;

        public ChatRoom608Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom608Message message) => Task.CompletedTask;
    }

    public class ChatRoom609Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom609Client
    {
        Task SendAsync(ChatRoom609Message message);
    }

    [ChatRoomClient]
    public class ChatRoom609Client: IChatRoom609Client
    {
        private Guid _sender;

        public ChatRoom609Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom609Message message) => Task.CompletedTask;
    }

    public class ChatRoom610Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom610Client
    {
        Task SendAsync(ChatRoom610Message message);
    }

    [ChatRoomClient]
    public class ChatRoom610Client: IChatRoom610Client
    {
        private Guid _sender;

        public ChatRoom610Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom610Message message) => Task.CompletedTask;
    }

    public class ChatRoom611Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom611Client
    {
        Task SendAsync(ChatRoom611Message message);
    }

    [ChatRoomClient]
    public class ChatRoom611Client: IChatRoom611Client
    {
        private Guid _sender;

        public ChatRoom611Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom611Message message) => Task.CompletedTask;
    }

    public class ChatRoom612Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom612Client
    {
        Task SendAsync(ChatRoom612Message message);
    }

    [ChatRoomClient]
    public class ChatRoom612Client: IChatRoom612Client
    {
        private Guid _sender;

        public ChatRoom612Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom612Message message) => Task.CompletedTask;
    }

    public class ChatRoom613Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom613Client
    {
        Task SendAsync(ChatRoom613Message message);
    }

    [ChatRoomClient]
    public class ChatRoom613Client: IChatRoom613Client
    {
        private Guid _sender;

        public ChatRoom613Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom613Message message) => Task.CompletedTask;
    }

    public class ChatRoom614Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom614Client
    {
        Task SendAsync(ChatRoom614Message message);
    }

    [ChatRoomClient]
    public class ChatRoom614Client: IChatRoom614Client
    {
        private Guid _sender;

        public ChatRoom614Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom614Message message) => Task.CompletedTask;
    }

    public class ChatRoom615Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom615Client
    {
        Task SendAsync(ChatRoom615Message message);
    }

    [ChatRoomClient]
    public class ChatRoom615Client: IChatRoom615Client
    {
        private Guid _sender;

        public ChatRoom615Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom615Message message) => Task.CompletedTask;
    }

    public class ChatRoom616Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom616Client
    {
        Task SendAsync(ChatRoom616Message message);
    }

    [ChatRoomClient]
    public class ChatRoom616Client: IChatRoom616Client
    {
        private Guid _sender;

        public ChatRoom616Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom616Message message) => Task.CompletedTask;
    }

    public class ChatRoom617Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom617Client
    {
        Task SendAsync(ChatRoom617Message message);
    }

    [ChatRoomClient]
    public class ChatRoom617Client: IChatRoom617Client
    {
        private Guid _sender;

        public ChatRoom617Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom617Message message) => Task.CompletedTask;
    }

    public class ChatRoom618Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom618Client
    {
        Task SendAsync(ChatRoom618Message message);
    }

    [ChatRoomClient]
    public class ChatRoom618Client: IChatRoom618Client
    {
        private Guid _sender;

        public ChatRoom618Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom618Message message) => Task.CompletedTask;
    }

    public class ChatRoom619Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom619Client
    {
        Task SendAsync(ChatRoom619Message message);
    }

    [ChatRoomClient]
    public class ChatRoom619Client: IChatRoom619Client
    {
        private Guid _sender;

        public ChatRoom619Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom619Message message) => Task.CompletedTask;
    }

    public class ChatRoom620Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom620Client
    {
        Task SendAsync(ChatRoom620Message message);
    }

    [ChatRoomClient]
    public class ChatRoom620Client: IChatRoom620Client
    {
        private Guid _sender;

        public ChatRoom620Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom620Message message) => Task.CompletedTask;
    }

    public class ChatRoom621Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom621Client
    {
        Task SendAsync(ChatRoom621Message message);
    }

    [ChatRoomClient]
    public class ChatRoom621Client: IChatRoom621Client
    {
        private Guid _sender;

        public ChatRoom621Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom621Message message) => Task.CompletedTask;
    }

    public class ChatRoom622Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom622Client
    {
        Task SendAsync(ChatRoom622Message message);
    }

    [ChatRoomClient]
    public class ChatRoom622Client: IChatRoom622Client
    {
        private Guid _sender;

        public ChatRoom622Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom622Message message) => Task.CompletedTask;
    }

    public class ChatRoom623Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom623Client
    {
        Task SendAsync(ChatRoom623Message message);
    }

    [ChatRoomClient]
    public class ChatRoom623Client: IChatRoom623Client
    {
        private Guid _sender;

        public ChatRoom623Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom623Message message) => Task.CompletedTask;
    }

    public class ChatRoom624Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom624Client
    {
        Task SendAsync(ChatRoom624Message message);
    }

    [ChatRoomClient]
    public class ChatRoom624Client: IChatRoom624Client
    {
        private Guid _sender;

        public ChatRoom624Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom624Message message) => Task.CompletedTask;
    }

    public class ChatRoom625Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom625Client
    {
        Task SendAsync(ChatRoom625Message message);
    }

    [ChatRoomClient]
    public class ChatRoom625Client: IChatRoom625Client
    {
        private Guid _sender;

        public ChatRoom625Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom625Message message) => Task.CompletedTask;
    }

    public class ChatRoom626Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom626Client
    {
        Task SendAsync(ChatRoom626Message message);
    }

    [ChatRoomClient]
    public class ChatRoom626Client: IChatRoom626Client
    {
        private Guid _sender;

        public ChatRoom626Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom626Message message) => Task.CompletedTask;
    }

    public class ChatRoom627Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom627Client
    {
        Task SendAsync(ChatRoom627Message message);
    }

    [ChatRoomClient]
    public class ChatRoom627Client: IChatRoom627Client
    {
        private Guid _sender;

        public ChatRoom627Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom627Message message) => Task.CompletedTask;
    }

    public class ChatRoom628Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom628Client
    {
        Task SendAsync(ChatRoom628Message message);
    }

    [ChatRoomClient]
    public class ChatRoom628Client: IChatRoom628Client
    {
        private Guid _sender;

        public ChatRoom628Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom628Message message) => Task.CompletedTask;
    }

    public class ChatRoom629Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom629Client
    {
        Task SendAsync(ChatRoom629Message message);
    }

    [ChatRoomClient]
    public class ChatRoom629Client: IChatRoom629Client
    {
        private Guid _sender;

        public ChatRoom629Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom629Message message) => Task.CompletedTask;
    }

    public class ChatRoom630Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom630Client
    {
        Task SendAsync(ChatRoom630Message message);
    }

    [ChatRoomClient]
    public class ChatRoom630Client: IChatRoom630Client
    {
        private Guid _sender;

        public ChatRoom630Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom630Message message) => Task.CompletedTask;
    }

    public class ChatRoom631Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom631Client
    {
        Task SendAsync(ChatRoom631Message message);
    }

    [ChatRoomClient]
    public class ChatRoom631Client: IChatRoom631Client
    {
        private Guid _sender;

        public ChatRoom631Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom631Message message) => Task.CompletedTask;
    }

    public class ChatRoom632Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom632Client
    {
        Task SendAsync(ChatRoom632Message message);
    }

    [ChatRoomClient]
    public class ChatRoom632Client: IChatRoom632Client
    {
        private Guid _sender;

        public ChatRoom632Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom632Message message) => Task.CompletedTask;
    }

    public class ChatRoom633Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom633Client
    {
        Task SendAsync(ChatRoom633Message message);
    }

    [ChatRoomClient]
    public class ChatRoom633Client: IChatRoom633Client
    {
        private Guid _sender;

        public ChatRoom633Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom633Message message) => Task.CompletedTask;
    }

    public class ChatRoom634Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom634Client
    {
        Task SendAsync(ChatRoom634Message message);
    }

    [ChatRoomClient]
    public class ChatRoom634Client: IChatRoom634Client
    {
        private Guid _sender;

        public ChatRoom634Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom634Message message) => Task.CompletedTask;
    }

    public class ChatRoom635Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom635Client
    {
        Task SendAsync(ChatRoom635Message message);
    }

    [ChatRoomClient]
    public class ChatRoom635Client: IChatRoom635Client
    {
        private Guid _sender;

        public ChatRoom635Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom635Message message) => Task.CompletedTask;
    }

    public class ChatRoom636Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom636Client
    {
        Task SendAsync(ChatRoom636Message message);
    }

    [ChatRoomClient]
    public class ChatRoom636Client: IChatRoom636Client
    {
        private Guid _sender;

        public ChatRoom636Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom636Message message) => Task.CompletedTask;
    }

    public class ChatRoom637Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom637Client
    {
        Task SendAsync(ChatRoom637Message message);
    }

    [ChatRoomClient]
    public class ChatRoom637Client: IChatRoom637Client
    {
        private Guid _sender;

        public ChatRoom637Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom637Message message) => Task.CompletedTask;
    }

    public class ChatRoom638Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom638Client
    {
        Task SendAsync(ChatRoom638Message message);
    }

    [ChatRoomClient]
    public class ChatRoom638Client: IChatRoom638Client
    {
        private Guid _sender;

        public ChatRoom638Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom638Message message) => Task.CompletedTask;
    }

    public class ChatRoom639Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom639Client
    {
        Task SendAsync(ChatRoom639Message message);
    }

    [ChatRoomClient]
    public class ChatRoom639Client: IChatRoom639Client
    {
        private Guid _sender;

        public ChatRoom639Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom639Message message) => Task.CompletedTask;
    }

    public class ChatRoom640Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom640Client
    {
        Task SendAsync(ChatRoom640Message message);
    }

    [ChatRoomClient]
    public class ChatRoom640Client: IChatRoom640Client
    {
        private Guid _sender;

        public ChatRoom640Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom640Message message) => Task.CompletedTask;
    }

    public class ChatRoom641Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom641Client
    {
        Task SendAsync(ChatRoom641Message message);
    }

    [ChatRoomClient]
    public class ChatRoom641Client: IChatRoom641Client
    {
        private Guid _sender;

        public ChatRoom641Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom641Message message) => Task.CompletedTask;
    }

    public class ChatRoom642Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom642Client
    {
        Task SendAsync(ChatRoom642Message message);
    }

    [ChatRoomClient]
    public class ChatRoom642Client: IChatRoom642Client
    {
        private Guid _sender;

        public ChatRoom642Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom642Message message) => Task.CompletedTask;
    }

    public class ChatRoom643Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom643Client
    {
        Task SendAsync(ChatRoom643Message message);
    }

    [ChatRoomClient]
    public class ChatRoom643Client: IChatRoom643Client
    {
        private Guid _sender;

        public ChatRoom643Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom643Message message) => Task.CompletedTask;
    }

    public class ChatRoom644Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom644Client
    {
        Task SendAsync(ChatRoom644Message message);
    }

    [ChatRoomClient]
    public class ChatRoom644Client: IChatRoom644Client
    {
        private Guid _sender;

        public ChatRoom644Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom644Message message) => Task.CompletedTask;
    }

    public class ChatRoom645Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom645Client
    {
        Task SendAsync(ChatRoom645Message message);
    }

    [ChatRoomClient]
    public class ChatRoom645Client: IChatRoom645Client
    {
        private Guid _sender;

        public ChatRoom645Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom645Message message) => Task.CompletedTask;
    }

    public class ChatRoom646Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom646Client
    {
        Task SendAsync(ChatRoom646Message message);
    }

    [ChatRoomClient]
    public class ChatRoom646Client: IChatRoom646Client
    {
        private Guid _sender;

        public ChatRoom646Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom646Message message) => Task.CompletedTask;
    }

    public class ChatRoom647Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom647Client
    {
        Task SendAsync(ChatRoom647Message message);
    }

    [ChatRoomClient]
    public class ChatRoom647Client: IChatRoom647Client
    {
        private Guid _sender;

        public ChatRoom647Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom647Message message) => Task.CompletedTask;
    }

    public class ChatRoom648Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom648Client
    {
        Task SendAsync(ChatRoom648Message message);
    }

    [ChatRoomClient]
    public class ChatRoom648Client: IChatRoom648Client
    {
        private Guid _sender;

        public ChatRoom648Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom648Message message) => Task.CompletedTask;
    }

    public class ChatRoom649Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom649Client
    {
        Task SendAsync(ChatRoom649Message message);
    }

    [ChatRoomClient]
    public class ChatRoom649Client: IChatRoom649Client
    {
        private Guid _sender;

        public ChatRoom649Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom649Message message) => Task.CompletedTask;
    }

    public class ChatRoom650Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom650Client
    {
        Task SendAsync(ChatRoom650Message message);
    }

    [ChatRoomClient]
    public class ChatRoom650Client: IChatRoom650Client
    {
        private Guid _sender;

        public ChatRoom650Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom650Message message) => Task.CompletedTask;
    }

    public class ChatRoom651Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom651Client
    {
        Task SendAsync(ChatRoom651Message message);
    }

    [ChatRoomClient]
    public class ChatRoom651Client: IChatRoom651Client
    {
        private Guid _sender;

        public ChatRoom651Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom651Message message) => Task.CompletedTask;
    }

    public class ChatRoom652Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom652Client
    {
        Task SendAsync(ChatRoom652Message message);
    }

    [ChatRoomClient]
    public class ChatRoom652Client: IChatRoom652Client
    {
        private Guid _sender;

        public ChatRoom652Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom652Message message) => Task.CompletedTask;
    }

    public class ChatRoom653Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom653Client
    {
        Task SendAsync(ChatRoom653Message message);
    }

    [ChatRoomClient]
    public class ChatRoom653Client: IChatRoom653Client
    {
        private Guid _sender;

        public ChatRoom653Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom653Message message) => Task.CompletedTask;
    }

    public class ChatRoom654Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom654Client
    {
        Task SendAsync(ChatRoom654Message message);
    }

    [ChatRoomClient]
    public class ChatRoom654Client: IChatRoom654Client
    {
        private Guid _sender;

        public ChatRoom654Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom654Message message) => Task.CompletedTask;
    }

    public class ChatRoom655Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom655Client
    {
        Task SendAsync(ChatRoom655Message message);
    }

    [ChatRoomClient]
    public class ChatRoom655Client: IChatRoom655Client
    {
        private Guid _sender;

        public ChatRoom655Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom655Message message) => Task.CompletedTask;
    }

    public class ChatRoom656Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom656Client
    {
        Task SendAsync(ChatRoom656Message message);
    }

    [ChatRoomClient]
    public class ChatRoom656Client: IChatRoom656Client
    {
        private Guid _sender;

        public ChatRoom656Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom656Message message) => Task.CompletedTask;
    }

    public class ChatRoom657Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom657Client
    {
        Task SendAsync(ChatRoom657Message message);
    }

    [ChatRoomClient]
    public class ChatRoom657Client: IChatRoom657Client
    {
        private Guid _sender;

        public ChatRoom657Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom657Message message) => Task.CompletedTask;
    }

    public class ChatRoom658Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom658Client
    {
        Task SendAsync(ChatRoom658Message message);
    }

    [ChatRoomClient]
    public class ChatRoom658Client: IChatRoom658Client
    {
        private Guid _sender;

        public ChatRoom658Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom658Message message) => Task.CompletedTask;
    }

    public class ChatRoom659Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom659Client
    {
        Task SendAsync(ChatRoom659Message message);
    }

    [ChatRoomClient]
    public class ChatRoom659Client: IChatRoom659Client
    {
        private Guid _sender;

        public ChatRoom659Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom659Message message) => Task.CompletedTask;
    }

    public class ChatRoom660Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom660Client
    {
        Task SendAsync(ChatRoom660Message message);
    }

    [ChatRoomClient]
    public class ChatRoom660Client: IChatRoom660Client
    {
        private Guid _sender;

        public ChatRoom660Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom660Message message) => Task.CompletedTask;
    }

    public class ChatRoom661Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom661Client
    {
        Task SendAsync(ChatRoom661Message message);
    }

    [ChatRoomClient]
    public class ChatRoom661Client: IChatRoom661Client
    {
        private Guid _sender;

        public ChatRoom661Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom661Message message) => Task.CompletedTask;
    }

    public class ChatRoom662Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom662Client
    {
        Task SendAsync(ChatRoom662Message message);
    }

    [ChatRoomClient]
    public class ChatRoom662Client: IChatRoom662Client
    {
        private Guid _sender;

        public ChatRoom662Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom662Message message) => Task.CompletedTask;
    }

    public class ChatRoom663Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom663Client
    {
        Task SendAsync(ChatRoom663Message message);
    }

    [ChatRoomClient]
    public class ChatRoom663Client: IChatRoom663Client
    {
        private Guid _sender;

        public ChatRoom663Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom663Message message) => Task.CompletedTask;
    }

    public class ChatRoom664Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom664Client
    {
        Task SendAsync(ChatRoom664Message message);
    }

    [ChatRoomClient]
    public class ChatRoom664Client: IChatRoom664Client
    {
        private Guid _sender;

        public ChatRoom664Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom664Message message) => Task.CompletedTask;
    }

    public class ChatRoom665Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom665Client
    {
        Task SendAsync(ChatRoom665Message message);
    }

    [ChatRoomClient]
    public class ChatRoom665Client: IChatRoom665Client
    {
        private Guid _sender;

        public ChatRoom665Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom665Message message) => Task.CompletedTask;
    }

    public class ChatRoom666Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom666Client
    {
        Task SendAsync(ChatRoom666Message message);
    }

    [ChatRoomClient]
    public class ChatRoom666Client: IChatRoom666Client
    {
        private Guid _sender;

        public ChatRoom666Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom666Message message) => Task.CompletedTask;
    }

    public class ChatRoom667Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom667Client
    {
        Task SendAsync(ChatRoom667Message message);
    }

    [ChatRoomClient]
    public class ChatRoom667Client: IChatRoom667Client
    {
        private Guid _sender;

        public ChatRoom667Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom667Message message) => Task.CompletedTask;
    }

    public class ChatRoom668Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom668Client
    {
        Task SendAsync(ChatRoom668Message message);
    }

    [ChatRoomClient]
    public class ChatRoom668Client: IChatRoom668Client
    {
        private Guid _sender;

        public ChatRoom668Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom668Message message) => Task.CompletedTask;
    }

    public class ChatRoom669Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom669Client
    {
        Task SendAsync(ChatRoom669Message message);
    }

    [ChatRoomClient]
    public class ChatRoom669Client: IChatRoom669Client
    {
        private Guid _sender;

        public ChatRoom669Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom669Message message) => Task.CompletedTask;
    }

    public class ChatRoom670Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom670Client
    {
        Task SendAsync(ChatRoom670Message message);
    }

    [ChatRoomClient]
    public class ChatRoom670Client: IChatRoom670Client
    {
        private Guid _sender;

        public ChatRoom670Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom670Message message) => Task.CompletedTask;
    }

    public class ChatRoom671Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom671Client
    {
        Task SendAsync(ChatRoom671Message message);
    }

    [ChatRoomClient]
    public class ChatRoom671Client: IChatRoom671Client
    {
        private Guid _sender;

        public ChatRoom671Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom671Message message) => Task.CompletedTask;
    }

    public class ChatRoom672Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom672Client
    {
        Task SendAsync(ChatRoom672Message message);
    }

    [ChatRoomClient]
    public class ChatRoom672Client: IChatRoom672Client
    {
        private Guid _sender;

        public ChatRoom672Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom672Message message) => Task.CompletedTask;
    }

    public class ChatRoom673Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom673Client
    {
        Task SendAsync(ChatRoom673Message message);
    }

    [ChatRoomClient]
    public class ChatRoom673Client: IChatRoom673Client
    {
        private Guid _sender;

        public ChatRoom673Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom673Message message) => Task.CompletedTask;
    }

    public class ChatRoom674Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom674Client
    {
        Task SendAsync(ChatRoom674Message message);
    }

    [ChatRoomClient]
    public class ChatRoom674Client: IChatRoom674Client
    {
        private Guid _sender;

        public ChatRoom674Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom674Message message) => Task.CompletedTask;
    }

    public class ChatRoom675Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom675Client
    {
        Task SendAsync(ChatRoom675Message message);
    }

    [ChatRoomClient]
    public class ChatRoom675Client: IChatRoom675Client
    {
        private Guid _sender;

        public ChatRoom675Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom675Message message) => Task.CompletedTask;
    }

    public class ChatRoom676Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom676Client
    {
        Task SendAsync(ChatRoom676Message message);
    }

    [ChatRoomClient]
    public class ChatRoom676Client: IChatRoom676Client
    {
        private Guid _sender;

        public ChatRoom676Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom676Message message) => Task.CompletedTask;
    }

    public class ChatRoom677Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom677Client
    {
        Task SendAsync(ChatRoom677Message message);
    }

    [ChatRoomClient]
    public class ChatRoom677Client: IChatRoom677Client
    {
        private Guid _sender;

        public ChatRoom677Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom677Message message) => Task.CompletedTask;
    }

    public class ChatRoom678Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom678Client
    {
        Task SendAsync(ChatRoom678Message message);
    }

    [ChatRoomClient]
    public class ChatRoom678Client: IChatRoom678Client
    {
        private Guid _sender;

        public ChatRoom678Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom678Message message) => Task.CompletedTask;
    }

    public class ChatRoom679Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom679Client
    {
        Task SendAsync(ChatRoom679Message message);
    }

    [ChatRoomClient]
    public class ChatRoom679Client: IChatRoom679Client
    {
        private Guid _sender;

        public ChatRoom679Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom679Message message) => Task.CompletedTask;
    }

    public class ChatRoom680Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom680Client
    {
        Task SendAsync(ChatRoom680Message message);
    }

    [ChatRoomClient]
    public class ChatRoom680Client: IChatRoom680Client
    {
        private Guid _sender;

        public ChatRoom680Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom680Message message) => Task.CompletedTask;
    }

    public class ChatRoom681Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom681Client
    {
        Task SendAsync(ChatRoom681Message message);
    }

    [ChatRoomClient]
    public class ChatRoom681Client: IChatRoom681Client
    {
        private Guid _sender;

        public ChatRoom681Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom681Message message) => Task.CompletedTask;
    }

    public class ChatRoom682Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom682Client
    {
        Task SendAsync(ChatRoom682Message message);
    }

    [ChatRoomClient]
    public class ChatRoom682Client: IChatRoom682Client
    {
        private Guid _sender;

        public ChatRoom682Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom682Message message) => Task.CompletedTask;
    }

    public class ChatRoom683Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom683Client
    {
        Task SendAsync(ChatRoom683Message message);
    }

    [ChatRoomClient]
    public class ChatRoom683Client: IChatRoom683Client
    {
        private Guid _sender;

        public ChatRoom683Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom683Message message) => Task.CompletedTask;
    }

    public class ChatRoom684Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom684Client
    {
        Task SendAsync(ChatRoom684Message message);
    }

    [ChatRoomClient]
    public class ChatRoom684Client: IChatRoom684Client
    {
        private Guid _sender;

        public ChatRoom684Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom684Message message) => Task.CompletedTask;
    }

    public class ChatRoom685Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom685Client
    {
        Task SendAsync(ChatRoom685Message message);
    }

    [ChatRoomClient]
    public class ChatRoom685Client: IChatRoom685Client
    {
        private Guid _sender;

        public ChatRoom685Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom685Message message) => Task.CompletedTask;
    }

    public class ChatRoom686Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom686Client
    {
        Task SendAsync(ChatRoom686Message message);
    }

    [ChatRoomClient]
    public class ChatRoom686Client: IChatRoom686Client
    {
        private Guid _sender;

        public ChatRoom686Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom686Message message) => Task.CompletedTask;
    }

    public class ChatRoom687Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom687Client
    {
        Task SendAsync(ChatRoom687Message message);
    }

    [ChatRoomClient]
    public class ChatRoom687Client: IChatRoom687Client
    {
        private Guid _sender;

        public ChatRoom687Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom687Message message) => Task.CompletedTask;
    }

    public class ChatRoom688Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom688Client
    {
        Task SendAsync(ChatRoom688Message message);
    }

    [ChatRoomClient]
    public class ChatRoom688Client: IChatRoom688Client
    {
        private Guid _sender;

        public ChatRoom688Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom688Message message) => Task.CompletedTask;
    }

    public class ChatRoom689Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom689Client
    {
        Task SendAsync(ChatRoom689Message message);
    }

    [ChatRoomClient]
    public class ChatRoom689Client: IChatRoom689Client
    {
        private Guid _sender;

        public ChatRoom689Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom689Message message) => Task.CompletedTask;
    }

    public class ChatRoom690Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom690Client
    {
        Task SendAsync(ChatRoom690Message message);
    }

    [ChatRoomClient]
    public class ChatRoom690Client: IChatRoom690Client
    {
        private Guid _sender;

        public ChatRoom690Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom690Message message) => Task.CompletedTask;
    }

    public class ChatRoom691Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom691Client
    {
        Task SendAsync(ChatRoom691Message message);
    }

    [ChatRoomClient]
    public class ChatRoom691Client: IChatRoom691Client
    {
        private Guid _sender;

        public ChatRoom691Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom691Message message) => Task.CompletedTask;
    }

    public class ChatRoom692Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom692Client
    {
        Task SendAsync(ChatRoom692Message message);
    }

    [ChatRoomClient]
    public class ChatRoom692Client: IChatRoom692Client
    {
        private Guid _sender;

        public ChatRoom692Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom692Message message) => Task.CompletedTask;
    }

    public class ChatRoom693Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom693Client
    {
        Task SendAsync(ChatRoom693Message message);
    }

    [ChatRoomClient]
    public class ChatRoom693Client: IChatRoom693Client
    {
        private Guid _sender;

        public ChatRoom693Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom693Message message) => Task.CompletedTask;
    }

    public class ChatRoom694Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom694Client
    {
        Task SendAsync(ChatRoom694Message message);
    }

    [ChatRoomClient]
    public class ChatRoom694Client: IChatRoom694Client
    {
        private Guid _sender;

        public ChatRoom694Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom694Message message) => Task.CompletedTask;
    }

    public class ChatRoom695Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom695Client
    {
        Task SendAsync(ChatRoom695Message message);
    }

    [ChatRoomClient]
    public class ChatRoom695Client: IChatRoom695Client
    {
        private Guid _sender;

        public ChatRoom695Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom695Message message) => Task.CompletedTask;
    }

    public class ChatRoom696Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom696Client
    {
        Task SendAsync(ChatRoom696Message message);
    }

    [ChatRoomClient]
    public class ChatRoom696Client: IChatRoom696Client
    {
        private Guid _sender;

        public ChatRoom696Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom696Message message) => Task.CompletedTask;
    }

    public class ChatRoom697Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom697Client
    {
        Task SendAsync(ChatRoom697Message message);
    }

    [ChatRoomClient]
    public class ChatRoom697Client: IChatRoom697Client
    {
        private Guid _sender;

        public ChatRoom697Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom697Message message) => Task.CompletedTask;
    }

    public class ChatRoom698Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom698Client
    {
        Task SendAsync(ChatRoom698Message message);
    }

    [ChatRoomClient]
    public class ChatRoom698Client: IChatRoom698Client
    {
        private Guid _sender;

        public ChatRoom698Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom698Message message) => Task.CompletedTask;
    }

    public class ChatRoom699Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom699Client
    {
        Task SendAsync(ChatRoom699Message message);
    }

    [ChatRoomClient]
    public class ChatRoom699Client: IChatRoom699Client
    {
        private Guid _sender;

        public ChatRoom699Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom699Message message) => Task.CompletedTask;
    }

    public class ChatRoom700Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom700Client
    {
        Task SendAsync(ChatRoom700Message message);
    }

    [ChatRoomClient]
    public class ChatRoom700Client: IChatRoom700Client
    {
        private Guid _sender;

        public ChatRoom700Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom700Message message) => Task.CompletedTask;
    }

    public class ChatRoom701Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom701Client
    {
        Task SendAsync(ChatRoom701Message message);
    }

    [ChatRoomClient]
    public class ChatRoom701Client: IChatRoom701Client
    {
        private Guid _sender;

        public ChatRoom701Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom701Message message) => Task.CompletedTask;
    }

    public class ChatRoom702Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom702Client
    {
        Task SendAsync(ChatRoom702Message message);
    }

    [ChatRoomClient]
    public class ChatRoom702Client: IChatRoom702Client
    {
        private Guid _sender;

        public ChatRoom702Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom702Message message) => Task.CompletedTask;
    }

    public class ChatRoom703Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom703Client
    {
        Task SendAsync(ChatRoom703Message message);
    }

    [ChatRoomClient]
    public class ChatRoom703Client: IChatRoom703Client
    {
        private Guid _sender;

        public ChatRoom703Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom703Message message) => Task.CompletedTask;
    }

    public class ChatRoom704Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom704Client
    {
        Task SendAsync(ChatRoom704Message message);
    }

    [ChatRoomClient]
    public class ChatRoom704Client: IChatRoom704Client
    {
        private Guid _sender;

        public ChatRoom704Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom704Message message) => Task.CompletedTask;
    }

    public class ChatRoom705Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom705Client
    {
        Task SendAsync(ChatRoom705Message message);
    }

    [ChatRoomClient]
    public class ChatRoom705Client: IChatRoom705Client
    {
        private Guid _sender;

        public ChatRoom705Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom705Message message) => Task.CompletedTask;
    }

    public class ChatRoom706Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom706Client
    {
        Task SendAsync(ChatRoom706Message message);
    }

    [ChatRoomClient]
    public class ChatRoom706Client: IChatRoom706Client
    {
        private Guid _sender;

        public ChatRoom706Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom706Message message) => Task.CompletedTask;
    }

    public class ChatRoom707Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom707Client
    {
        Task SendAsync(ChatRoom707Message message);
    }

    [ChatRoomClient]
    public class ChatRoom707Client: IChatRoom707Client
    {
        private Guid _sender;

        public ChatRoom707Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom707Message message) => Task.CompletedTask;
    }

    public class ChatRoom708Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom708Client
    {
        Task SendAsync(ChatRoom708Message message);
    }

    [ChatRoomClient]
    public class ChatRoom708Client: IChatRoom708Client
    {
        private Guid _sender;

        public ChatRoom708Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom708Message message) => Task.CompletedTask;
    }

    public class ChatRoom709Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom709Client
    {
        Task SendAsync(ChatRoom709Message message);
    }

    [ChatRoomClient]
    public class ChatRoom709Client: IChatRoom709Client
    {
        private Guid _sender;

        public ChatRoom709Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom709Message message) => Task.CompletedTask;
    }

    public class ChatRoom710Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom710Client
    {
        Task SendAsync(ChatRoom710Message message);
    }

    [ChatRoomClient]
    public class ChatRoom710Client: IChatRoom710Client
    {
        private Guid _sender;

        public ChatRoom710Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom710Message message) => Task.CompletedTask;
    }

    public class ChatRoom711Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom711Client
    {
        Task SendAsync(ChatRoom711Message message);
    }

    [ChatRoomClient]
    public class ChatRoom711Client: IChatRoom711Client
    {
        private Guid _sender;

        public ChatRoom711Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom711Message message) => Task.CompletedTask;
    }

    public class ChatRoom712Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom712Client
    {
        Task SendAsync(ChatRoom712Message message);
    }

    [ChatRoomClient]
    public class ChatRoom712Client: IChatRoom712Client
    {
        private Guid _sender;

        public ChatRoom712Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom712Message message) => Task.CompletedTask;
    }

    public class ChatRoom713Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom713Client
    {
        Task SendAsync(ChatRoom713Message message);
    }

    [ChatRoomClient]
    public class ChatRoom713Client: IChatRoom713Client
    {
        private Guid _sender;

        public ChatRoom713Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom713Message message) => Task.CompletedTask;
    }

    public class ChatRoom714Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom714Client
    {
        Task SendAsync(ChatRoom714Message message);
    }

    [ChatRoomClient]
    public class ChatRoom714Client: IChatRoom714Client
    {
        private Guid _sender;

        public ChatRoom714Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom714Message message) => Task.CompletedTask;
    }

    public class ChatRoom715Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom715Client
    {
        Task SendAsync(ChatRoom715Message message);
    }

    [ChatRoomClient]
    public class ChatRoom715Client: IChatRoom715Client
    {
        private Guid _sender;

        public ChatRoom715Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom715Message message) => Task.CompletedTask;
    }

    public class ChatRoom716Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom716Client
    {
        Task SendAsync(ChatRoom716Message message);
    }

    [ChatRoomClient]
    public class ChatRoom716Client: IChatRoom716Client
    {
        private Guid _sender;

        public ChatRoom716Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom716Message message) => Task.CompletedTask;
    }

    public class ChatRoom717Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom717Client
    {
        Task SendAsync(ChatRoom717Message message);
    }

    [ChatRoomClient]
    public class ChatRoom717Client: IChatRoom717Client
    {
        private Guid _sender;

        public ChatRoom717Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom717Message message) => Task.CompletedTask;
    }

    public class ChatRoom718Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom718Client
    {
        Task SendAsync(ChatRoom718Message message);
    }

    [ChatRoomClient]
    public class ChatRoom718Client: IChatRoom718Client
    {
        private Guid _sender;

        public ChatRoom718Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom718Message message) => Task.CompletedTask;
    }

    public class ChatRoom719Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom719Client
    {
        Task SendAsync(ChatRoom719Message message);
    }

    [ChatRoomClient]
    public class ChatRoom719Client: IChatRoom719Client
    {
        private Guid _sender;

        public ChatRoom719Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom719Message message) => Task.CompletedTask;
    }

    public class ChatRoom720Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom720Client
    {
        Task SendAsync(ChatRoom720Message message);
    }

    [ChatRoomClient]
    public class ChatRoom720Client: IChatRoom720Client
    {
        private Guid _sender;

        public ChatRoom720Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom720Message message) => Task.CompletedTask;
    }

    public class ChatRoom721Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom721Client
    {
        Task SendAsync(ChatRoom721Message message);
    }

    [ChatRoomClient]
    public class ChatRoom721Client: IChatRoom721Client
    {
        private Guid _sender;

        public ChatRoom721Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom721Message message) => Task.CompletedTask;
    }

    public class ChatRoom722Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom722Client
    {
        Task SendAsync(ChatRoom722Message message);
    }

    [ChatRoomClient]
    public class ChatRoom722Client: IChatRoom722Client
    {
        private Guid _sender;

        public ChatRoom722Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom722Message message) => Task.CompletedTask;
    }

    public class ChatRoom723Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom723Client
    {
        Task SendAsync(ChatRoom723Message message);
    }

    [ChatRoomClient]
    public class ChatRoom723Client: IChatRoom723Client
    {
        private Guid _sender;

        public ChatRoom723Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom723Message message) => Task.CompletedTask;
    }

    public class ChatRoom724Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom724Client
    {
        Task SendAsync(ChatRoom724Message message);
    }

    [ChatRoomClient]
    public class ChatRoom724Client: IChatRoom724Client
    {
        private Guid _sender;

        public ChatRoom724Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom724Message message) => Task.CompletedTask;
    }

    public class ChatRoom725Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom725Client
    {
        Task SendAsync(ChatRoom725Message message);
    }

    [ChatRoomClient]
    public class ChatRoom725Client: IChatRoom725Client
    {
        private Guid _sender;

        public ChatRoom725Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom725Message message) => Task.CompletedTask;
    }

    public class ChatRoom726Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom726Client
    {
        Task SendAsync(ChatRoom726Message message);
    }

    [ChatRoomClient]
    public class ChatRoom726Client: IChatRoom726Client
    {
        private Guid _sender;

        public ChatRoom726Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom726Message message) => Task.CompletedTask;
    }

    public class ChatRoom727Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom727Client
    {
        Task SendAsync(ChatRoom727Message message);
    }

    [ChatRoomClient]
    public class ChatRoom727Client: IChatRoom727Client
    {
        private Guid _sender;

        public ChatRoom727Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom727Message message) => Task.CompletedTask;
    }

    public class ChatRoom728Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom728Client
    {
        Task SendAsync(ChatRoom728Message message);
    }

    [ChatRoomClient]
    public class ChatRoom728Client: IChatRoom728Client
    {
        private Guid _sender;

        public ChatRoom728Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom728Message message) => Task.CompletedTask;
    }

    public class ChatRoom729Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom729Client
    {
        Task SendAsync(ChatRoom729Message message);
    }

    [ChatRoomClient]
    public class ChatRoom729Client: IChatRoom729Client
    {
        private Guid _sender;

        public ChatRoom729Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom729Message message) => Task.CompletedTask;
    }

    public class ChatRoom730Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom730Client
    {
        Task SendAsync(ChatRoom730Message message);
    }

    [ChatRoomClient]
    public class ChatRoom730Client: IChatRoom730Client
    {
        private Guid _sender;

        public ChatRoom730Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom730Message message) => Task.CompletedTask;
    }

    public class ChatRoom731Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom731Client
    {
        Task SendAsync(ChatRoom731Message message);
    }

    [ChatRoomClient]
    public class ChatRoom731Client: IChatRoom731Client
    {
        private Guid _sender;

        public ChatRoom731Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom731Message message) => Task.CompletedTask;
    }

    public class ChatRoom732Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom732Client
    {
        Task SendAsync(ChatRoom732Message message);
    }

    [ChatRoomClient]
    public class ChatRoom732Client: IChatRoom732Client
    {
        private Guid _sender;

        public ChatRoom732Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom732Message message) => Task.CompletedTask;
    }

    public class ChatRoom733Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom733Client
    {
        Task SendAsync(ChatRoom733Message message);
    }

    [ChatRoomClient]
    public class ChatRoom733Client: IChatRoom733Client
    {
        private Guid _sender;

        public ChatRoom733Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom733Message message) => Task.CompletedTask;
    }

    public class ChatRoom734Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom734Client
    {
        Task SendAsync(ChatRoom734Message message);
    }

    [ChatRoomClient]
    public class ChatRoom734Client: IChatRoom734Client
    {
        private Guid _sender;

        public ChatRoom734Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom734Message message) => Task.CompletedTask;
    }

    public class ChatRoom735Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom735Client
    {
        Task SendAsync(ChatRoom735Message message);
    }

    [ChatRoomClient]
    public class ChatRoom735Client: IChatRoom735Client
    {
        private Guid _sender;

        public ChatRoom735Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom735Message message) => Task.CompletedTask;
    }

    public class ChatRoom736Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom736Client
    {
        Task SendAsync(ChatRoom736Message message);
    }

    [ChatRoomClient]
    public class ChatRoom736Client: IChatRoom736Client
    {
        private Guid _sender;

        public ChatRoom736Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom736Message message) => Task.CompletedTask;
    }

    public class ChatRoom737Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom737Client
    {
        Task SendAsync(ChatRoom737Message message);
    }

    [ChatRoomClient]
    public class ChatRoom737Client: IChatRoom737Client
    {
        private Guid _sender;

        public ChatRoom737Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom737Message message) => Task.CompletedTask;
    }

    public class ChatRoom738Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom738Client
    {
        Task SendAsync(ChatRoom738Message message);
    }

    [ChatRoomClient]
    public class ChatRoom738Client: IChatRoom738Client
    {
        private Guid _sender;

        public ChatRoom738Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom738Message message) => Task.CompletedTask;
    }

    public class ChatRoom739Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom739Client
    {
        Task SendAsync(ChatRoom739Message message);
    }

    [ChatRoomClient]
    public class ChatRoom739Client: IChatRoom739Client
    {
        private Guid _sender;

        public ChatRoom739Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom739Message message) => Task.CompletedTask;
    }

    public class ChatRoom740Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom740Client
    {
        Task SendAsync(ChatRoom740Message message);
    }

    [ChatRoomClient]
    public class ChatRoom740Client: IChatRoom740Client
    {
        private Guid _sender;

        public ChatRoom740Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom740Message message) => Task.CompletedTask;
    }

    public class ChatRoom741Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom741Client
    {
        Task SendAsync(ChatRoom741Message message);
    }

    [ChatRoomClient]
    public class ChatRoom741Client: IChatRoom741Client
    {
        private Guid _sender;

        public ChatRoom741Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom741Message message) => Task.CompletedTask;
    }

    public class ChatRoom742Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom742Client
    {
        Task SendAsync(ChatRoom742Message message);
    }

    [ChatRoomClient]
    public class ChatRoom742Client: IChatRoom742Client
    {
        private Guid _sender;

        public ChatRoom742Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom742Message message) => Task.CompletedTask;
    }

    public class ChatRoom743Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom743Client
    {
        Task SendAsync(ChatRoom743Message message);
    }

    [ChatRoomClient]
    public class ChatRoom743Client: IChatRoom743Client
    {
        private Guid _sender;

        public ChatRoom743Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom743Message message) => Task.CompletedTask;
    }

    public class ChatRoom744Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom744Client
    {
        Task SendAsync(ChatRoom744Message message);
    }

    [ChatRoomClient]
    public class ChatRoom744Client: IChatRoom744Client
    {
        private Guid _sender;

        public ChatRoom744Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom744Message message) => Task.CompletedTask;
    }

    public class ChatRoom745Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom745Client
    {
        Task SendAsync(ChatRoom745Message message);
    }

    [ChatRoomClient]
    public class ChatRoom745Client: IChatRoom745Client
    {
        private Guid _sender;

        public ChatRoom745Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom745Message message) => Task.CompletedTask;
    }

    public class ChatRoom746Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom746Client
    {
        Task SendAsync(ChatRoom746Message message);
    }

    [ChatRoomClient]
    public class ChatRoom746Client: IChatRoom746Client
    {
        private Guid _sender;

        public ChatRoom746Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom746Message message) => Task.CompletedTask;
    }

    public class ChatRoom747Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom747Client
    {
        Task SendAsync(ChatRoom747Message message);
    }

    [ChatRoomClient]
    public class ChatRoom747Client: IChatRoom747Client
    {
        private Guid _sender;

        public ChatRoom747Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom747Message message) => Task.CompletedTask;
    }

    public class ChatRoom748Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom748Client
    {
        Task SendAsync(ChatRoom748Message message);
    }

    [ChatRoomClient]
    public class ChatRoom748Client: IChatRoom748Client
    {
        private Guid _sender;

        public ChatRoom748Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom748Message message) => Task.CompletedTask;
    }

    public class ChatRoom749Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom749Client
    {
        Task SendAsync(ChatRoom749Message message);
    }

    [ChatRoomClient]
    public class ChatRoom749Client: IChatRoom749Client
    {
        private Guid _sender;

        public ChatRoom749Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom749Message message) => Task.CompletedTask;
    }

    public class ChatRoom750Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom750Client
    {
        Task SendAsync(ChatRoom750Message message);
    }

    [ChatRoomClient]
    public class ChatRoom750Client: IChatRoom750Client
    {
        private Guid _sender;

        public ChatRoom750Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom750Message message) => Task.CompletedTask;
    }

    public class ChatRoom751Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom751Client
    {
        Task SendAsync(ChatRoom751Message message);
    }

    [ChatRoomClient]
    public class ChatRoom751Client: IChatRoom751Client
    {
        private Guid _sender;

        public ChatRoom751Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom751Message message) => Task.CompletedTask;
    }

    public class ChatRoom752Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom752Client
    {
        Task SendAsync(ChatRoom752Message message);
    }

    [ChatRoomClient]
    public class ChatRoom752Client: IChatRoom752Client
    {
        private Guid _sender;

        public ChatRoom752Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom752Message message) => Task.CompletedTask;
    }

    public class ChatRoom753Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom753Client
    {
        Task SendAsync(ChatRoom753Message message);
    }

    [ChatRoomClient]
    public class ChatRoom753Client: IChatRoom753Client
    {
        private Guid _sender;

        public ChatRoom753Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom753Message message) => Task.CompletedTask;
    }

    public class ChatRoom754Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom754Client
    {
        Task SendAsync(ChatRoom754Message message);
    }

    [ChatRoomClient]
    public class ChatRoom754Client: IChatRoom754Client
    {
        private Guid _sender;

        public ChatRoom754Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom754Message message) => Task.CompletedTask;
    }

    public class ChatRoom755Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom755Client
    {
        Task SendAsync(ChatRoom755Message message);
    }

    [ChatRoomClient]
    public class ChatRoom755Client: IChatRoom755Client
    {
        private Guid _sender;

        public ChatRoom755Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom755Message message) => Task.CompletedTask;
    }

    public class ChatRoom756Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom756Client
    {
        Task SendAsync(ChatRoom756Message message);
    }

    [ChatRoomClient]
    public class ChatRoom756Client: IChatRoom756Client
    {
        private Guid _sender;

        public ChatRoom756Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom756Message message) => Task.CompletedTask;
    }

    public class ChatRoom757Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom757Client
    {
        Task SendAsync(ChatRoom757Message message);
    }

    [ChatRoomClient]
    public class ChatRoom757Client: IChatRoom757Client
    {
        private Guid _sender;

        public ChatRoom757Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom757Message message) => Task.CompletedTask;
    }

    public class ChatRoom758Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom758Client
    {
        Task SendAsync(ChatRoom758Message message);
    }

    [ChatRoomClient]
    public class ChatRoom758Client: IChatRoom758Client
    {
        private Guid _sender;

        public ChatRoom758Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom758Message message) => Task.CompletedTask;
    }

    public class ChatRoom759Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom759Client
    {
        Task SendAsync(ChatRoom759Message message);
    }

    [ChatRoomClient]
    public class ChatRoom759Client: IChatRoom759Client
    {
        private Guid _sender;

        public ChatRoom759Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom759Message message) => Task.CompletedTask;
    }

    public class ChatRoom760Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom760Client
    {
        Task SendAsync(ChatRoom760Message message);
    }

    [ChatRoomClient]
    public class ChatRoom760Client: IChatRoom760Client
    {
        private Guid _sender;

        public ChatRoom760Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom760Message message) => Task.CompletedTask;
    }

    public class ChatRoom761Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom761Client
    {
        Task SendAsync(ChatRoom761Message message);
    }

    [ChatRoomClient]
    public class ChatRoom761Client: IChatRoom761Client
    {
        private Guid _sender;

        public ChatRoom761Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom761Message message) => Task.CompletedTask;
    }

    public class ChatRoom762Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom762Client
    {
        Task SendAsync(ChatRoom762Message message);
    }

    [ChatRoomClient]
    public class ChatRoom762Client: IChatRoom762Client
    {
        private Guid _sender;

        public ChatRoom762Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom762Message message) => Task.CompletedTask;
    }

    public class ChatRoom763Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom763Client
    {
        Task SendAsync(ChatRoom763Message message);
    }

    [ChatRoomClient]
    public class ChatRoom763Client: IChatRoom763Client
    {
        private Guid _sender;

        public ChatRoom763Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom763Message message) => Task.CompletedTask;
    }

    public class ChatRoom764Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom764Client
    {
        Task SendAsync(ChatRoom764Message message);
    }

    [ChatRoomClient]
    public class ChatRoom764Client: IChatRoom764Client
    {
        private Guid _sender;

        public ChatRoom764Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom764Message message) => Task.CompletedTask;
    }

    public class ChatRoom765Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom765Client
    {
        Task SendAsync(ChatRoom765Message message);
    }

    [ChatRoomClient]
    public class ChatRoom765Client: IChatRoom765Client
    {
        private Guid _sender;

        public ChatRoom765Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom765Message message) => Task.CompletedTask;
    }

    public class ChatRoom766Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom766Client
    {
        Task SendAsync(ChatRoom766Message message);
    }

    [ChatRoomClient]
    public class ChatRoom766Client: IChatRoom766Client
    {
        private Guid _sender;

        public ChatRoom766Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom766Message message) => Task.CompletedTask;
    }

    public class ChatRoom767Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom767Client
    {
        Task SendAsync(ChatRoom767Message message);
    }

    [ChatRoomClient]
    public class ChatRoom767Client: IChatRoom767Client
    {
        private Guid _sender;

        public ChatRoom767Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom767Message message) => Task.CompletedTask;
    }

    public class ChatRoom768Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom768Client
    {
        Task SendAsync(ChatRoom768Message message);
    }

    [ChatRoomClient]
    public class ChatRoom768Client: IChatRoom768Client
    {
        private Guid _sender;

        public ChatRoom768Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom768Message message) => Task.CompletedTask;
    }

    public class ChatRoom769Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom769Client
    {
        Task SendAsync(ChatRoom769Message message);
    }

    [ChatRoomClient]
    public class ChatRoom769Client: IChatRoom769Client
    {
        private Guid _sender;

        public ChatRoom769Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom769Message message) => Task.CompletedTask;
    }

    public class ChatRoom770Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom770Client
    {
        Task SendAsync(ChatRoom770Message message);
    }

    [ChatRoomClient]
    public class ChatRoom770Client: IChatRoom770Client
    {
        private Guid _sender;

        public ChatRoom770Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom770Message message) => Task.CompletedTask;
    }

    public class ChatRoom771Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom771Client
    {
        Task SendAsync(ChatRoom771Message message);
    }

    [ChatRoomClient]
    public class ChatRoom771Client: IChatRoom771Client
    {
        private Guid _sender;

        public ChatRoom771Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom771Message message) => Task.CompletedTask;
    }

    public class ChatRoom772Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom772Client
    {
        Task SendAsync(ChatRoom772Message message);
    }

    [ChatRoomClient]
    public class ChatRoom772Client: IChatRoom772Client
    {
        private Guid _sender;

        public ChatRoom772Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom772Message message) => Task.CompletedTask;
    }

    public class ChatRoom773Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom773Client
    {
        Task SendAsync(ChatRoom773Message message);
    }

    [ChatRoomClient]
    public class ChatRoom773Client: IChatRoom773Client
    {
        private Guid _sender;

        public ChatRoom773Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom773Message message) => Task.CompletedTask;
    }

    public class ChatRoom774Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom774Client
    {
        Task SendAsync(ChatRoom774Message message);
    }

    [ChatRoomClient]
    public class ChatRoom774Client: IChatRoom774Client
    {
        private Guid _sender;

        public ChatRoom774Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom774Message message) => Task.CompletedTask;
    }

    public class ChatRoom775Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom775Client
    {
        Task SendAsync(ChatRoom775Message message);
    }

    [ChatRoomClient]
    public class ChatRoom775Client: IChatRoom775Client
    {
        private Guid _sender;

        public ChatRoom775Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom775Message message) => Task.CompletedTask;
    }

    public class ChatRoom776Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom776Client
    {
        Task SendAsync(ChatRoom776Message message);
    }

    [ChatRoomClient]
    public class ChatRoom776Client: IChatRoom776Client
    {
        private Guid _sender;

        public ChatRoom776Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom776Message message) => Task.CompletedTask;
    }

    public class ChatRoom777Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom777Client
    {
        Task SendAsync(ChatRoom777Message message);
    }

    [ChatRoomClient]
    public class ChatRoom777Client: IChatRoom777Client
    {
        private Guid _sender;

        public ChatRoom777Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom777Message message) => Task.CompletedTask;
    }

    public class ChatRoom778Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom778Client
    {
        Task SendAsync(ChatRoom778Message message);
    }

    [ChatRoomClient]
    public class ChatRoom778Client: IChatRoom778Client
    {
        private Guid _sender;

        public ChatRoom778Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom778Message message) => Task.CompletedTask;
    }

    public class ChatRoom779Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom779Client
    {
        Task SendAsync(ChatRoom779Message message);
    }

    [ChatRoomClient]
    public class ChatRoom779Client: IChatRoom779Client
    {
        private Guid _sender;

        public ChatRoom779Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom779Message message) => Task.CompletedTask;
    }

    public class ChatRoom780Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom780Client
    {
        Task SendAsync(ChatRoom780Message message);
    }

    [ChatRoomClient]
    public class ChatRoom780Client: IChatRoom780Client
    {
        private Guid _sender;

        public ChatRoom780Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom780Message message) => Task.CompletedTask;
    }

    public class ChatRoom781Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom781Client
    {
        Task SendAsync(ChatRoom781Message message);
    }

    [ChatRoomClient]
    public class ChatRoom781Client: IChatRoom781Client
    {
        private Guid _sender;

        public ChatRoom781Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom781Message message) => Task.CompletedTask;
    }

    public class ChatRoom782Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom782Client
    {
        Task SendAsync(ChatRoom782Message message);
    }

    [ChatRoomClient]
    public class ChatRoom782Client: IChatRoom782Client
    {
        private Guid _sender;

        public ChatRoom782Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom782Message message) => Task.CompletedTask;
    }

    public class ChatRoom783Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom783Client
    {
        Task SendAsync(ChatRoom783Message message);
    }

    [ChatRoomClient]
    public class ChatRoom783Client: IChatRoom783Client
    {
        private Guid _sender;

        public ChatRoom783Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom783Message message) => Task.CompletedTask;
    }

    public class ChatRoom784Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom784Client
    {
        Task SendAsync(ChatRoom784Message message);
    }

    [ChatRoomClient]
    public class ChatRoom784Client: IChatRoom784Client
    {
        private Guid _sender;

        public ChatRoom784Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom784Message message) => Task.CompletedTask;
    }

    public class ChatRoom785Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom785Client
    {
        Task SendAsync(ChatRoom785Message message);
    }

    [ChatRoomClient]
    public class ChatRoom785Client: IChatRoom785Client
    {
        private Guid _sender;

        public ChatRoom785Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom785Message message) => Task.CompletedTask;
    }

    public class ChatRoom786Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom786Client
    {
        Task SendAsync(ChatRoom786Message message);
    }

    [ChatRoomClient]
    public class ChatRoom786Client: IChatRoom786Client
    {
        private Guid _sender;

        public ChatRoom786Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom786Message message) => Task.CompletedTask;
    }

    public class ChatRoom787Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom787Client
    {
        Task SendAsync(ChatRoom787Message message);
    }

    [ChatRoomClient]
    public class ChatRoom787Client: IChatRoom787Client
    {
        private Guid _sender;

        public ChatRoom787Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom787Message message) => Task.CompletedTask;
    }

    public class ChatRoom788Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom788Client
    {
        Task SendAsync(ChatRoom788Message message);
    }

    [ChatRoomClient]
    public class ChatRoom788Client: IChatRoom788Client
    {
        private Guid _sender;

        public ChatRoom788Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom788Message message) => Task.CompletedTask;
    }

    public class ChatRoom789Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom789Client
    {
        Task SendAsync(ChatRoom789Message message);
    }

    [ChatRoomClient]
    public class ChatRoom789Client: IChatRoom789Client
    {
        private Guid _sender;

        public ChatRoom789Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom789Message message) => Task.CompletedTask;
    }

    public class ChatRoom790Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom790Client
    {
        Task SendAsync(ChatRoom790Message message);
    }

    [ChatRoomClient]
    public class ChatRoom790Client: IChatRoom790Client
    {
        private Guid _sender;

        public ChatRoom790Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom790Message message) => Task.CompletedTask;
    }

    public class ChatRoom791Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom791Client
    {
        Task SendAsync(ChatRoom791Message message);
    }

    [ChatRoomClient]
    public class ChatRoom791Client: IChatRoom791Client
    {
        private Guid _sender;

        public ChatRoom791Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom791Message message) => Task.CompletedTask;
    }

    public class ChatRoom792Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom792Client
    {
        Task SendAsync(ChatRoom792Message message);
    }

    [ChatRoomClient]
    public class ChatRoom792Client: IChatRoom792Client
    {
        private Guid _sender;

        public ChatRoom792Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom792Message message) => Task.CompletedTask;
    }

    public class ChatRoom793Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom793Client
    {
        Task SendAsync(ChatRoom793Message message);
    }

    [ChatRoomClient]
    public class ChatRoom793Client: IChatRoom793Client
    {
        private Guid _sender;

        public ChatRoom793Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom793Message message) => Task.CompletedTask;
    }

    public class ChatRoom794Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom794Client
    {
        Task SendAsync(ChatRoom794Message message);
    }

    [ChatRoomClient]
    public class ChatRoom794Client: IChatRoom794Client
    {
        private Guid _sender;

        public ChatRoom794Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom794Message message) => Task.CompletedTask;
    }

    public class ChatRoom795Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom795Client
    {
        Task SendAsync(ChatRoom795Message message);
    }

    [ChatRoomClient]
    public class ChatRoom795Client: IChatRoom795Client
    {
        private Guid _sender;

        public ChatRoom795Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom795Message message) => Task.CompletedTask;
    }

    public class ChatRoom796Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom796Client
    {
        Task SendAsync(ChatRoom796Message message);
    }

    [ChatRoomClient]
    public class ChatRoom796Client: IChatRoom796Client
    {
        private Guid _sender;

        public ChatRoom796Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom796Message message) => Task.CompletedTask;
    }

    public class ChatRoom797Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom797Client
    {
        Task SendAsync(ChatRoom797Message message);
    }

    [ChatRoomClient]
    public class ChatRoom797Client: IChatRoom797Client
    {
        private Guid _sender;

        public ChatRoom797Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom797Message message) => Task.CompletedTask;
    }

    public class ChatRoom798Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom798Client
    {
        Task SendAsync(ChatRoom798Message message);
    }

    [ChatRoomClient]
    public class ChatRoom798Client: IChatRoom798Client
    {
        private Guid _sender;

        public ChatRoom798Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom798Message message) => Task.CompletedTask;
    }

    public class ChatRoom799Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom799Client
    {
        Task SendAsync(ChatRoom799Message message);
    }

    [ChatRoomClient]
    public class ChatRoom799Client: IChatRoom799Client
    {
        private Guid _sender;

        public ChatRoom799Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom799Message message) => Task.CompletedTask;
    }

    public class ChatRoom800Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom800Client
    {
        Task SendAsync(ChatRoom800Message message);
    }

    [ChatRoomClient]
    public class ChatRoom800Client: IChatRoom800Client
    {
        private Guid _sender;

        public ChatRoom800Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom800Message message) => Task.CompletedTask;
    }

    public class ChatRoom801Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom801Client
    {
        Task SendAsync(ChatRoom801Message message);
    }

    [ChatRoomClient]
    public class ChatRoom801Client: IChatRoom801Client
    {
        private Guid _sender;

        public ChatRoom801Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom801Message message) => Task.CompletedTask;
    }

    public class ChatRoom802Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom802Client
    {
        Task SendAsync(ChatRoom802Message message);
    }

    [ChatRoomClient]
    public class ChatRoom802Client: IChatRoom802Client
    {
        private Guid _sender;

        public ChatRoom802Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom802Message message) => Task.CompletedTask;
    }

    public class ChatRoom803Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom803Client
    {
        Task SendAsync(ChatRoom803Message message);
    }

    [ChatRoomClient]
    public class ChatRoom803Client: IChatRoom803Client
    {
        private Guid _sender;

        public ChatRoom803Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom803Message message) => Task.CompletedTask;
    }

    public class ChatRoom804Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom804Client
    {
        Task SendAsync(ChatRoom804Message message);
    }

    [ChatRoomClient]
    public class ChatRoom804Client: IChatRoom804Client
    {
        private Guid _sender;

        public ChatRoom804Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom804Message message) => Task.CompletedTask;
    }

    public class ChatRoom805Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom805Client
    {
        Task SendAsync(ChatRoom805Message message);
    }

    [ChatRoomClient]
    public class ChatRoom805Client: IChatRoom805Client
    {
        private Guid _sender;

        public ChatRoom805Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom805Message message) => Task.CompletedTask;
    }

    public class ChatRoom806Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom806Client
    {
        Task SendAsync(ChatRoom806Message message);
    }

    [ChatRoomClient]
    public class ChatRoom806Client: IChatRoom806Client
    {
        private Guid _sender;

        public ChatRoom806Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom806Message message) => Task.CompletedTask;
    }

    public class ChatRoom807Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom807Client
    {
        Task SendAsync(ChatRoom807Message message);
    }

    [ChatRoomClient]
    public class ChatRoom807Client: IChatRoom807Client
    {
        private Guid _sender;

        public ChatRoom807Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom807Message message) => Task.CompletedTask;
    }

    public class ChatRoom808Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom808Client
    {
        Task SendAsync(ChatRoom808Message message);
    }

    [ChatRoomClient]
    public class ChatRoom808Client: IChatRoom808Client
    {
        private Guid _sender;

        public ChatRoom808Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom808Message message) => Task.CompletedTask;
    }

    public class ChatRoom809Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom809Client
    {
        Task SendAsync(ChatRoom809Message message);
    }

    [ChatRoomClient]
    public class ChatRoom809Client: IChatRoom809Client
    {
        private Guid _sender;

        public ChatRoom809Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom809Message message) => Task.CompletedTask;
    }

    public class ChatRoom810Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom810Client
    {
        Task SendAsync(ChatRoom810Message message);
    }

    [ChatRoomClient]
    public class ChatRoom810Client: IChatRoom810Client
    {
        private Guid _sender;

        public ChatRoom810Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom810Message message) => Task.CompletedTask;
    }

    public class ChatRoom811Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom811Client
    {
        Task SendAsync(ChatRoom811Message message);
    }

    [ChatRoomClient]
    public class ChatRoom811Client: IChatRoom811Client
    {
        private Guid _sender;

        public ChatRoom811Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom811Message message) => Task.CompletedTask;
    }

    public class ChatRoom812Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom812Client
    {
        Task SendAsync(ChatRoom812Message message);
    }

    [ChatRoomClient]
    public class ChatRoom812Client: IChatRoom812Client
    {
        private Guid _sender;

        public ChatRoom812Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom812Message message) => Task.CompletedTask;
    }

    public class ChatRoom813Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom813Client
    {
        Task SendAsync(ChatRoom813Message message);
    }

    [ChatRoomClient]
    public class ChatRoom813Client: IChatRoom813Client
    {
        private Guid _sender;

        public ChatRoom813Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom813Message message) => Task.CompletedTask;
    }

    public class ChatRoom814Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom814Client
    {
        Task SendAsync(ChatRoom814Message message);
    }

    [ChatRoomClient]
    public class ChatRoom814Client: IChatRoom814Client
    {
        private Guid _sender;

        public ChatRoom814Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom814Message message) => Task.CompletedTask;
    }

    public class ChatRoom815Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom815Client
    {
        Task SendAsync(ChatRoom815Message message);
    }

    [ChatRoomClient]
    public class ChatRoom815Client: IChatRoom815Client
    {
        private Guid _sender;

        public ChatRoom815Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom815Message message) => Task.CompletedTask;
    }

    public class ChatRoom816Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom816Client
    {
        Task SendAsync(ChatRoom816Message message);
    }

    [ChatRoomClient]
    public class ChatRoom816Client: IChatRoom816Client
    {
        private Guid _sender;

        public ChatRoom816Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom816Message message) => Task.CompletedTask;
    }

    public class ChatRoom817Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom817Client
    {
        Task SendAsync(ChatRoom817Message message);
    }

    [ChatRoomClient]
    public class ChatRoom817Client: IChatRoom817Client
    {
        private Guid _sender;

        public ChatRoom817Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom817Message message) => Task.CompletedTask;
    }

    public class ChatRoom818Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom818Client
    {
        Task SendAsync(ChatRoom818Message message);
    }

    [ChatRoomClient]
    public class ChatRoom818Client: IChatRoom818Client
    {
        private Guid _sender;

        public ChatRoom818Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom818Message message) => Task.CompletedTask;
    }

    public class ChatRoom819Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom819Client
    {
        Task SendAsync(ChatRoom819Message message);
    }

    [ChatRoomClient]
    public class ChatRoom819Client: IChatRoom819Client
    {
        private Guid _sender;

        public ChatRoom819Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom819Message message) => Task.CompletedTask;
    }

    public class ChatRoom820Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom820Client
    {
        Task SendAsync(ChatRoom820Message message);
    }

    [ChatRoomClient]
    public class ChatRoom820Client: IChatRoom820Client
    {
        private Guid _sender;

        public ChatRoom820Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom820Message message) => Task.CompletedTask;
    }

    public class ChatRoom821Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom821Client
    {
        Task SendAsync(ChatRoom821Message message);
    }

    [ChatRoomClient]
    public class ChatRoom821Client: IChatRoom821Client
    {
        private Guid _sender;

        public ChatRoom821Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom821Message message) => Task.CompletedTask;
    }

    public class ChatRoom822Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom822Client
    {
        Task SendAsync(ChatRoom822Message message);
    }

    [ChatRoomClient]
    public class ChatRoom822Client: IChatRoom822Client
    {
        private Guid _sender;

        public ChatRoom822Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom822Message message) => Task.CompletedTask;
    }

    public class ChatRoom823Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom823Client
    {
        Task SendAsync(ChatRoom823Message message);
    }

    [ChatRoomClient]
    public class ChatRoom823Client: IChatRoom823Client
    {
        private Guid _sender;

        public ChatRoom823Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom823Message message) => Task.CompletedTask;
    }

    public class ChatRoom824Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom824Client
    {
        Task SendAsync(ChatRoom824Message message);
    }

    [ChatRoomClient]
    public class ChatRoom824Client: IChatRoom824Client
    {
        private Guid _sender;

        public ChatRoom824Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom824Message message) => Task.CompletedTask;
    }

    public class ChatRoom825Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom825Client
    {
        Task SendAsync(ChatRoom825Message message);
    }

    [ChatRoomClient]
    public class ChatRoom825Client: IChatRoom825Client
    {
        private Guid _sender;

        public ChatRoom825Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom825Message message) => Task.CompletedTask;
    }

    public class ChatRoom826Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom826Client
    {
        Task SendAsync(ChatRoom826Message message);
    }

    [ChatRoomClient]
    public class ChatRoom826Client: IChatRoom826Client
    {
        private Guid _sender;

        public ChatRoom826Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom826Message message) => Task.CompletedTask;
    }

    public class ChatRoom827Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom827Client
    {
        Task SendAsync(ChatRoom827Message message);
    }

    [ChatRoomClient]
    public class ChatRoom827Client: IChatRoom827Client
    {
        private Guid _sender;

        public ChatRoom827Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom827Message message) => Task.CompletedTask;
    }

    public class ChatRoom828Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom828Client
    {
        Task SendAsync(ChatRoom828Message message);
    }

    [ChatRoomClient]
    public class ChatRoom828Client: IChatRoom828Client
    {
        private Guid _sender;

        public ChatRoom828Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom828Message message) => Task.CompletedTask;
    }

    public class ChatRoom829Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom829Client
    {
        Task SendAsync(ChatRoom829Message message);
    }

    [ChatRoomClient]
    public class ChatRoom829Client: IChatRoom829Client
    {
        private Guid _sender;

        public ChatRoom829Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom829Message message) => Task.CompletedTask;
    }

    public class ChatRoom830Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom830Client
    {
        Task SendAsync(ChatRoom830Message message);
    }

    [ChatRoomClient]
    public class ChatRoom830Client: IChatRoom830Client
    {
        private Guid _sender;

        public ChatRoom830Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom830Message message) => Task.CompletedTask;
    }

    public class ChatRoom831Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom831Client
    {
        Task SendAsync(ChatRoom831Message message);
    }

    [ChatRoomClient]
    public class ChatRoom831Client: IChatRoom831Client
    {
        private Guid _sender;

        public ChatRoom831Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom831Message message) => Task.CompletedTask;
    }

    public class ChatRoom832Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom832Client
    {
        Task SendAsync(ChatRoom832Message message);
    }

    [ChatRoomClient]
    public class ChatRoom832Client: IChatRoom832Client
    {
        private Guid _sender;

        public ChatRoom832Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom832Message message) => Task.CompletedTask;
    }

    public class ChatRoom833Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom833Client
    {
        Task SendAsync(ChatRoom833Message message);
    }

    [ChatRoomClient]
    public class ChatRoom833Client: IChatRoom833Client
    {
        private Guid _sender;

        public ChatRoom833Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom833Message message) => Task.CompletedTask;
    }

    public class ChatRoom834Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom834Client
    {
        Task SendAsync(ChatRoom834Message message);
    }

    [ChatRoomClient]
    public class ChatRoom834Client: IChatRoom834Client
    {
        private Guid _sender;

        public ChatRoom834Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom834Message message) => Task.CompletedTask;
    }

    public class ChatRoom835Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom835Client
    {
        Task SendAsync(ChatRoom835Message message);
    }

    [ChatRoomClient]
    public class ChatRoom835Client: IChatRoom835Client
    {
        private Guid _sender;

        public ChatRoom835Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom835Message message) => Task.CompletedTask;
    }

    public class ChatRoom836Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom836Client
    {
        Task SendAsync(ChatRoom836Message message);
    }

    [ChatRoomClient]
    public class ChatRoom836Client: IChatRoom836Client
    {
        private Guid _sender;

        public ChatRoom836Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom836Message message) => Task.CompletedTask;
    }

    public class ChatRoom837Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom837Client
    {
        Task SendAsync(ChatRoom837Message message);
    }

    [ChatRoomClient]
    public class ChatRoom837Client: IChatRoom837Client
    {
        private Guid _sender;

        public ChatRoom837Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom837Message message) => Task.CompletedTask;
    }

    public class ChatRoom838Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom838Client
    {
        Task SendAsync(ChatRoom838Message message);
    }

    [ChatRoomClient]
    public class ChatRoom838Client: IChatRoom838Client
    {
        private Guid _sender;

        public ChatRoom838Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom838Message message) => Task.CompletedTask;
    }

    public class ChatRoom839Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom839Client
    {
        Task SendAsync(ChatRoom839Message message);
    }

    [ChatRoomClient]
    public class ChatRoom839Client: IChatRoom839Client
    {
        private Guid _sender;

        public ChatRoom839Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom839Message message) => Task.CompletedTask;
    }

    public class ChatRoom840Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom840Client
    {
        Task SendAsync(ChatRoom840Message message);
    }

    [ChatRoomClient]
    public class ChatRoom840Client: IChatRoom840Client
    {
        private Guid _sender;

        public ChatRoom840Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom840Message message) => Task.CompletedTask;
    }

    public class ChatRoom841Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom841Client
    {
        Task SendAsync(ChatRoom841Message message);
    }

    [ChatRoomClient]
    public class ChatRoom841Client: IChatRoom841Client
    {
        private Guid _sender;

        public ChatRoom841Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom841Message message) => Task.CompletedTask;
    }

    public class ChatRoom842Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom842Client
    {
        Task SendAsync(ChatRoom842Message message);
    }

    [ChatRoomClient]
    public class ChatRoom842Client: IChatRoom842Client
    {
        private Guid _sender;

        public ChatRoom842Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom842Message message) => Task.CompletedTask;
    }

    public class ChatRoom843Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom843Client
    {
        Task SendAsync(ChatRoom843Message message);
    }

    [ChatRoomClient]
    public class ChatRoom843Client: IChatRoom843Client
    {
        private Guid _sender;

        public ChatRoom843Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom843Message message) => Task.CompletedTask;
    }

    public class ChatRoom844Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom844Client
    {
        Task SendAsync(ChatRoom844Message message);
    }

    [ChatRoomClient]
    public class ChatRoom844Client: IChatRoom844Client
    {
        private Guid _sender;

        public ChatRoom844Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom844Message message) => Task.CompletedTask;
    }

    public class ChatRoom845Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom845Client
    {
        Task SendAsync(ChatRoom845Message message);
    }

    [ChatRoomClient]
    public class ChatRoom845Client: IChatRoom845Client
    {
        private Guid _sender;

        public ChatRoom845Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom845Message message) => Task.CompletedTask;
    }

    public class ChatRoom846Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom846Client
    {
        Task SendAsync(ChatRoom846Message message);
    }

    [ChatRoomClient]
    public class ChatRoom846Client: IChatRoom846Client
    {
        private Guid _sender;

        public ChatRoom846Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom846Message message) => Task.CompletedTask;
    }

    public class ChatRoom847Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom847Client
    {
        Task SendAsync(ChatRoom847Message message);
    }

    [ChatRoomClient]
    public class ChatRoom847Client: IChatRoom847Client
    {
        private Guid _sender;

        public ChatRoom847Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom847Message message) => Task.CompletedTask;
    }

    public class ChatRoom848Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom848Client
    {
        Task SendAsync(ChatRoom848Message message);
    }

    [ChatRoomClient]
    public class ChatRoom848Client: IChatRoom848Client
    {
        private Guid _sender;

        public ChatRoom848Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom848Message message) => Task.CompletedTask;
    }

    public class ChatRoom849Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom849Client
    {
        Task SendAsync(ChatRoom849Message message);
    }

    [ChatRoomClient]
    public class ChatRoom849Client: IChatRoom849Client
    {
        private Guid _sender;

        public ChatRoom849Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom849Message message) => Task.CompletedTask;
    }

    public class ChatRoom850Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom850Client
    {
        Task SendAsync(ChatRoom850Message message);
    }

    [ChatRoomClient]
    public class ChatRoom850Client: IChatRoom850Client
    {
        private Guid _sender;

        public ChatRoom850Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom850Message message) => Task.CompletedTask;
    }

    public class ChatRoom851Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom851Client
    {
        Task SendAsync(ChatRoom851Message message);
    }

    [ChatRoomClient]
    public class ChatRoom851Client: IChatRoom851Client
    {
        private Guid _sender;

        public ChatRoom851Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom851Message message) => Task.CompletedTask;
    }

    public class ChatRoom852Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom852Client
    {
        Task SendAsync(ChatRoom852Message message);
    }

    [ChatRoomClient]
    public class ChatRoom852Client: IChatRoom852Client
    {
        private Guid _sender;

        public ChatRoom852Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom852Message message) => Task.CompletedTask;
    }

    public class ChatRoom853Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom853Client
    {
        Task SendAsync(ChatRoom853Message message);
    }

    [ChatRoomClient]
    public class ChatRoom853Client: IChatRoom853Client
    {
        private Guid _sender;

        public ChatRoom853Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom853Message message) => Task.CompletedTask;
    }

    public class ChatRoom854Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom854Client
    {
        Task SendAsync(ChatRoom854Message message);
    }

    [ChatRoomClient]
    public class ChatRoom854Client: IChatRoom854Client
    {
        private Guid _sender;

        public ChatRoom854Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom854Message message) => Task.CompletedTask;
    }

    public class ChatRoom855Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom855Client
    {
        Task SendAsync(ChatRoom855Message message);
    }

    [ChatRoomClient]
    public class ChatRoom855Client: IChatRoom855Client
    {
        private Guid _sender;

        public ChatRoom855Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom855Message message) => Task.CompletedTask;
    }

    public class ChatRoom856Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom856Client
    {
        Task SendAsync(ChatRoom856Message message);
    }

    [ChatRoomClient]
    public class ChatRoom856Client: IChatRoom856Client
    {
        private Guid _sender;

        public ChatRoom856Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom856Message message) => Task.CompletedTask;
    }

    public class ChatRoom857Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom857Client
    {
        Task SendAsync(ChatRoom857Message message);
    }

    [ChatRoomClient]
    public class ChatRoom857Client: IChatRoom857Client
    {
        private Guid _sender;

        public ChatRoom857Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom857Message message) => Task.CompletedTask;
    }

    public class ChatRoom858Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom858Client
    {
        Task SendAsync(ChatRoom858Message message);
    }

    [ChatRoomClient]
    public class ChatRoom858Client: IChatRoom858Client
    {
        private Guid _sender;

        public ChatRoom858Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom858Message message) => Task.CompletedTask;
    }

    public class ChatRoom859Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom859Client
    {
        Task SendAsync(ChatRoom859Message message);
    }

    [ChatRoomClient]
    public class ChatRoom859Client: IChatRoom859Client
    {
        private Guid _sender;

        public ChatRoom859Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom859Message message) => Task.CompletedTask;
    }

    public class ChatRoom860Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom860Client
    {
        Task SendAsync(ChatRoom860Message message);
    }

    [ChatRoomClient]
    public class ChatRoom860Client: IChatRoom860Client
    {
        private Guid _sender;

        public ChatRoom860Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom860Message message) => Task.CompletedTask;
    }

    public class ChatRoom861Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom861Client
    {
        Task SendAsync(ChatRoom861Message message);
    }

    [ChatRoomClient]
    public class ChatRoom861Client: IChatRoom861Client
    {
        private Guid _sender;

        public ChatRoom861Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom861Message message) => Task.CompletedTask;
    }

    public class ChatRoom862Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom862Client
    {
        Task SendAsync(ChatRoom862Message message);
    }

    [ChatRoomClient]
    public class ChatRoom862Client: IChatRoom862Client
    {
        private Guid _sender;

        public ChatRoom862Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom862Message message) => Task.CompletedTask;
    }

    public class ChatRoom863Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom863Client
    {
        Task SendAsync(ChatRoom863Message message);
    }

    [ChatRoomClient]
    public class ChatRoom863Client: IChatRoom863Client
    {
        private Guid _sender;

        public ChatRoom863Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom863Message message) => Task.CompletedTask;
    }

    public class ChatRoom864Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom864Client
    {
        Task SendAsync(ChatRoom864Message message);
    }

    [ChatRoomClient]
    public class ChatRoom864Client: IChatRoom864Client
    {
        private Guid _sender;

        public ChatRoom864Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom864Message message) => Task.CompletedTask;
    }

    public class ChatRoom865Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom865Client
    {
        Task SendAsync(ChatRoom865Message message);
    }

    [ChatRoomClient]
    public class ChatRoom865Client: IChatRoom865Client
    {
        private Guid _sender;

        public ChatRoom865Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom865Message message) => Task.CompletedTask;
    }

    public class ChatRoom866Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom866Client
    {
        Task SendAsync(ChatRoom866Message message);
    }

    [ChatRoomClient]
    public class ChatRoom866Client: IChatRoom866Client
    {
        private Guid _sender;

        public ChatRoom866Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom866Message message) => Task.CompletedTask;
    }

    public class ChatRoom867Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom867Client
    {
        Task SendAsync(ChatRoom867Message message);
    }

    [ChatRoomClient]
    public class ChatRoom867Client: IChatRoom867Client
    {
        private Guid _sender;

        public ChatRoom867Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom867Message message) => Task.CompletedTask;
    }

    public class ChatRoom868Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom868Client
    {
        Task SendAsync(ChatRoom868Message message);
    }

    [ChatRoomClient]
    public class ChatRoom868Client: IChatRoom868Client
    {
        private Guid _sender;

        public ChatRoom868Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom868Message message) => Task.CompletedTask;
    }

    public class ChatRoom869Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom869Client
    {
        Task SendAsync(ChatRoom869Message message);
    }

    [ChatRoomClient]
    public class ChatRoom869Client: IChatRoom869Client
    {
        private Guid _sender;

        public ChatRoom869Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom869Message message) => Task.CompletedTask;
    }

    public class ChatRoom870Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom870Client
    {
        Task SendAsync(ChatRoom870Message message);
    }

    [ChatRoomClient]
    public class ChatRoom870Client: IChatRoom870Client
    {
        private Guid _sender;

        public ChatRoom870Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom870Message message) => Task.CompletedTask;
    }

    public class ChatRoom871Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom871Client
    {
        Task SendAsync(ChatRoom871Message message);
    }

    [ChatRoomClient]
    public class ChatRoom871Client: IChatRoom871Client
    {
        private Guid _sender;

        public ChatRoom871Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom871Message message) => Task.CompletedTask;
    }

    public class ChatRoom872Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom872Client
    {
        Task SendAsync(ChatRoom872Message message);
    }

    [ChatRoomClient]
    public class ChatRoom872Client: IChatRoom872Client
    {
        private Guid _sender;

        public ChatRoom872Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom872Message message) => Task.CompletedTask;
    }

    public class ChatRoom873Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom873Client
    {
        Task SendAsync(ChatRoom873Message message);
    }

    [ChatRoomClient]
    public class ChatRoom873Client: IChatRoom873Client
    {
        private Guid _sender;

        public ChatRoom873Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom873Message message) => Task.CompletedTask;
    }

    public class ChatRoom874Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom874Client
    {
        Task SendAsync(ChatRoom874Message message);
    }

    [ChatRoomClient]
    public class ChatRoom874Client: IChatRoom874Client
    {
        private Guid _sender;

        public ChatRoom874Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom874Message message) => Task.CompletedTask;
    }

    public class ChatRoom875Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom875Client
    {
        Task SendAsync(ChatRoom875Message message);
    }

    [ChatRoomClient]
    public class ChatRoom875Client: IChatRoom875Client
    {
        private Guid _sender;

        public ChatRoom875Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom875Message message) => Task.CompletedTask;
    }

    public class ChatRoom876Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom876Client
    {
        Task SendAsync(ChatRoom876Message message);
    }

    [ChatRoomClient]
    public class ChatRoom876Client: IChatRoom876Client
    {
        private Guid _sender;

        public ChatRoom876Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom876Message message) => Task.CompletedTask;
    }

    public class ChatRoom877Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom877Client
    {
        Task SendAsync(ChatRoom877Message message);
    }

    [ChatRoomClient]
    public class ChatRoom877Client: IChatRoom877Client
    {
        private Guid _sender;

        public ChatRoom877Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom877Message message) => Task.CompletedTask;
    }

    public class ChatRoom878Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom878Client
    {
        Task SendAsync(ChatRoom878Message message);
    }

    [ChatRoomClient]
    public class ChatRoom878Client: IChatRoom878Client
    {
        private Guid _sender;

        public ChatRoom878Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom878Message message) => Task.CompletedTask;
    }

    public class ChatRoom879Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom879Client
    {
        Task SendAsync(ChatRoom879Message message);
    }

    [ChatRoomClient]
    public class ChatRoom879Client: IChatRoom879Client
    {
        private Guid _sender;

        public ChatRoom879Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom879Message message) => Task.CompletedTask;
    }

    public class ChatRoom880Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom880Client
    {
        Task SendAsync(ChatRoom880Message message);
    }

    [ChatRoomClient]
    public class ChatRoom880Client: IChatRoom880Client
    {
        private Guid _sender;

        public ChatRoom880Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom880Message message) => Task.CompletedTask;
    }

    public class ChatRoom881Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom881Client
    {
        Task SendAsync(ChatRoom881Message message);
    }

    [ChatRoomClient]
    public class ChatRoom881Client: IChatRoom881Client
    {
        private Guid _sender;

        public ChatRoom881Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom881Message message) => Task.CompletedTask;
    }

    public class ChatRoom882Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom882Client
    {
        Task SendAsync(ChatRoom882Message message);
    }

    [ChatRoomClient]
    public class ChatRoom882Client: IChatRoom882Client
    {
        private Guid _sender;

        public ChatRoom882Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom882Message message) => Task.CompletedTask;
    }

    public class ChatRoom883Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom883Client
    {
        Task SendAsync(ChatRoom883Message message);
    }

    [ChatRoomClient]
    public class ChatRoom883Client: IChatRoom883Client
    {
        private Guid _sender;

        public ChatRoom883Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom883Message message) => Task.CompletedTask;
    }

    public class ChatRoom884Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom884Client
    {
        Task SendAsync(ChatRoom884Message message);
    }

    [ChatRoomClient]
    public class ChatRoom884Client: IChatRoom884Client
    {
        private Guid _sender;

        public ChatRoom884Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom884Message message) => Task.CompletedTask;
    }

    public class ChatRoom885Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom885Client
    {
        Task SendAsync(ChatRoom885Message message);
    }

    [ChatRoomClient]
    public class ChatRoom885Client: IChatRoom885Client
    {
        private Guid _sender;

        public ChatRoom885Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom885Message message) => Task.CompletedTask;
    }

    public class ChatRoom886Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom886Client
    {
        Task SendAsync(ChatRoom886Message message);
    }

    [ChatRoomClient]
    public class ChatRoom886Client: IChatRoom886Client
    {
        private Guid _sender;

        public ChatRoom886Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom886Message message) => Task.CompletedTask;
    }

    public class ChatRoom887Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom887Client
    {
        Task SendAsync(ChatRoom887Message message);
    }

    [ChatRoomClient]
    public class ChatRoom887Client: IChatRoom887Client
    {
        private Guid _sender;

        public ChatRoom887Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom887Message message) => Task.CompletedTask;
    }

    public class ChatRoom888Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom888Client
    {
        Task SendAsync(ChatRoom888Message message);
    }

    [ChatRoomClient]
    public class ChatRoom888Client: IChatRoom888Client
    {
        private Guid _sender;

        public ChatRoom888Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom888Message message) => Task.CompletedTask;
    }

    public class ChatRoom889Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom889Client
    {
        Task SendAsync(ChatRoom889Message message);
    }

    [ChatRoomClient]
    public class ChatRoom889Client: IChatRoom889Client
    {
        private Guid _sender;

        public ChatRoom889Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom889Message message) => Task.CompletedTask;
    }

    public class ChatRoom890Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom890Client
    {
        Task SendAsync(ChatRoom890Message message);
    }

    [ChatRoomClient]
    public class ChatRoom890Client: IChatRoom890Client
    {
        private Guid _sender;

        public ChatRoom890Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom890Message message) => Task.CompletedTask;
    }

    public class ChatRoom891Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom891Client
    {
        Task SendAsync(ChatRoom891Message message);
    }

    [ChatRoomClient]
    public class ChatRoom891Client: IChatRoom891Client
    {
        private Guid _sender;

        public ChatRoom891Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom891Message message) => Task.CompletedTask;
    }

    public class ChatRoom892Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom892Client
    {
        Task SendAsync(ChatRoom892Message message);
    }

    [ChatRoomClient]
    public class ChatRoom892Client: IChatRoom892Client
    {
        private Guid _sender;

        public ChatRoom892Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom892Message message) => Task.CompletedTask;
    }

    public class ChatRoom893Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom893Client
    {
        Task SendAsync(ChatRoom893Message message);
    }

    [ChatRoomClient]
    public class ChatRoom893Client: IChatRoom893Client
    {
        private Guid _sender;

        public ChatRoom893Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom893Message message) => Task.CompletedTask;
    }

    public class ChatRoom894Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom894Client
    {
        Task SendAsync(ChatRoom894Message message);
    }

    [ChatRoomClient]
    public class ChatRoom894Client: IChatRoom894Client
    {
        private Guid _sender;

        public ChatRoom894Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom894Message message) => Task.CompletedTask;
    }

    public class ChatRoom895Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom895Client
    {
        Task SendAsync(ChatRoom895Message message);
    }

    [ChatRoomClient]
    public class ChatRoom895Client: IChatRoom895Client
    {
        private Guid _sender;

        public ChatRoom895Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom895Message message) => Task.CompletedTask;
    }

    public class ChatRoom896Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom896Client
    {
        Task SendAsync(ChatRoom896Message message);
    }

    [ChatRoomClient]
    public class ChatRoom896Client: IChatRoom896Client
    {
        private Guid _sender;

        public ChatRoom896Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom896Message message) => Task.CompletedTask;
    }

    public class ChatRoom897Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom897Client
    {
        Task SendAsync(ChatRoom897Message message);
    }

    [ChatRoomClient]
    public class ChatRoom897Client: IChatRoom897Client
    {
        private Guid _sender;

        public ChatRoom897Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom897Message message) => Task.CompletedTask;
    }

    public class ChatRoom898Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom898Client
    {
        Task SendAsync(ChatRoom898Message message);
    }

    [ChatRoomClient]
    public class ChatRoom898Client: IChatRoom898Client
    {
        private Guid _sender;

        public ChatRoom898Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom898Message message) => Task.CompletedTask;
    }

    public class ChatRoom899Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom899Client
    {
        Task SendAsync(ChatRoom899Message message);
    }

    [ChatRoomClient]
    public class ChatRoom899Client: IChatRoom899Client
    {
        private Guid _sender;

        public ChatRoom899Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom899Message message) => Task.CompletedTask;
    }

    public class ChatRoom900Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom900Client
    {
        Task SendAsync(ChatRoom900Message message);
    }

    [ChatRoomClient]
    public class ChatRoom900Client: IChatRoom900Client
    {
        private Guid _sender;

        public ChatRoom900Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom900Message message) => Task.CompletedTask;
    }

    public class ChatRoom901Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom901Client
    {
        Task SendAsync(ChatRoom901Message message);
    }

    [ChatRoomClient]
    public class ChatRoom901Client: IChatRoom901Client
    {
        private Guid _sender;

        public ChatRoom901Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom901Message message) => Task.CompletedTask;
    }

    public class ChatRoom902Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom902Client
    {
        Task SendAsync(ChatRoom902Message message);
    }

    [ChatRoomClient]
    public class ChatRoom902Client: IChatRoom902Client
    {
        private Guid _sender;

        public ChatRoom902Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom902Message message) => Task.CompletedTask;
    }

    public class ChatRoom903Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom903Client
    {
        Task SendAsync(ChatRoom903Message message);
    }

    [ChatRoomClient]
    public class ChatRoom903Client: IChatRoom903Client
    {
        private Guid _sender;

        public ChatRoom903Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom903Message message) => Task.CompletedTask;
    }

    public class ChatRoom904Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom904Client
    {
        Task SendAsync(ChatRoom904Message message);
    }

    [ChatRoomClient]
    public class ChatRoom904Client: IChatRoom904Client
    {
        private Guid _sender;

        public ChatRoom904Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom904Message message) => Task.CompletedTask;
    }

    public class ChatRoom905Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom905Client
    {
        Task SendAsync(ChatRoom905Message message);
    }

    [ChatRoomClient]
    public class ChatRoom905Client: IChatRoom905Client
    {
        private Guid _sender;

        public ChatRoom905Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom905Message message) => Task.CompletedTask;
    }

    public class ChatRoom906Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom906Client
    {
        Task SendAsync(ChatRoom906Message message);
    }

    [ChatRoomClient]
    public class ChatRoom906Client: IChatRoom906Client
    {
        private Guid _sender;

        public ChatRoom906Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom906Message message) => Task.CompletedTask;
    }

    public class ChatRoom907Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom907Client
    {
        Task SendAsync(ChatRoom907Message message);
    }

    [ChatRoomClient]
    public class ChatRoom907Client: IChatRoom907Client
    {
        private Guid _sender;

        public ChatRoom907Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom907Message message) => Task.CompletedTask;
    }

    public class ChatRoom908Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom908Client
    {
        Task SendAsync(ChatRoom908Message message);
    }

    [ChatRoomClient]
    public class ChatRoom908Client: IChatRoom908Client
    {
        private Guid _sender;

        public ChatRoom908Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom908Message message) => Task.CompletedTask;
    }

    public class ChatRoom909Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom909Client
    {
        Task SendAsync(ChatRoom909Message message);
    }

    [ChatRoomClient]
    public class ChatRoom909Client: IChatRoom909Client
    {
        private Guid _sender;

        public ChatRoom909Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom909Message message) => Task.CompletedTask;
    }

    public class ChatRoom910Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom910Client
    {
        Task SendAsync(ChatRoom910Message message);
    }

    [ChatRoomClient]
    public class ChatRoom910Client: IChatRoom910Client
    {
        private Guid _sender;

        public ChatRoom910Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom910Message message) => Task.CompletedTask;
    }

    public class ChatRoom911Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom911Client
    {
        Task SendAsync(ChatRoom911Message message);
    }

    [ChatRoomClient]
    public class ChatRoom911Client: IChatRoom911Client
    {
        private Guid _sender;

        public ChatRoom911Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom911Message message) => Task.CompletedTask;
    }

    public class ChatRoom912Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom912Client
    {
        Task SendAsync(ChatRoom912Message message);
    }

    [ChatRoomClient]
    public class ChatRoom912Client: IChatRoom912Client
    {
        private Guid _sender;

        public ChatRoom912Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom912Message message) => Task.CompletedTask;
    }

    public class ChatRoom913Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom913Client
    {
        Task SendAsync(ChatRoom913Message message);
    }

    [ChatRoomClient]
    public class ChatRoom913Client: IChatRoom913Client
    {
        private Guid _sender;

        public ChatRoom913Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom913Message message) => Task.CompletedTask;
    }

    public class ChatRoom914Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom914Client
    {
        Task SendAsync(ChatRoom914Message message);
    }

    [ChatRoomClient]
    public class ChatRoom914Client: IChatRoom914Client
    {
        private Guid _sender;

        public ChatRoom914Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom914Message message) => Task.CompletedTask;
    }

    public class ChatRoom915Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom915Client
    {
        Task SendAsync(ChatRoom915Message message);
    }

    [ChatRoomClient]
    public class ChatRoom915Client: IChatRoom915Client
    {
        private Guid _sender;

        public ChatRoom915Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom915Message message) => Task.CompletedTask;
    }

    public class ChatRoom916Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom916Client
    {
        Task SendAsync(ChatRoom916Message message);
    }

    [ChatRoomClient]
    public class ChatRoom916Client: IChatRoom916Client
    {
        private Guid _sender;

        public ChatRoom916Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom916Message message) => Task.CompletedTask;
    }

    public class ChatRoom917Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom917Client
    {
        Task SendAsync(ChatRoom917Message message);
    }

    [ChatRoomClient]
    public class ChatRoom917Client: IChatRoom917Client
    {
        private Guid _sender;

        public ChatRoom917Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom917Message message) => Task.CompletedTask;
    }

    public class ChatRoom918Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom918Client
    {
        Task SendAsync(ChatRoom918Message message);
    }

    [ChatRoomClient]
    public class ChatRoom918Client: IChatRoom918Client
    {
        private Guid _sender;

        public ChatRoom918Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom918Message message) => Task.CompletedTask;
    }

    public class ChatRoom919Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom919Client
    {
        Task SendAsync(ChatRoom919Message message);
    }

    [ChatRoomClient]
    public class ChatRoom919Client: IChatRoom919Client
    {
        private Guid _sender;

        public ChatRoom919Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom919Message message) => Task.CompletedTask;
    }

    public class ChatRoom920Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom920Client
    {
        Task SendAsync(ChatRoom920Message message);
    }

    [ChatRoomClient]
    public class ChatRoom920Client: IChatRoom920Client
    {
        private Guid _sender;

        public ChatRoom920Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom920Message message) => Task.CompletedTask;
    }

    public class ChatRoom921Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom921Client
    {
        Task SendAsync(ChatRoom921Message message);
    }

    [ChatRoomClient]
    public class ChatRoom921Client: IChatRoom921Client
    {
        private Guid _sender;

        public ChatRoom921Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom921Message message) => Task.CompletedTask;
    }

    public class ChatRoom922Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom922Client
    {
        Task SendAsync(ChatRoom922Message message);
    }

    [ChatRoomClient]
    public class ChatRoom922Client: IChatRoom922Client
    {
        private Guid _sender;

        public ChatRoom922Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom922Message message) => Task.CompletedTask;
    }

    public class ChatRoom923Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom923Client
    {
        Task SendAsync(ChatRoom923Message message);
    }

    [ChatRoomClient]
    public class ChatRoom923Client: IChatRoom923Client
    {
        private Guid _sender;

        public ChatRoom923Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom923Message message) => Task.CompletedTask;
    }

    public class ChatRoom924Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom924Client
    {
        Task SendAsync(ChatRoom924Message message);
    }

    [ChatRoomClient]
    public class ChatRoom924Client: IChatRoom924Client
    {
        private Guid _sender;

        public ChatRoom924Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom924Message message) => Task.CompletedTask;
    }

    public class ChatRoom925Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom925Client
    {
        Task SendAsync(ChatRoom925Message message);
    }

    [ChatRoomClient]
    public class ChatRoom925Client: IChatRoom925Client
    {
        private Guid _sender;

        public ChatRoom925Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom925Message message) => Task.CompletedTask;
    }

    public class ChatRoom926Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom926Client
    {
        Task SendAsync(ChatRoom926Message message);
    }

    [ChatRoomClient]
    public class ChatRoom926Client: IChatRoom926Client
    {
        private Guid _sender;

        public ChatRoom926Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom926Message message) => Task.CompletedTask;
    }

    public class ChatRoom927Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom927Client
    {
        Task SendAsync(ChatRoom927Message message);
    }

    [ChatRoomClient]
    public class ChatRoom927Client: IChatRoom927Client
    {
        private Guid _sender;

        public ChatRoom927Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom927Message message) => Task.CompletedTask;
    }

    public class ChatRoom928Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom928Client
    {
        Task SendAsync(ChatRoom928Message message);
    }

    [ChatRoomClient]
    public class ChatRoom928Client: IChatRoom928Client
    {
        private Guid _sender;

        public ChatRoom928Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom928Message message) => Task.CompletedTask;
    }

    public class ChatRoom929Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom929Client
    {
        Task SendAsync(ChatRoom929Message message);
    }

    [ChatRoomClient]
    public class ChatRoom929Client: IChatRoom929Client
    {
        private Guid _sender;

        public ChatRoom929Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom929Message message) => Task.CompletedTask;
    }

    public class ChatRoom930Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom930Client
    {
        Task SendAsync(ChatRoom930Message message);
    }

    [ChatRoomClient]
    public class ChatRoom930Client: IChatRoom930Client
    {
        private Guid _sender;

        public ChatRoom930Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom930Message message) => Task.CompletedTask;
    }

    public class ChatRoom931Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom931Client
    {
        Task SendAsync(ChatRoom931Message message);
    }

    [ChatRoomClient]
    public class ChatRoom931Client: IChatRoom931Client
    {
        private Guid _sender;

        public ChatRoom931Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom931Message message) => Task.CompletedTask;
    }

    public class ChatRoom932Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom932Client
    {
        Task SendAsync(ChatRoom932Message message);
    }

    [ChatRoomClient]
    public class ChatRoom932Client: IChatRoom932Client
    {
        private Guid _sender;

        public ChatRoom932Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom932Message message) => Task.CompletedTask;
    }

    public class ChatRoom933Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom933Client
    {
        Task SendAsync(ChatRoom933Message message);
    }

    [ChatRoomClient]
    public class ChatRoom933Client: IChatRoom933Client
    {
        private Guid _sender;

        public ChatRoom933Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom933Message message) => Task.CompletedTask;
    }

    public class ChatRoom934Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom934Client
    {
        Task SendAsync(ChatRoom934Message message);
    }

    [ChatRoomClient]
    public class ChatRoom934Client: IChatRoom934Client
    {
        private Guid _sender;

        public ChatRoom934Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom934Message message) => Task.CompletedTask;
    }

    public class ChatRoom935Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom935Client
    {
        Task SendAsync(ChatRoom935Message message);
    }

    [ChatRoomClient]
    public class ChatRoom935Client: IChatRoom935Client
    {
        private Guid _sender;

        public ChatRoom935Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom935Message message) => Task.CompletedTask;
    }

    public class ChatRoom936Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom936Client
    {
        Task SendAsync(ChatRoom936Message message);
    }

    [ChatRoomClient]
    public class ChatRoom936Client: IChatRoom936Client
    {
        private Guid _sender;

        public ChatRoom936Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom936Message message) => Task.CompletedTask;
    }

    public class ChatRoom937Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom937Client
    {
        Task SendAsync(ChatRoom937Message message);
    }

    [ChatRoomClient]
    public class ChatRoom937Client: IChatRoom937Client
    {
        private Guid _sender;

        public ChatRoom937Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom937Message message) => Task.CompletedTask;
    }

    public class ChatRoom938Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom938Client
    {
        Task SendAsync(ChatRoom938Message message);
    }

    [ChatRoomClient]
    public class ChatRoom938Client: IChatRoom938Client
    {
        private Guid _sender;

        public ChatRoom938Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom938Message message) => Task.CompletedTask;
    }

    public class ChatRoom939Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom939Client
    {
        Task SendAsync(ChatRoom939Message message);
    }

    [ChatRoomClient]
    public class ChatRoom939Client: IChatRoom939Client
    {
        private Guid _sender;

        public ChatRoom939Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom939Message message) => Task.CompletedTask;
    }

    public class ChatRoom940Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom940Client
    {
        Task SendAsync(ChatRoom940Message message);
    }

    [ChatRoomClient]
    public class ChatRoom940Client: IChatRoom940Client
    {
        private Guid _sender;

        public ChatRoom940Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom940Message message) => Task.CompletedTask;
    }

    public class ChatRoom941Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom941Client
    {
        Task SendAsync(ChatRoom941Message message);
    }

    [ChatRoomClient]
    public class ChatRoom941Client: IChatRoom941Client
    {
        private Guid _sender;

        public ChatRoom941Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom941Message message) => Task.CompletedTask;
    }

    public class ChatRoom942Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom942Client
    {
        Task SendAsync(ChatRoom942Message message);
    }

    [ChatRoomClient]
    public class ChatRoom942Client: IChatRoom942Client
    {
        private Guid _sender;

        public ChatRoom942Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom942Message message) => Task.CompletedTask;
    }

    public class ChatRoom943Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom943Client
    {
        Task SendAsync(ChatRoom943Message message);
    }

    [ChatRoomClient]
    public class ChatRoom943Client: IChatRoom943Client
    {
        private Guid _sender;

        public ChatRoom943Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom943Message message) => Task.CompletedTask;
    }

    public class ChatRoom944Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom944Client
    {
        Task SendAsync(ChatRoom944Message message);
    }

    [ChatRoomClient]
    public class ChatRoom944Client: IChatRoom944Client
    {
        private Guid _sender;

        public ChatRoom944Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom944Message message) => Task.CompletedTask;
    }

    public class ChatRoom945Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom945Client
    {
        Task SendAsync(ChatRoom945Message message);
    }

    [ChatRoomClient]
    public class ChatRoom945Client: IChatRoom945Client
    {
        private Guid _sender;

        public ChatRoom945Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom945Message message) => Task.CompletedTask;
    }

    public class ChatRoom946Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom946Client
    {
        Task SendAsync(ChatRoom946Message message);
    }

    [ChatRoomClient]
    public class ChatRoom946Client: IChatRoom946Client
    {
        private Guid _sender;

        public ChatRoom946Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom946Message message) => Task.CompletedTask;
    }

    public class ChatRoom947Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom947Client
    {
        Task SendAsync(ChatRoom947Message message);
    }

    [ChatRoomClient]
    public class ChatRoom947Client: IChatRoom947Client
    {
        private Guid _sender;

        public ChatRoom947Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom947Message message) => Task.CompletedTask;
    }

    public class ChatRoom948Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom948Client
    {
        Task SendAsync(ChatRoom948Message message);
    }

    [ChatRoomClient]
    public class ChatRoom948Client: IChatRoom948Client
    {
        private Guid _sender;

        public ChatRoom948Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom948Message message) => Task.CompletedTask;
    }

    public class ChatRoom949Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom949Client
    {
        Task SendAsync(ChatRoom949Message message);
    }

    [ChatRoomClient]
    public class ChatRoom949Client: IChatRoom949Client
    {
        private Guid _sender;

        public ChatRoom949Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom949Message message) => Task.CompletedTask;
    }

    public class ChatRoom950Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom950Client
    {
        Task SendAsync(ChatRoom950Message message);
    }

    [ChatRoomClient]
    public class ChatRoom950Client: IChatRoom950Client
    {
        private Guid _sender;

        public ChatRoom950Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom950Message message) => Task.CompletedTask;
    }

    public class ChatRoom951Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom951Client
    {
        Task SendAsync(ChatRoom951Message message);
    }

    [ChatRoomClient]
    public class ChatRoom951Client: IChatRoom951Client
    {
        private Guid _sender;

        public ChatRoom951Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom951Message message) => Task.CompletedTask;
    }

    public class ChatRoom952Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom952Client
    {
        Task SendAsync(ChatRoom952Message message);
    }

    [ChatRoomClient]
    public class ChatRoom952Client: IChatRoom952Client
    {
        private Guid _sender;

        public ChatRoom952Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom952Message message) => Task.CompletedTask;
    }

    public class ChatRoom953Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom953Client
    {
        Task SendAsync(ChatRoom953Message message);
    }

    [ChatRoomClient]
    public class ChatRoom953Client: IChatRoom953Client
    {
        private Guid _sender;

        public ChatRoom953Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom953Message message) => Task.CompletedTask;
    }

    public class ChatRoom954Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom954Client
    {
        Task SendAsync(ChatRoom954Message message);
    }

    [ChatRoomClient]
    public class ChatRoom954Client: IChatRoom954Client
    {
        private Guid _sender;

        public ChatRoom954Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom954Message message) => Task.CompletedTask;
    }

    public class ChatRoom955Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom955Client
    {
        Task SendAsync(ChatRoom955Message message);
    }

    [ChatRoomClient]
    public class ChatRoom955Client: IChatRoom955Client
    {
        private Guid _sender;

        public ChatRoom955Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom955Message message) => Task.CompletedTask;
    }

    public class ChatRoom956Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom956Client
    {
        Task SendAsync(ChatRoom956Message message);
    }

    [ChatRoomClient]
    public class ChatRoom956Client: IChatRoom956Client
    {
        private Guid _sender;

        public ChatRoom956Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom956Message message) => Task.CompletedTask;
    }

    public class ChatRoom957Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom957Client
    {
        Task SendAsync(ChatRoom957Message message);
    }

    [ChatRoomClient]
    public class ChatRoom957Client: IChatRoom957Client
    {
        private Guid _sender;

        public ChatRoom957Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom957Message message) => Task.CompletedTask;
    }

    public class ChatRoom958Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom958Client
    {
        Task SendAsync(ChatRoom958Message message);
    }

    [ChatRoomClient]
    public class ChatRoom958Client: IChatRoom958Client
    {
        private Guid _sender;

        public ChatRoom958Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom958Message message) => Task.CompletedTask;
    }

    public class ChatRoom959Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom959Client
    {
        Task SendAsync(ChatRoom959Message message);
    }

    [ChatRoomClient]
    public class ChatRoom959Client: IChatRoom959Client
    {
        private Guid _sender;

        public ChatRoom959Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom959Message message) => Task.CompletedTask;
    }

    public class ChatRoom960Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom960Client
    {
        Task SendAsync(ChatRoom960Message message);
    }

    [ChatRoomClient]
    public class ChatRoom960Client: IChatRoom960Client
    {
        private Guid _sender;

        public ChatRoom960Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom960Message message) => Task.CompletedTask;
    }

    public class ChatRoom961Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom961Client
    {
        Task SendAsync(ChatRoom961Message message);
    }

    [ChatRoomClient]
    public class ChatRoom961Client: IChatRoom961Client
    {
        private Guid _sender;

        public ChatRoom961Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom961Message message) => Task.CompletedTask;
    }

    public class ChatRoom962Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom962Client
    {
        Task SendAsync(ChatRoom962Message message);
    }

    [ChatRoomClient]
    public class ChatRoom962Client: IChatRoom962Client
    {
        private Guid _sender;

        public ChatRoom962Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom962Message message) => Task.CompletedTask;
    }

    public class ChatRoom963Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom963Client
    {
        Task SendAsync(ChatRoom963Message message);
    }

    [ChatRoomClient]
    public class ChatRoom963Client: IChatRoom963Client
    {
        private Guid _sender;

        public ChatRoom963Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom963Message message) => Task.CompletedTask;
    }

    public class ChatRoom964Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom964Client
    {
        Task SendAsync(ChatRoom964Message message);
    }

    [ChatRoomClient]
    public class ChatRoom964Client: IChatRoom964Client
    {
        private Guid _sender;

        public ChatRoom964Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom964Message message) => Task.CompletedTask;
    }

    public class ChatRoom965Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom965Client
    {
        Task SendAsync(ChatRoom965Message message);
    }

    [ChatRoomClient]
    public class ChatRoom965Client: IChatRoom965Client
    {
        private Guid _sender;

        public ChatRoom965Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom965Message message) => Task.CompletedTask;
    }

    public class ChatRoom966Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom966Client
    {
        Task SendAsync(ChatRoom966Message message);
    }

    [ChatRoomClient]
    public class ChatRoom966Client: IChatRoom966Client
    {
        private Guid _sender;

        public ChatRoom966Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom966Message message) => Task.CompletedTask;
    }

    public class ChatRoom967Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom967Client
    {
        Task SendAsync(ChatRoom967Message message);
    }

    [ChatRoomClient]
    public class ChatRoom967Client: IChatRoom967Client
    {
        private Guid _sender;

        public ChatRoom967Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom967Message message) => Task.CompletedTask;
    }

    public class ChatRoom968Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom968Client
    {
        Task SendAsync(ChatRoom968Message message);
    }

    [ChatRoomClient]
    public class ChatRoom968Client: IChatRoom968Client
    {
        private Guid _sender;

        public ChatRoom968Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom968Message message) => Task.CompletedTask;
    }

    public class ChatRoom969Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom969Client
    {
        Task SendAsync(ChatRoom969Message message);
    }

    [ChatRoomClient]
    public class ChatRoom969Client: IChatRoom969Client
    {
        private Guid _sender;

        public ChatRoom969Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom969Message message) => Task.CompletedTask;
    }

    public class ChatRoom970Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom970Client
    {
        Task SendAsync(ChatRoom970Message message);
    }

    [ChatRoomClient]
    public class ChatRoom970Client: IChatRoom970Client
    {
        private Guid _sender;

        public ChatRoom970Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom970Message message) => Task.CompletedTask;
    }

    public class ChatRoom971Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom971Client
    {
        Task SendAsync(ChatRoom971Message message);
    }

    [ChatRoomClient]
    public class ChatRoom971Client: IChatRoom971Client
    {
        private Guid _sender;

        public ChatRoom971Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom971Message message) => Task.CompletedTask;
    }

    public class ChatRoom972Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom972Client
    {
        Task SendAsync(ChatRoom972Message message);
    }

    [ChatRoomClient]
    public class ChatRoom972Client: IChatRoom972Client
    {
        private Guid _sender;

        public ChatRoom972Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom972Message message) => Task.CompletedTask;
    }

    public class ChatRoom973Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom973Client
    {
        Task SendAsync(ChatRoom973Message message);
    }

    [ChatRoomClient]
    public class ChatRoom973Client: IChatRoom973Client
    {
        private Guid _sender;

        public ChatRoom973Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom973Message message) => Task.CompletedTask;
    }

    public class ChatRoom974Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom974Client
    {
        Task SendAsync(ChatRoom974Message message);
    }

    [ChatRoomClient]
    public class ChatRoom974Client: IChatRoom974Client
    {
        private Guid _sender;

        public ChatRoom974Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom974Message message) => Task.CompletedTask;
    }

    public class ChatRoom975Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom975Client
    {
        Task SendAsync(ChatRoom975Message message);
    }

    [ChatRoomClient]
    public class ChatRoom975Client: IChatRoom975Client
    {
        private Guid _sender;

        public ChatRoom975Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom975Message message) => Task.CompletedTask;
    }

    public class ChatRoom976Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom976Client
    {
        Task SendAsync(ChatRoom976Message message);
    }

    [ChatRoomClient]
    public class ChatRoom976Client: IChatRoom976Client
    {
        private Guid _sender;

        public ChatRoom976Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom976Message message) => Task.CompletedTask;
    }

    public class ChatRoom977Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom977Client
    {
        Task SendAsync(ChatRoom977Message message);
    }

    [ChatRoomClient]
    public class ChatRoom977Client: IChatRoom977Client
    {
        private Guid _sender;

        public ChatRoom977Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom977Message message) => Task.CompletedTask;
    }

    public class ChatRoom978Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom978Client
    {
        Task SendAsync(ChatRoom978Message message);
    }

    [ChatRoomClient]
    public class ChatRoom978Client: IChatRoom978Client
    {
        private Guid _sender;

        public ChatRoom978Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom978Message message) => Task.CompletedTask;
    }

    public class ChatRoom979Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom979Client
    {
        Task SendAsync(ChatRoom979Message message);
    }

    [ChatRoomClient]
    public class ChatRoom979Client: IChatRoom979Client
    {
        private Guid _sender;

        public ChatRoom979Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom979Message message) => Task.CompletedTask;
    }

    public class ChatRoom980Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom980Client
    {
        Task SendAsync(ChatRoom980Message message);
    }

    [ChatRoomClient]
    public class ChatRoom980Client: IChatRoom980Client
    {
        private Guid _sender;

        public ChatRoom980Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom980Message message) => Task.CompletedTask;
    }

    public class ChatRoom981Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom981Client
    {
        Task SendAsync(ChatRoom981Message message);
    }

    [ChatRoomClient]
    public class ChatRoom981Client: IChatRoom981Client
    {
        private Guid _sender;

        public ChatRoom981Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom981Message message) => Task.CompletedTask;
    }

    public class ChatRoom982Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom982Client
    {
        Task SendAsync(ChatRoom982Message message);
    }

    [ChatRoomClient]
    public class ChatRoom982Client: IChatRoom982Client
    {
        private Guid _sender;

        public ChatRoom982Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom982Message message) => Task.CompletedTask;
    }

    public class ChatRoom983Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom983Client
    {
        Task SendAsync(ChatRoom983Message message);
    }

    [ChatRoomClient]
    public class ChatRoom983Client: IChatRoom983Client
    {
        private Guid _sender;

        public ChatRoom983Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom983Message message) => Task.CompletedTask;
    }

    public class ChatRoom984Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom984Client
    {
        Task SendAsync(ChatRoom984Message message);
    }

    [ChatRoomClient]
    public class ChatRoom984Client: IChatRoom984Client
    {
        private Guid _sender;

        public ChatRoom984Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom984Message message) => Task.CompletedTask;
    }

    public class ChatRoom985Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom985Client
    {
        Task SendAsync(ChatRoom985Message message);
    }

    [ChatRoomClient]
    public class ChatRoom985Client: IChatRoom985Client
    {
        private Guid _sender;

        public ChatRoom985Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom985Message message) => Task.CompletedTask;
    }

    public class ChatRoom986Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom986Client
    {
        Task SendAsync(ChatRoom986Message message);
    }

    [ChatRoomClient]
    public class ChatRoom986Client: IChatRoom986Client
    {
        private Guid _sender;

        public ChatRoom986Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom986Message message) => Task.CompletedTask;
    }

    public class ChatRoom987Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom987Client
    {
        Task SendAsync(ChatRoom987Message message);
    }

    [ChatRoomClient]
    public class ChatRoom987Client: IChatRoom987Client
    {
        private Guid _sender;

        public ChatRoom987Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom987Message message) => Task.CompletedTask;
    }

    public class ChatRoom988Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom988Client
    {
        Task SendAsync(ChatRoom988Message message);
    }

    [ChatRoomClient]
    public class ChatRoom988Client: IChatRoom988Client
    {
        private Guid _sender;

        public ChatRoom988Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom988Message message) => Task.CompletedTask;
    }

    public class ChatRoom989Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom989Client
    {
        Task SendAsync(ChatRoom989Message message);
    }

    [ChatRoomClient]
    public class ChatRoom989Client: IChatRoom989Client
    {
        private Guid _sender;

        public ChatRoom989Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom989Message message) => Task.CompletedTask;
    }

    public class ChatRoom990Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom990Client
    {
        Task SendAsync(ChatRoom990Message message);
    }

    [ChatRoomClient]
    public class ChatRoom990Client: IChatRoom990Client
    {
        private Guid _sender;

        public ChatRoom990Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom990Message message) => Task.CompletedTask;
    }

    public class ChatRoom991Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom991Client
    {
        Task SendAsync(ChatRoom991Message message);
    }

    [ChatRoomClient]
    public class ChatRoom991Client: IChatRoom991Client
    {
        private Guid _sender;

        public ChatRoom991Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom991Message message) => Task.CompletedTask;
    }

    public class ChatRoom992Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom992Client
    {
        Task SendAsync(ChatRoom992Message message);
    }

    [ChatRoomClient]
    public class ChatRoom992Client: IChatRoom992Client
    {
        private Guid _sender;

        public ChatRoom992Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom992Message message) => Task.CompletedTask;
    }

    public class ChatRoom993Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom993Client
    {
        Task SendAsync(ChatRoom993Message message);
    }

    [ChatRoomClient]
    public class ChatRoom993Client: IChatRoom993Client
    {
        private Guid _sender;

        public ChatRoom993Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom993Message message) => Task.CompletedTask;
    }

    public class ChatRoom994Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom994Client
    {
        Task SendAsync(ChatRoom994Message message);
    }

    [ChatRoomClient]
    public class ChatRoom994Client: IChatRoom994Client
    {
        private Guid _sender;

        public ChatRoom994Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom994Message message) => Task.CompletedTask;
    }

    public class ChatRoom995Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom995Client
    {
        Task SendAsync(ChatRoom995Message message);
    }

    [ChatRoomClient]
    public class ChatRoom995Client: IChatRoom995Client
    {
        private Guid _sender;

        public ChatRoom995Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom995Message message) => Task.CompletedTask;
    }

    public class ChatRoom996Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom996Client
    {
        Task SendAsync(ChatRoom996Message message);
    }

    [ChatRoomClient]
    public class ChatRoom996Client: IChatRoom996Client
    {
        private Guid _sender;

        public ChatRoom996Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom996Message message) => Task.CompletedTask;
    }

    public class ChatRoom997Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom997Client
    {
        Task SendAsync(ChatRoom997Message message);
    }

    [ChatRoomClient]
    public class ChatRoom997Client: IChatRoom997Client
    {
        private Guid _sender;

        public ChatRoom997Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom997Message message) => Task.CompletedTask;
    }

    public class ChatRoom998Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom998Client
    {
        Task SendAsync(ChatRoom998Message message);
    }

    [ChatRoomClient]
    public class ChatRoom998Client: IChatRoom998Client
    {
        private Guid _sender;

        public ChatRoom998Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom998Message message) => Task.CompletedTask;
    }

    public class ChatRoom999Message
    {
        public Guid Id { get; }
        
        public string? Text { get; }
        
        public Guid To { get; }
    }
    
    public interface IChatRoom999Client
    {
        Task SendAsync(ChatRoom999Message message);
    }

    [ChatRoomClient]
    public class ChatRoom999Client: IChatRoom999Client
    {
        private Guid _sender;

        public ChatRoom999Client(Guid sender)
        {
            _sender = sender;
        }
        
        public Task SendAsync(ChatRoom999Message message) => Task.CompletedTask;
    }

}
