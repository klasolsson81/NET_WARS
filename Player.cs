namespace NET_WARS
{
    //En klass som heter Player som handlar om polymorfism
    public class Player : Characters
    {
        //Jag skapar en metod som heter Attack som tar en parameter av typen Characters
        public override void Attack()
        {
            Console.WriteLine($"{Name} attackerar med en basattack som har {AttackPower} i attackstyrka!");
        } 

    }
}
