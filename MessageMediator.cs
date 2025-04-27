namespace ViniMediator;

public class MessageMediator : IMediator
{

    public TextBox TextBox { get; set; } = null!;
    public CheckBox CheckBox { get; set; } = null!;
    public Button Button { get; set; } = null!;
    
    public void Send(object sender, string message)
    {
        
        if (sender is TextBox)
            Console.WriteLine(message);
        
        if (sender is CheckBox)
            Console.WriteLine($"CheckBox clicked :{message}");
        
        if (sender is Button)
            Console.WriteLine($"Button clicked :{message}");
      
    }
}