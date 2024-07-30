using System.ComponentModel.DataAnnotations;
namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            IsOnline = new Random().Next(0, 2) == 1;
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }

    }   
}
