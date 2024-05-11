using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public class Helper
    {
        public static void PrikaziListuUListboxu<NekiTip>(List<NekiTip> lista, ListBox listbox)
        {
            listbox.Items.Clear();
            lista.Sort();
            foreach (NekiTip element in lista)
            {
                listbox.Items.Add(element);
            }
        }
    }
}
