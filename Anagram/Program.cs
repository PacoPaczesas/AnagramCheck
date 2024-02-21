Console.WriteLine("Program sprawdza czy dwa podane ciagi znaków (string) są anagramami");
Console.Write("Wprowadź pierwszy ciąg znaków: ");
string s1 = Console.ReadLine();
Console.Write("Wprowadź drugi ciąg znaków: ");
string s2 = Console.ReadLine();

string s1prim = s1;
string s2prim = s2;

bool isAnagram = true;

s1prim = s1.ToLower();
s2prim = s2.ToLower();

s1prim = s1prim.Replace(" ", "");
s2prim = s2prim.Replace(" ", "");

char[] tabS1 = s1prim.ToCharArray();
char[] tabS2 = s2prim.ToCharArray();
Array.Sort(tabS1);
Array.Sort(tabS2);

if (tabS1.Length != tabS2.Length)
{
    isAnagram = false;
}
else
{
    for (int i = 0; i < tabS1.Length; i++)
    {
        if (tabS1[i] != tabS2[i])
        {
            isAnagram = false;
            break;
        }
    }
}


if (isAnagram)
{
    Console.WriteLine("Ciągi znaków '" + s1 + "' oraz '" + s2 + "' są anagramami" );
}
else
{
    Console.WriteLine("Ciągi znaków '" + s1 + "' oraz '" + s2 + "' nie są anagramami");
}