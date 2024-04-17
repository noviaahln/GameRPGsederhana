using System;

namespace GameRPGsederhana
{
    class Program
    {
        static void Main(string[] args)
        {
            Pemain pemain = new Pemain("Player");
            Musuh musuh = new Musuh("Enemy");

            pemain.CetakInformasi();
            musuh.CetakInformasi();

            pemain.Serang(musuh);
            musuh.CetakInformasi();

            HealSkill healSkill = new HealSkill();
            pemain.GunakanSkill(healSkill, pemain);
            pemain.CetakInformasi();

            FireballSkill fireballSkill = new FireballSkill();
            pemain.GunakanSkill(fireballSkill, musuh);
            musuh.CetakInformasi();

            IceBlastSkill iceBlastSkill = new IceBlastSkill();
            pemain.GunakanSkill(iceBlastSkill, musuh);
            musuh.CetakInformasi();

            Console.ReadKey();
        }
    }
}