namespace SameIfRepeated {
    interface IStrategy {
        void TakeHit(Robot attacker, Robot_WithStrategy me);

        void SeeEnemy(Robot enemy, Robot_WithStrategy me);
    }
}
