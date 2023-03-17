namespace Constructor
{
    //class Monster
    //{
    //    private int health;
    //    private float attack;

    //    public Monster(int health, float attack)
    //    {
    //        this.health = health;
    //        this.attack = attack;
    //    }

    //    //깊은 복사
    //    public Monster Clone()
    //    {
    //        Monster temp = new Monster(health, attack);

    //        return temp;
    //    }
    //    public void DataSetting(int x, int y)
    //    {
    //        health = x;
    //        attack = y;
    //    }

    //    public void Info(string name)
    //    {
    //        Console.WriteLine(name + " 체력: " + this.health);
    //        Console.WriteLine(name + " 공격력: " + this.attack);
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 얕은 복사
            //Monster monster1 = new Monster(100,10);

            //monster1.Info("monster1");

            //Monster monster2 = monster1.Clone();

            //monster2.DataSetting(400, 45);
            //monster1.Info("monster1");
            //monster2.Info("monster2");
            #endregion

            #region 백준 문자열
            int T = int.Parse(Console.ReadLine());
            string S;

            for(int i = 0; i < T; i++) 
            {
                S = Console.ReadLine();
                Console.Write(S[0]);
                Console.WriteLine(S[S.Length-1]);
            }
            #endregion
        }
    }
}