Random rnd = new Random();

int guy1Hp = 100;
int guy2Hp = 100;


//picks what parts are part of the name
int nP1 = rnd.Next(0, 5); //first half of first name //stands for namePart1
int nP2 = rnd.Next(0, 5); // second half first name //namePart2
int lNP1 = rnd.Next(0, 5);// first half last name //lastNamePart1
int lNP2 = rnd.Next(0, 5);// second half last name //lastNamePart2

List<string> namePart1 = ["Dec", "Jo", "Al", "Lu", "Juli"]; //first half of first name
List<string> namePart2 = ["lan", "el", "ec", "ca", "anne"]; // second half first name
List<string> lastNamePart1 = ["Yod", "Single", "Farr", "Sto", "Pe"]; // first half last name
List<string> lastNamePart2 = ["er", "ton", "ell", "kes", "rry"]; // second half last name

string nameGuy1 = namePart1[nP1] + namePart2[nP2] + " " + lastNamePart1[lNP1] + lastNamePart2[lNP2];


 //picks what parts are part of the other name
nP1 = rnd.Next(0, 5); //first half of first name
nP2 = rnd.Next(0, 5); // second half first name
lNP1 = rnd.Next(0, 5);// first half last name
lNP2 = rnd.Next(0, 5);// second half last name

string nameGuy2 = namePart1[nP1] + namePart2[nP2] + " " + lastNamePart1[lNP1] + lastNamePart2[lNP2];




static int DmgCalculation(int hp)
{
    Random rnd = new Random();

    int dmg = 7;
    int dmgbonus = rnd.Next(1, 6); //makes the damage varry from hit to hit
    dmg = dmg + dmgbonus;
    int accurecy = rnd.Next(1, 21); //crit, miss or hit

    if (accurecy > 0 && accurecy < 4) //miss
    {
        dmg = 0;
        Console.WriteLine("miss");
    }

    if (accurecy == 20 || accurecy == 19)//crit
    {
        dmg *= 2;
        Console.WriteLine("critical hit");
    }
    Console.WriteLine($"{dmg} damage"); //makes damage happen
    hp -= dmg;
    return hp;
}
static void HpBar(int hp, string name) // makes a hp bar
{

    Console.Write($"{name} hp: ["); //first bit

    for (int i = hp; i > 0; i--) //amount of hp remaining
    {
        Console.Write("|");

    }
    for (int i = 100 - hp; i > 0; i--) //amount of hp lost
    {
        Console.Write(" ");

    }

    Console.WriteLine($"]{hp}/100"); //in numbers to make it easier to see exact amount

    
}


while (guy1Hp > 0 && guy2Hp > 0) //runs fight
{

    Console.WriteLine($"{nameGuy1} attacks {nameGuy2}"); //1 attacks 2
    guy2Hp = DmgCalculation(guy2Hp);
    HpBar(guy2Hp, nameGuy2);

    Console.ReadLine();

    Console.WriteLine($"{nameGuy2} attacks {nameGuy1}"); //2 attacks 1
    guy1Hp = DmgCalculation(guy1Hp);
    HpBar(guy1Hp, nameGuy1);

    Console.ReadLine();
}
if (guy1Hp < guy2Hp) Console.WriteLine($"{nameGuy2} winns"); //someone winns
if (guy2Hp < guy1Hp) Console.WriteLine($"{nameGuy1} winns");
if (nameGuy1 == nameGuy2) Console.WriteLine("its a tie");
Console.ReadLine();