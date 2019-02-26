using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankLib
{
    public class Tank
    {
        public Tank(string tankName)
        {
            this.tankName = tankName;
            levelOfAmmunition = rnd.Next(0, 100);
            levelOfArmor = rnd.Next(0, 100);
            levelOfManeuverability = rnd.Next(0, 100);
        }
        Random rnd = new Random();

        public string tankName { get; set; }
        public int levelOfAmmunition { get; set; }
        public int levelOfArmor { get; set; }
        public int levelOfManeuverability { get; set; }

        public static Tank operator *(Tank t1, Tank t2)
        {
            if (t1.levelOfAmmunition < t2.levelOfAmmunition &&
            t1.levelOfArmor < t2.levelOfArmor &&
            t1.levelOfManeuverability < t2.levelOfManeuverability ||
            t1.levelOfAmmunition > t2.levelOfAmmunition &&
            t1.levelOfArmor < t2.levelOfArmor &&
            t1.levelOfManeuverability < t2.levelOfManeuverability ||
            t1.levelOfAmmunition < t2.levelOfAmmunition &&
            t1.levelOfArmor > t2.levelOfArmor &&
            t1.levelOfManeuverability < t2.levelOfManeuverability ||
            t1.levelOfAmmunition < t2.levelOfAmmunition &&
            t1.levelOfArmor < t2.levelOfArmor &&
            t1.levelOfManeuverability > t2.levelOfManeuverability)
            {
                return t2;
            }
            else
                return t1;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Уровень боекомплекта танка: ", levelOfAmmunition);
            Console.WriteLine("Уровень брони танка: ", levelOfArmor);
            Console.WriteLine("Уровень маневренности танка: ", levelOfManeuverability);
        }       
    }
}
