using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaracalSoft.Data;
using SehrimiTani.Entities;
namespace SehrimiTani.BusinessLayer
{
    public class Test
    {
        public Test()
        {
            //DataAccessLayer.DatabaseContext db = new DataAccessLayer.DatabaseContext();
            Data.DB = new DataAccessLayer.DatabaseContext();

            Repository<Universite>.ReadList();
        }
    }
}
