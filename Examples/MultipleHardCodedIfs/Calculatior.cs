using System;
using System.Collections.Generic;
using System.Linq;

namespace IfPreventingAbstraction
{
    public class Calculatior
    {
        private List<Robot> Robots = new List<Robot>();

        public int CalculatePointsFromRobots_Ifs() {

            int pointsForRobotDamage = 0;

            foreach (Robot bot in Robots) {

                switch (bot.ShieldType) {
                    case Shield.Plasma:
                        pointsForRobotDamage += 2;
                        break;
                    case Shield.ElectroMagnetic:
                        pointsForRobotDamage += 3;
                        break;
                    case Shield.None: pointsForRobotDamage += 10;
                        break;
                }
            }

            return pointsForRobotDamage;
        }

        public int CalculatePointsFromRobots_Filters() {

            int pointsForRobotDamage =
                Robots.Where(bot => bot.ShieldType == Shield.Plasma).Count() * 2 +
                Robots.Where(bot => bot.ShieldType == Shield.ElectroMagnetic).Count() * 3 +
                Robots.Where(bot => bot.ShieldType == Shield.None).Count() * 10;

            return pointsForRobotDamage;
        }

        public int CalculatePointsFromRobots_Dictionary() {

            Dictionary<Shield, int> pointsPerSheild = new Dictionary<Shield, int> {
                {Shield.Plasma, 2 },
                {Shield.ElectroMagnetic, 3 },
                {Shield.None, 10 } };

            int pointsForRobotDamage = Robots.Sum(bot => pointsPerSheild[bot.ShieldType]);

            return pointsForRobotDamage;
        }
    }
}
