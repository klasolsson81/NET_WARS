namespace NET_WARS
{
    //Denna klassen ska är ett ARV från Character
    public class Enemy : Characters
    {
        //Denna klassen kopierar allt från Character samt lägger till sina egna egenskaper och metoder
        //Nu lägger vi till en egenskap som heter EnemyType
        public string EnemyType;

        public override void Attack()
        {
            Console.WriteLine($"{Name} utför en kraftfull attack med {AttackPower} i styrka!");
        }
    }
}