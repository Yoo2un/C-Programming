namespace OverRide
{
    class Weapon
    {
        private string name;
        
        public enum itemType
        {
            Sword,
            Arrow,
            Spear
        }

        public void Select(itemType item)
        {
            switch (item)
            {
                case itemType.Sword:
                    Console.WriteLine("Sword");
                    break;
                case itemType.Arrow:
                    Console.WriteLine("Arrow");
                    break;
                case itemType.Spear:
                    Console.WriteLine("Spear");
                    break;
            }
        }

        public Weapon()
        {
            Console.WriteLine("매개변수가 없는 생성자 호출");
        }
        public Weapon(string name)
        {
            this.name = name;
            Console.WriteLine("매개변수가 있는 생성자 호출");
        }
        //함수의 오버로딩
        public void Attack(int damage)
        {
            Console.WriteLine("int damage: " + damage);
        }
        //함수의 오버로딩은 매개변수 타입과 갯수에 따라서
        //함수를 여러 개 만들 수 있음
        public void Attack(float damage)
        {
            Console.WriteLine("float damage: " + damage);
        }
    }

    class Monster
    {
        virtual public void Attack()
        {
            Console.WriteLine("Monster 공격");
        }
    }
    class Goblin: Monster
    {   
        override public void Attack()
        {
            Console.WriteLine("Goblin 공격");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 함수,생성자 오버로딩
            //Weapon weapon = new Weapon("Sword");
            ////Attack(int)
            //weapon.Attack(100);
            ////Attack(float)
            //weapon.Attack(45.5f);
            #endregion

            #region Enum
            //Weapon weapon = new Weapon();
            //weapon.Select(Weapon.itemType.Spear);
            //weapon.Select(Weapon.itemType.Arrow);
            //weapon.Select(Weapon.itemType.Sword);
            #endregion

            Monster monster = new Goblin(); //upcasting
            monster.Attack();
        }
    }
}