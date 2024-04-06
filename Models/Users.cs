namespace ApiAquiTemBarbearia.Models
{
    public class Users
    {
        public required int Id {get; set;}
        public required string Name {get; set;}
        public required string Cpf {get; set;}
        public required string Password {get; set;}
        public required string Email {get; set;}
    }
}