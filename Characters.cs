namespace NET_WARS
{
    public class Characters
    {
        //Här skapar jag en klass som heter Characters
        //Klasser innehåller egenskaper och metoder

        //Egenskaper
        public string Name;
        public int Health;
        public int AttackPower;

        //Metoder
        public void Damage(int damage)
        {
            Health = Health - damage;
            Console.WriteLine($"{Name} har tagit {damage} skada och har nu {Health} HP kvar.");
        }

    }
}
