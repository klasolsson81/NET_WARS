
namespace NET_WARS
{
    //Skapar en ny klass som heter SmallBag som ärver från den abstrakta klassen Inventory
    public class SmallBag : Inventory
    {
        //Implementerar den abstrakta metoden DisplaySlots
        public override void DisplaySlots()
        {
            Console.WriteLine("SmallBag har 10 slots.");
        }
    }
}
