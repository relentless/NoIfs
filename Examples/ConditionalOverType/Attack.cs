namespace IfReplacementExamples {
    public class Attack
    {
        public void Attack_Conditional(Robot enemy) {
            if (enemy.GetType() == typeof(TankBot)) {
                enemy.Health -= 1;
            }
            else if (enemy.GetType() == typeof(GlassCannonBot)) {
                enemy.Health -= 10;
            }
        }

        public void Attack_Polymorphic(Robot enemy) {
            enemy.DecreaseHealth();
        }
    }
}
