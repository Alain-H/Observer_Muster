using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Muster
{
    internal class Auto_Versicherung : Versicherung
    {
        public Formular gueltigesFormular;

        public void setFormular(Formular formular)
        {
            gueltigesFormular = formular;
            KundenBenachrichtigen(formular);
        }
        public Formular getFormular()
        {
            return gueltigesFormular;
        }

    }
}
