using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGsederhana
{
    public interface IKarakter
    {
        string Nama { get; set; }
        int HP { get; set; }
        int MP { get; set; }
        int Kekuatan { get; set; }

        void Serang(IKarakter target);
        void GunakanSkill(ISkill skill, IKarakter target);
        void CetakInformasi();
    }
}
