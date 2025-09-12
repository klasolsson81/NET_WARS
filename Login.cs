namespace NET_WARS
{
    //Skapar en sista klass med Inkapsling som heter Login
    public class Login
    {
        //Lägger till privata egenskaper för användarnamn och lösenord
        private string username;
        private string password;

        //Lägger till publika metoder för att ställa in och hämta användarnamn och lösenord
        public void SetCredentials(string user, string pass)
        {
            username = user;
            password = pass;
        }
        //Lägger till en metod för att hämta användarnamn
        public string GetUsername()
        {
            return username;
        }
    }
}
