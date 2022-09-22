// See https://aka.ms/new-console-template for more information
static void Main(string[]arhs)
{
Console.Title = "C#"; //det laver om på navet af siden

Console.ForegroundColor = ConsoleColor.DarkBlue; //laver skriftensfave om

Console.WindowHeight = 25; // det er højten på windows
Console.WindowWidth = 85;


Console.WriteLine("Hej hvad er dit nave, ville gerne vide hvem du er ");

string naven = Console.ReadLine();

Console.WriteLine("okay " + naven + " Det er ikke et dårligt naven at have, der findes være vel.\nNå ikke mere om dig her ville jeg gerne vise dig hvad jeg har fået lavet i c#.\n\nMen du skal være gamle nok så hvor gamle er du så");

int svar = Convert.ToInt32(Console.ReadLine());

if(svar < 18)
{
Console.WriteLine("\nokay det ser ud til at du ikke er gamle nok du må have en god dag");
Console.ReadLine();
Console.WriteLine("luke ned få at komme videre");
Console.ReadLine();
Console.ReadLine();
Console.ReadLine();
Console.ReadLine();
Console.ReadLine();
Console.ReadLine();     // kunne ikke finde ud af at tvinge den til at lukke ned
}

else
{
Console.WriteLine("\nDet var godt at du er gammel nok");
}
Console.WriteLine("her er en liste af af serier jeg kan lide");
string[] serie =
{
"\ngame of thrones",
"\nThe Flash",
"\nRick and Morty",
"\nGurli Gris",
"\nHouse of the Dragon",
"\nStranger Things"

};
for (int i = 0; i < serie.Length; i++)
{
     Console.WriteLine(serie[i]);                   
}

string[]serier = new string [3];

Console.WriteLine("hvad er så 3 serier du kan lige ");

for (int i = 0; i < serier.Length; i++)
{
 serier[i] = Console.ReadLine();                       
}

Console.WriteLine("okay det er da ikke dåligt jeg har lige sat dem op i abs rækkefølge");

Array.Sort(serier);

for (int i = 0; i < serier.Length; i++)
{
         Console.WriteLine(serier[i]);            
}


//int nummer01;
//int nummer02
Console.ReadKey();
}
