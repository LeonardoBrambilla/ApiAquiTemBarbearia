using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAquiTemBarbearia.Domain.Model.UserAggregate
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; private set; }
        public string name { get; private set; }
        public string password { get; private set; }

        public User() { }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
