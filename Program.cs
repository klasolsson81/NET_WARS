namespace NET_WARS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här börjar programmet
            //Inlämningsuppgift: 
            //✅ Skapa en Console Application i C#
            //✅ I projektet ska du ha fyra olika klasser/ filer – en för varje OOP-princip:
            //* Arv
            //* Polymorfism
            //* Inkapsling
            //* Abstraktion

            //Jag skapar min första klass som heter Characters. Denna har ingen specifik OOP-princip.
            // Nu ska jag anropa min första klass som heter Characters
            Characters hero = new Characters();
            hero.Name = "The Beast";
            hero.Health = 100;
            hero.AttackPower = 20;
            hero.Damage(30);

            //Nästa klass är Enemy som ärver (ARV) från Characters
            //Nu lägger jag till en ny fiende
            Enemy heavySoldier = new Enemy();
            heavySoldier.Name = "Behemoth";
            heavySoldier.Health = 250;
            heavySoldier.AttackPower = 40;
            heavySoldier.EnemyType = "Juggernaut";

            //Nu ska jag meddela att en ny fiende har dykt upp från Enemy klassen (ARV)
            Console.WriteLine($"En ny fiende har dykt upp! Det är en {heavySoldier.EnemyType} vid namn {heavySoldier.Name} med {heavySoldier.Health} HP och {heavySoldier.AttackPower} i attackstyrka!");

            //Nu ska jag göra en tredje klass med polymorfism som heter Player
            //Skapa en ny spelare
            Player warrior = new Player();
            warrior.Name = "Aragorn";
            warrior.Health = 150;
            warrior.AttackPower = 30;
            
            //Anropa Attack-metoden för både fienden och spelaren för att visa polymorfism
            heavySoldier.Attack();
            warrior.Attack();

            //Nu ska jag skapa en fjärde klass med Abstraktion som heter Inventory
            

            //Skapar en sista klass med Inkapsling som heter Login

            //Lägger till användarnamn och lösenord
            Login userLogin = new Login();
            userLogin.SetCredentials("playerOne", "Hemligtpassword123");
            
            //Lägger till en metod för att hämta användarnamn
            Console.WriteLine($"Inloggad som: {userLogin.GetUsername()}");


        }
    }
}
