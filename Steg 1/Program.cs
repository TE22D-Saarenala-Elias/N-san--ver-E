if (6 >=3)
{
    Console.WriteLine("Hello, World!");
}


string Lösenord = "";
string Användarnamn ="";
while(!(Användarnamn=="kalleanka" && Lösenord=="12345"))
{
Användarnamn = Console.ReadLine();
Lösenord = Console.ReadLine();
    if (Användarnamn=="kalleanka" && Lösenord=="12345")
        {
            Console.WriteLine("Welcome");
        }
    else
        {
            Console.WriteLine("Wrong username or password");
        }
}


for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello, World");
}
string input;
int Numer;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Skriv ett numer");
    input=Console.ReadLine();
    while (!int.TryParse(input, out Numer))
    {

        Console.WriteLine(" Skriv ett numer!");
        input=Console.ReadLine();
    }

    if (Numer>5)
    {
        Console.WriteLine("högre än 5!");
    }
}

Console.ReadLine();