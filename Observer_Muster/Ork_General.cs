using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Muster
{
    internal class Ork_General : IKunde
    {
        public string Name { get; set; }

        public void FormularAnKunde(Formular formular)
        {
            Console.WriteLine($"\nSchicke Formular {formular.Name} an Org General mit dem Namen {Name} nach Zürich");
        }

        public void NameEingeben()
        {
            Console.Write("Geben sie einen Namen ein: ");
            Name = Console.ReadLine();
        }
    }
}
