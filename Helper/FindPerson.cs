using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1.Helper
{
    internal class FindPerson
    {
  
            private int id;

            public FindPerson(int id)
            {
                this.id = id;
            }

            public bool PersonPredicate(Person person)
            {
                return person.Id == id;
            }
        }
    }


