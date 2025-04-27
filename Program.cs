using ViniMediator;

var textBox = new TextBox();
var checkBox = new CheckBox();
var button = new Button();

var mediador = new MessageMediator()
{
    TextBox = textBox,
    CheckBox = checkBox,
    Button = button
};

textBox.SetMediator(mediador);
checkBox.SetMediator(mediador);
button.SetMediator(mediador);

button.Click();
textBox.Input("Primeiro input");
checkBox.Toggle();
button.Click();
checkBox.Toggle();



