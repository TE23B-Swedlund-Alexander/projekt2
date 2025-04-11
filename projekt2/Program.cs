Random rnd = new Random();


int guy1Hp = 100;
int guy2Hp = 100;
int guy1Dmg;
int guy2Dmg;
int nP1 = rnd.Next(0,5); //picks what parts are part of the name
int nP2 = rnd.Next(0,5);
int lNP1 = rnd.Next(0,5);
int lNP2 = rnd.Next(0,5);

List <string> namePart1 = ["Dec","Jo","Al","Lu","Juli"];
List <string> namePart2 = ["lan","el","ec","ca","anne"];
List <string> lastNamePart1 = ["Yod","Single","Farr","Sto","Pe"];
List <string> lastNamePart2 = ["er","ton","ell","kes","rry"];

string nameGuy1 = namePart1[nP1] + namePart2[nP2] + " " + lastNamePart1[lNP1] + lastNamePart2[lNP2];
Console.WriteLine(nameGuy1);

nP1 = rnd.Next(0,5); //picks what parts are part of the name
nP2 = rnd.Next(0,5);
lNP1 = rnd.Next(0,5);
lNP2 = rnd.Next(0,5);
string nameGuy2 = namePart1[nP1] + namePart2[nP2] + " " + lastNamePart1[lNP1] + lastNamePart2[lNP2];
Console.WriteLine(nameGuy2);



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




Console.ReadLine();