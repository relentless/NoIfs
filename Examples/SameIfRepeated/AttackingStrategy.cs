using System;

namespace SameIfRepeated {
    internal class AttackingStrategy : IStrategy {
        public void SeeEnemy(Robot enemy, Robot_WithStrategy me) {
            me.Attack(enemy);
        }

        public void TakeHit(Robot attacker, Robot_WithStrategy me) {
            me.RechargeWeapon();
            me.Attack(attacker);
        }
    }
}