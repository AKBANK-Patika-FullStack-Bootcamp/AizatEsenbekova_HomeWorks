using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class StudentContext:DbContext
   {   public DbSet <Student> _student{ get;set;}
    
    }
}
