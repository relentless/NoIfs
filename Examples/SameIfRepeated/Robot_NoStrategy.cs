namespace SameIfRepeated
{
    public class Robot_NoStrategy
    {
        int health = 100;

        public bool AttackMode {
            get { return health > 50; }
        }

        public void TakeHit(Robot attacker) {

            health -= 10;

            if (AttackMode) {
                Attack(attacker);
            }
            else {
                RunAwayFrom(attacker);
            }
        }

        public void SeeEnemy(Robot enemy) {

            if (AttackMode) {
                RechargeWeapon();
                Attack(enemy);
            }
            else {
                RecoverHealth();
            }
        }

        private void RecoverHealth() {}

        private void RechargeWeapon() {}

        private void RunAwayFrom(Robot attacker) {}

        private void Attack(Robot attacker) {}
    }
}
