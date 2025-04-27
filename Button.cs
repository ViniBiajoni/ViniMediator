namespace ViniMediator;

public class Button : Component
{
    public bool IsEnabled { get; set; }
    private int TotalClicks { get; set; } = 0;

    public void Click()
    {
        TotalClicks++;
        _mediator.Send(this, $"Button clicked {TotalClicks} times");            
    }
}