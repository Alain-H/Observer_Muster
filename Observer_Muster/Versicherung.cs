using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Muster
{
    internal class Versicherung
    {
        private List<IKunde> K_Liste = new List<IKunde>();

       public virtual void KundeHinzufügen(IKunde kunde)
        {
            K_Liste.Add(kunde);
        }
        public virtual void KundeEntfernen(IKunde kunde)
        {
            try
            {
                for (int i = 0;K_Liste.Count <= i; i++)
                {
                    if (K_Liste[i].Name == kunde.Name)
                    {
                        K_Liste.RemoveAt(i);
                    }
                    if(i == K_Liste.Count-1)
                    {
                        Console.WriteLine("kunde ist nicht vorhanden!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        public virtual void KundenBenachrichtigen(Formular fromular)
        {
            foreach(IKunde kunde in K_Liste)
            {
                kunde.FormularAnKunde(fromular);
            }
        }
        public void getKunden()
        {
            int k = 1;

            Console.WriteLine("--------Unsere kunden--------");
            foreach (var Kunde in K_Liste)
            {
                Console.WriteLine($"{k++}ter: {Kunde.Name}");
            }
        }
    }
}
