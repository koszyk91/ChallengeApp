// zadanie dzień 4
string name;
char sex;
byte age;

name = "Ewa";
sex = 'F';
age = 33;

if (sex != 'F')
{
    if (age < 18)
        Console.WriteLine("Niepełnoletni Mężczyzna");
    else
    {
        Console.WriteLine("Mężczyzna powyżej 18 lat");
    }
}
else
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
        
    if (age >= 30)
        {
        if (name == "Ewa" && age == 33)
            Console.WriteLine("Ewa, lat 33");
        else Console.WriteLine("To już starsza Pani jest");
        }
}
