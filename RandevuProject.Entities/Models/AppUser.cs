using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuProject.Entities.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public int? UserTypeID { get; set; }

        //Relational Properties

        public virtual AppUserProfile AppUserProfile { get; set; }

        public virtual List<Meeting> Meetings { get; set; }

        public virtual UserType UserType { get; set; }

    }
}
