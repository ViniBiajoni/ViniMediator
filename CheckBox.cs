namespace ViniMediator;

public class CheckBox : Component
{
    public bool IsChecked { get; set; }

    public void Toggle()
    {
        IsChecked = !IsChecked;
        _mediator.Send(this, $"Toggle -> State is {IsChecked}");
    }
}
