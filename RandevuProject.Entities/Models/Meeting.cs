using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuProject.Entities.Models
{
    public class Meeting : BaseEntity
    {

        public DateTime MeetingDate { get; set; }

        public float Hour { get; set; }

        public string Description { get; set; } // randevu ile ilgili özel olarak tutulmak istenen bilgi

        public string Note { get; set; } // seansta kullanıcı ile ilgili bilmek istediğimiz önemli bilgiler için açıldı

        public int? AppUserID { get; set; }

        // Relational Properties

        public virtual AppUser AppUser { get; set; }


    }
}
