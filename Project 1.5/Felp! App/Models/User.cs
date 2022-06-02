namespace Models
{
    public class User
    {
        Random random = new Random();

        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }

        public User() //default constructor to add default values to the properties
        {
            Fullname = "Jermaine Williams";
            Username = "PrimoVulcanZX";
            Email = "demo@demo.net";
            UserID = random.Next(1, 1000);
        }

        public override string ToString() //will print the list of users to the console
        {
            return $"Fullname: {Fullname}\nUsername: {Username}\nEmail: {Email}\nUserID: {UserID}";
        }
    }
}
