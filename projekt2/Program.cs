Random rnd = new Random();


int guy1Hp = 100;
int guy2Hp = 100;
int guy1Dmg;
int guy2Dmg;

static int DmgCalculation(int hp)
{
    Random rnd = new Random();
    
    int dmg = 7;
    int dmgbonus = rnd.Next(1, 5); //funkar det så funkar det
    dmg = dmg + dmgbonus;
    int accurecy = rnd.Next(1, 5);
    if (accurecy == 1)
    {
        dmg = 0;
        Console.WriteLine("miss");
    }
    if (accurecy == 5)
    {
        dmg *=2 ;
Console.WriteLine("critical hit");
    }
    
    return dmg;
}
static int HpBar(int hp)
{
   
Console.Write("hp: [");
for(int i=hp; i>0; i--){
Console.Write("|");

   }
   for(int i=100-hp; i>0; i--){
Console.Write(" ");

   }

Console.WriteLine($"]{hp}/100");

   return hp;
}
HpBar(guy1Hp);



Console.ReadLine();