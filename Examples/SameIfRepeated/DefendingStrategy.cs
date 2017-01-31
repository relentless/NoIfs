namespace SameIfRepeated {
    public class DefendingStrategy : IStrategy {
        public void SeeEnemy(Robot enemy, Robot_WithStrategy me) {
            me.RunAwayFrom(enemy);
        }

        public void TakeHit(Robot attacker, Robot_WithStrategy me) {
            me.RecoverHealth();
        }
    }
}
