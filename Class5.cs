using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGsederhana
{
    public class Pemain : Karakter
    {
        public Pemain(string nama) : base(nama, 100, 50, 20)
        {

        }
    }
    public class Musuh : Karakter
    {
        public Musuh(string nama) : base(nama, 50, 0, 15)
        { 

        }
    }
}
