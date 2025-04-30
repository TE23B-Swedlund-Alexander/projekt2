Random rnd = new Random();
int guy1Dmg = 1;
int guy2Dmg = 1;
int guy1Hp = 100;
int guy2Hp = 100;
int roundOutcome = 0;//outcome adds a rock paper scissors element
Console.WriteLine("what is your name");
string nameGuy1 = Console.ReadLine();

//picks what parts are part of the name
int nP1 = rnd.Next(0, 5); //first half of first name //stands for namePart1
int nP2 = rnd.Next(0, 5); // second half first name //namePart2
int lNP1 = rnd.Next(0, 5);// first half last name //lastNamePart1
int lNP2 = rnd.Next(0, 5);// second half last name //lastNamePart2

List<string> namePart1 = ["Dec", "Jo", "Al", "Lu", "Juli"]; //first half of first name
List<string> namePart2 = ["lan", "el", "ec", "ca", "anne"]; // second half first name
List<string> lastNamePart1 = ["Yod", "Single", "Farr", "Sto", "Pe"]; // first half last name
List<string> lastNamePart2 = ["er", "ton", "ell", "kes", "rry"]; // second half last name


string nameGuy2 = namePart1[nP1] + namePart2[nP2] + " " + lastNamePart1[lNP1] + lastNamePart2[lNP2];




static int BaseDmgCalculation()
{
    Random rnd = new Random();

    int dmg = 7;
    int dmgbonus = rnd.Next(1, 6); //makes the damage vary from hit to hit
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

    return dmg;
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
static int AttackOutcome(string name)
{
    Random rnd = new Random();
    int attackPlayer = 0;
    int attackEnemy = rnd.Next(1, 3);
    string attackEnemyString = "aaa";
    int attackOutcome = 1;
    bool attackChosen = false;
    if (attackEnemy == 1) attackEnemyString = "punches";
    if (attackEnemy == 2) attackEnemyString = "kicks";
    if (attackEnemy == 3) attackEnemyString = "faints";
    while (attackChosen == false)
    {
        Console.WriteLine("what attack do you want to use");
        Console.WriteLine("kick faint or punch");
        string playerChoice = Console.ReadLine();
        playerChoice = playerChoice.ToLower();
        if (playerChoice == "punch")
        {
            attackPlayer = 1;
        }
        else if (playerChoice == "kick")
        {
            attackPlayer = 2;
        }
        else if (playerChoice == "faint")
        {
            attackPlayer = 3;
        }
        else Console.WriteLine("choose one of the attacks");
    }


    if (attackPlayer == attackEnemy)
    {

        attackOutcome = 3;
    }


    if (attackPlayer == 1 && attackEnemy == 2 || attackPlayer == 2 && attackEnemy == 3 || attackPlayer == 3 && attackEnemy == 1)
    {

        attackOutcome = 2;
    }


    if (attackPlayer == 1 && attackEnemy == 3 || attackPlayer == 2 && attackEnemy == 1 || attackPlayer == 3 && attackEnemy == 2)
    {

        attackOutcome = 1;
    }
    Console.WriteLine($"you {attackPlayer} {name}, {name} {attackEnemyString} you");

    return attackOutcome;
}


while (guy1Hp > 0 && guy2Hp > 0) //runs fight
{
    roundOutcome = AttackOutcome(nameGuy2);

    guy1Dmg = BaseDmgCalculation();
    guy2Dmg = BaseDmgCalculation();

    if (roundOutcome == 1)
    {
        guy1Dmg *= 2;
        guy2Dmg = 0;
    }
    if (roundOutcome == 2)
    {
        guy1Dmg = 0;
        guy2Dmg *= 2;
    }
guy1Hp-=guy2Dmg;
guy2Hp-=guy2Dmg;

    Console.ReadLine();

    HpBar(guy1Hp, nameGuy1);
    HpBar(guy2Hp, nameGuy2);

    Console.ReadLine();
}
if (guy1Hp < guy2Hp) Console.WriteLine($"{nameGuy2} winns"); //someone winns
if (guy2Hp < guy1Hp) Console.WriteLine($"{nameGuy1} winns");
if (nameGuy1 == nameGuy2) Console.WriteLine("its a tie");
Console.ReadLine();