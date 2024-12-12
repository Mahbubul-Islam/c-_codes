//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace code_writing
//{
//    public class Game_Character
//    {
//        protected int Attackpoint;
//        protected int Defencepoint;
//        public Game_Character()
//        {
//            this.Attackpoint = 0;
//            this.Defencepoint = 0;
//        }
//        public Game_Character(int attackpoint, int defencepoint)
//        {
//            this.Attackpoint = attackpoint;
//            this.Defencepoint = defencepoint;
//        }
//        public double Hitpoint()
//        {
//            double damage = (Attackpoint * 2) - (Defencepoint * (0.5));
//            return damage;
//        }
//        public virtual void Display()
//        {

//        }
//    }
//    public class Ally : Game_Character
//    {
//        public Ally() { Console.WriteLine("I am Ally"); }
//        public Ally(int attackpoint, int defencepoint):base(defencepoint, attackpoint) 
//        { 

//        }
//        public override void Display() 
//        {
//            Console.WriteLine($"Given damage is: {Hitpoint()}");
//        }
//    }
//    public class Enemy : Game_Character
//    {
//        protected string Enemytype;
//        public Enemy() { Console.WriteLine("I am Enemy."); }
//        public Enemy(string enemy_type, int attackpoint, int defencepoint) : base(defencepoint, attackpoint)
//        { 
//            this.Attackpoint= attackpoint;
//            this.Defencepoint= defencepoint;
//            this.Enemytype = enemy_type;
//        }
//        public override void Display()
//        {
//            Console.WriteLine($"Enemy type is: {Enemytype}");
//            Console.WriteLine($"Given damage is: {Hitpoint()}");
//        }

//    }
//    public class Boss_enemy:Enemy
//    {
//        public Boss_enemy() { Console.WriteLine("I am boss enemy"); }
//        public Boss_enemy(int attackpoint, int defencepoint, string enemytype) : base(enemytype, attackpoint, defencepoint)
//        { 
//            this.Attackpoint = attackpoint;
//            this.Defencepoint = defencepoint;
//            this.Enemytype=enemytype;
//        }
//        public override void Display()
//        {
//            Console.WriteLine($"Enemy type is: {Enemytype}");
//            Console.WriteLine($"Given damage is: {Hitpoint()}");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Game_Character c1 = new Ally();
//            Game_Character c2 = new Ally(100,50);
//            c2.Display();
//            Game_Character e1 = new Enemy();
//            Game_Character e2 = new Enemy("Level enemy",120,50);
//            e1.Display();
//        }
//    }
//}

using System;

namespace CodeWriting
{
    public class Game_Character
    {
        protected int Attackpoint;
        protected int Defencepoint;

        public Game_Character()
        {
            this.Attackpoint = 0;
            this.Defencepoint = 0;
        }

        public Game_Character(int attackpoint, int defencepoint)
        {
            this.Attackpoint = attackpoint;
            this.Defencepoint = defencepoint;
        }

        public double Hitpoint()
        {
            double damage = (Attackpoint * 2) - (Defencepoint * 0.5);
            return damage;
        }

        public virtual void Display()
        {
            //Console.WriteLine("Game Character Information:");
            Console.WriteLine($"Attack Point: {Attackpoint}, Defense Point: {Defencepoint}");
            Console.WriteLine($"Damage: {Hitpoint()}");
        }
    }

    public class Ally : Game_Character
    {
        public Ally()
        {
            Console.WriteLine("I am Ally");
        }

        public Ally(int attackpoint, int defencepoint) : base(defencepoint,attackpoint)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Ally Information:");
            base.Display();
        }
    }

    public class Enemy : Game_Character
    {
        protected string Enemytype;

        public Enemy()
        {
            Console.WriteLine("I am Enemy");
            Enemytype = "Default Enemy";
        }

        public Enemy(string enemytype, int attackpoint, int defencepoint) : base(attackpoint, defencepoint)
        {
            this.Enemytype = enemytype;
        }

        public override void Display()
        {
            Console.WriteLine("Enemy Information:");
            Console.WriteLine($"Enemy Type: {Enemytype}");
            base.Display();
        }
    }

    public class Boss_Enemy : Enemy
    {
        public Boss_Enemy()
        {
            Console.WriteLine("I am boss enemy");
        }

        public Boss_Enemy(int attackpoint, int defencepoint, string enemytype) : base(enemytype, attackpoint, defencepoint)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Boss Enemy Information:");
            base.Display();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create one instance per class and display their information
            Ally ally = new Ally(100, 50);
            ally.Display();
            Console.WriteLine();

            Enemy enemy = new Enemy("Level Enemy", 120, 50);
            enemy.Display();
            Console.WriteLine();

            Boss_Enemy bossEnemy = new Boss_Enemy(200, 100, "Final Boss");
            bossEnemy.Display();
        }
    }
}
