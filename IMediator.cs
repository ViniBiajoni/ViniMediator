namespace ViniMediator;

public interface IMediator
{
    void Send(object sender, string @event);
}