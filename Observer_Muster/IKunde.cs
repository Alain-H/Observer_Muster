using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Muster
{
    internal interface IKunde
    {

        string Name { get; set; }

        public void FormularAnKunde(Formular formular);

        public void NameEingeben();

        //Adresse,PLZ,.....
    }
}
