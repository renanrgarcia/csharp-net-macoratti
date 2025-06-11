void PortugueseWelcome() => Console.WriteLine("Bem-vindo!");
void EnglishWelcome() => Console.WriteLine("Welcome!");

WelcomeMessage welcomeMessage = PortugueseWelcome;
welcomeMessage += EnglishWelcome;

welcomeMessage();
// Output:
// "Bem-vindo!"
// "Welcome!"

delegate void WelcomeMessage();