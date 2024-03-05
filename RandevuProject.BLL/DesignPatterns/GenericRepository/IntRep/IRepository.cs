using RandevuProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuProject.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        // List Commands
        List<T> GetAll();

        List<T> GetActives();

        //...
    }
}
