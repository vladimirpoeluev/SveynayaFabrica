using SveynayaFabrica.data.migrations;

namespace SveynayaFabrica.Model.Records
{
    public class User
    {
        public static User UserActual { get; set; }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public RoleUser Role { get; set; }

        public User(SveynayaFabrica.data.migrations.User user)
        {
            Id = user.Id;
            Login = user.Login;
            Password = user.Password;
            Role = (RoleUser)user.IdRole;
        }
    }
}
