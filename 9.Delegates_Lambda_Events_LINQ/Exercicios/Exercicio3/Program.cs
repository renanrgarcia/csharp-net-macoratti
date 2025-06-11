WelcomeMessage welcomeMessage = PortugueseWelcome;
welcomeMessage += EnglishWelcome;

welcomeMessage();
// Output:
// "Bem-vindo!"
// "Welcome!"

void PortugueseWelcome() => Console.WriteLine("Bem-vindo!");
void EnglishWelcome() => Console.WriteLine("Welcome!");

delegate void WelcomeMessage();