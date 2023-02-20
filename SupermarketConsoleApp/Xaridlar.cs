
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp
{
    public class Xaridlar
    {
        public int id { get; set; }

        public string vaqti { get; set; }

        public int usum { get; set; }

        public List<Mahsulotlar> XMahsulotlari { get; set; }

        public Xaridlar()
        {
            XMahsulotlari = new List<Mahsulotlar>();
        }
    }
}
