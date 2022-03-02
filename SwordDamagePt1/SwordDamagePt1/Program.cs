using System;

namespace SwordDamagePt1
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamange swordDamage = new SwordDamange();
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                   "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;

                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                int roll = 0;
                for(var i = 1; i < 4; i++)
                {
                    roll += random.Next(1, 7);
                }

                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');

                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP\n");

            }

        }
    }
}
