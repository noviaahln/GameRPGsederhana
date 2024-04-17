using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGsederhana
{
    public abstract class Karakter : IKarakter
    {
        public string Nama { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Kekuatan { get; set; }

        public Karakter(string nama, int hp, int mp, int kekuatan)
        {
            Nama = nama;
            HP = hp;
            MP = mp;
            Kekuatan = kekuatan;
        }
        public virtual void Serang(IKarakter target)
        {
            target.HP -= Kekuatan;
            Console.WriteLine($"{Nama} menyerang {target.Nama} dengan kekuatan sebesar {Kekuatan}!");
        }
        public virtual void GunakanSkill(ISkill skill, IKarakter target)
        {
            skill.Use(this, target);
        }
        public virtual void CetakInformasi()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"MP: {MP}");
            Console.WriteLine($"Kekuatan: {Kekuatan}");
        }
    }
}