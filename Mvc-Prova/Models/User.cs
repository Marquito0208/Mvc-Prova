using System.ComponentModel.DataAnnotations;

namespace Mvc_Prova.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;

    }
}
