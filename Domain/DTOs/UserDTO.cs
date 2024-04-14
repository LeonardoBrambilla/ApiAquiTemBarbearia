namespace ApiAquiTemBarbearia.Domain.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Telephone { get; set; }
        public required string Password { get; set; }
        public required string Photo { get; set; }
    }
}
