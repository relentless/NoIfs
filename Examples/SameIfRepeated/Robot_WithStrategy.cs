namespace SameIfRepeated
{
    public class Robot_WithStrategy {

        IStrategy strategy = new AttackingStrategy();

        private int health = 100;

        public int Health {
            get { return health; }
            set {
                health = value;
                strategy = health > 50 ? (IStrategy)new AttackingStrategy() : new DefendingStrategy();
            }
        }

        public void TakeHit(Robot attacker) {
            Health -= 10;
            strategy.TakeHit(attacker, this);
        }

        public void SeeEnemy(Robot enemy) {
            strategy.SeeEnemy(enemy, this);
        }

        public void RecoverHealth() { }

        public void RechargeWeapon() { }

        public void RunAwayFrom(Robot attacker) { }

        public void Attack(Robot attacker) { }
    }
}
