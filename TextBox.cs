namespace ViniMediator;

public class TextBox : Component
{
    public string Text { get; set; } = string.Empty;

    public void Input(string value)
    {
        Text = value;
        _mediator.Send(this, Text);
    }
}