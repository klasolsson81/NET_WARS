namespace NET_WARS
{
    //Skapar en abstrakt klass som heter Inventory
    public abstract class Inventory
    {
        //Skapar en egenskap för antal maxslots.
        public int MaxSlots;

        //Lägger till en abstrakt metod för att lägga till ett föremål i inventariet
        public abstract void AddItem(string item);

    }
}
