using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatOkulu.Models
{
    [Table("Eserler")]
   public class Eser
    {
        public int Id { get; set; }
        [Required, MaxLength]
        public string Ad { get; set; }

        public int? Yil { get; set; }
        [MaxLength(255)]
        public string Resim { get; set; }

        //Sanatci+ Id: Sanatci entity'sinin Id'sine referans veren bir FK
        public int SanatciId { get; set; }
        //Bu eserin 1 sanatçısı vardır(1-çok ilişki)
        public virtual Sanatci Sanatci { get; set; }


    }
}
