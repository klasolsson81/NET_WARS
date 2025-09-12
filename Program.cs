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

            // Nu ska jag anropa min första klass som heter Characters
            Characters hero = new Characters();
            hero.Name = "The Beast";
            hero.Health = 100;
            hero.AttackPower = 20;
            hero.Damage(30);

            //Nästa klass är Enemy som ärver från Characters


        }
    }
}
