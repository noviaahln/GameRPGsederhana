using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGsederhana
{
    public interface ISkill
    {
        string Nama { get; }
        void Use(IKarakter karakter, IKarakter target);
    }
}
