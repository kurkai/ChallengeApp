var name = "Agata";
var sex = 'F';
var age = 44;

if(sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30"); 
}
else if (sex != 'F' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Linijkę wyżej nie ma nic, bo to Agata co ma 44 lata!");
}
