using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGsederhana
{
    public class HealSkill : ISkill
    {
        public string Nama { get; } = "Heal";
        public void Use(IKarakter karakter, IKarakter target)
        {
            target.HP += 20;
            Console.WriteLine($"{karakter.Nama} memakai skill {Nama} pada {target.Nama} sehingga menambah 20 HP.");
        }

    }
    public class FireballSkill : ISkill
    {
        public string Nama { get; } = "Fireball";
        public void Use(IKarakter karakter, IKarakter target)
        {
            target.HP -= 10;
            Console.WriteLine($"{karakter.Nama} menggunakan skill {Nama} pada {target.Nama}, sehingga menurunkan 10 HP.");
        }
    }
    public class IceBlastSkill : ISkill
    {
        public string Nama { get; } = "IceBlast";
        public void Use(IKarakter karakter, IKarakter target)
        {
            target.HP -= 15;
            Console.WriteLine($"{karakter.Nama} memakai skill {Nama} pada {target.Nama}, menurunkan 15 HP dan kekuatan menjadi {target.Kekuatan}.");
        }
    }
}
