namespace Soldiers{
     using Weapon;
    public class Gunner : Soldier{
        public Gunner(string name) : base (name, 100, 12, new A_gun(),new Shields.Shield()){

        }

        public  override void Atack(Soldier enemy){
          //this.Weapon.Hit(this, enemy);
         // this.Weapon.Hit(this, enemy);
        }
        public  override void Defend(Soldier enemy){
           // this.SoldierShield?.Defend(this, enemy.Weapon.Damage);
        }
    }
}