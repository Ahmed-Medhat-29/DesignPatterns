namespace Mediator;

interface IChatRoom
{
    void Register(TeamMember teamMember);
    void Send(string from, string message);
    void Send(string from, string to, string message);
    void Send<T>(string from, string message) where T : TeamMember;
}
