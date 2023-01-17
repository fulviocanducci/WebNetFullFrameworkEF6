using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMySQLEF.Models
{
   [Table("clients")]
   public class Client
   {
      [Key()]
      [Column("id")]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }

      [MaxLength(100)]
      [Required(ErrorMessage = "Digite o nome")]
      [Column("name")]
      public string Name { get; set; }
   }
}