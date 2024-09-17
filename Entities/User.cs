using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotMemo.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
