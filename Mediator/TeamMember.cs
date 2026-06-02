namespace Mediator;

abstract class TeamMember
{
    private IChatRoom _chatRoom;

    public string Name { get; }

    public TeamMember(string name)
    {
        Name = name;
    }

    public void SetChatRoom(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        _chatRoom?.Send(Name, message);
    }

    public void Send(string to, string message)
    {
        _chatRoom?.Send(Name,  to, message);
    }

    public void SendTo<T>(string message) where T : TeamMember
    {
        _chatRoom?.Send<T>(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        System.Console.WriteLine($"Message {from} to {Name}: {message}");
    }
}
