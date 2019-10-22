using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    class ContextInitializer:DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            Sex Male = new Sex { NameSex = "Male" };
            Sex Female = new Sex { NameSex = "Female"};

            db.Sexes.Add(Male);
            db.Sexes.Add(Female);
            db.SaveChanges();
        }
    }
}
