using System;
using System.Collections.Generic;
using System.Linq;

namespace IfPreventingAbstraction
{
    public class Calculatior
    {
        private List<Robot> Robots = new List<Robot>();

        public int CalculatePointsFromShieldedRobots_Duplicated(Weapon blast) {

            int initialPoints = blast.BaseAttackPoints;

            int onePointPerRobotHit = Robots.Count();

            int pointsForRobotDamage = 0;

            foreach (Robot bot in Robots) {
                if (bot.ShieldType == Shield.Plasma || bot.ShieldType == Shield.ElectroMagnetic) {
                    pointsForRobotDamage += 5;
                }
            }

            return initialPoints + onePointPerRobotHit + pointsForRobotDamage;
        }

        public int CalculatePointsFromUnshieldedRobots_Duplicated(Weapon blast) {

            int initialPoints = blast.BaseAttackPoints;

            int onePointPerRobotHit = Robots.Count();

            int pointsForRobotDamage = 0;

            foreach (Robot bot in Robots) {
                if (bot.ShieldType == Shield.None) {
                    pointsForRobotDamage += 5;
                }
            }

            return initialPoints + onePointPerRobotHit + pointsForRobotDamage;
        }

        public int CalculatePointsFromShieldedRobots_Abstracted(Weapon blast) {
            return CalculatePointsFromRobots(blast, (bot => 
                bot.ShieldType == Shield.Plasma || bot.ShieldType == Shield.ElectroMagnetic));
        }

        public int CalculatePointsFromUnshieldedRobots_Abstracted(Weapon blast) {
            return CalculatePointsFromRobots(blast, (bot => 
                bot.ShieldType == Shield.None));
        }

        public int CalculatePointsFromRobots(Weapon blast, Predicate<Robot> shieldsCheck) {

            int initialPoints = blast.BaseAttackPoints;

            int onePointPerRobotHit = Robots.Count();

            int pointsForRobotDamage = 0;

            foreach (Robot bot in Robots) {
                if (shieldsCheck(bot)) {
                    pointsForRobotDamage += 5;
                }
            }

            return initialPoints + onePointPerRobotHit + pointsForRobotDamage;
        }
    }
}
