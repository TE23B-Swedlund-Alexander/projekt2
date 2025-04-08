Random rnd = new Random();


int guy1Hp = 100;
int guy2Hp = 100;

static int DmgCalculation()
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
static int HpBar(int dmg,int hp)
{
   
Console.Write("hp: [");
for(int i=100; i>0; i--){§

Console.WriteLine($"]{hp}/100");
   }


   return hp;
}