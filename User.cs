namespace LuvFinder_ViewModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsAdmin { get; set; }
        public string Token { get; set; }
         

    }
}
