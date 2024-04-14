using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAquiTemBarbearia.Domain.Model.UserAggregate
{
    [Table("user")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Telephone { get; set; }
        public required string Password { get; set; }
        public required string Photo { get; set; }

        public User() { }
        public User(string name, string email, string telephone, string password, string photo)
        {
            this.Name = name;
            this.Email = email;
            this.Telephone = telephone;
            this.Password = password;
            this.Photo = photo;
        }
    }
}
