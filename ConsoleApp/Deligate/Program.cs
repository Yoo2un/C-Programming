using System.Security.Cryptography.X509Certificates;

namespace Delegate
{
    delegate void Delegate();
    class Player
    {
        public void Damage(Enemy enemy)
        {
            Delegate callback = State;
            enemy.Attack(callback);
        }
        public void State()
        {
            Console.WriteLine("공격당함");
        }
    }
    class Enemy
    {
        public void Attack(Delegate callback)
        {
            Console.WriteLine("attack");
            callback();
        }
    }
    //delegate - 대리자
    //메소드를 대신 호출해줌
    internal class Program
    {
        //델리게이트는 보관하기 위한 메소드와 반환형이 일치 해야함
        //보관하기 위한 메소드의 매개변수도 일치해야함
        delegate void Function(int x, int y);

        static void Plus(int x, int y)
        {
            Console.WriteLine("x+y = " + (x+y));
        }
        static void Minus(int x, int y)
        {
            Console.WriteLine("x-y = " + (x-y));
        }
        static void Main(string[] args)
        {
            #region delegate
            //Function function;
            //function = Plus;//함수 주소값을 delegate에 넣음
            //function(10, 20);

            //function = Minus;
            //function(10, 25);
            //Plus(10, 20);
            //Minus(10, 20);
            #endregion
            #region 델리게이트 체인
            //Function function;

            ////delegate 체인을 하려면 먼저 메소드를 등록시켜야함
            //function = Plus;
            //function += Minus;

            //function(10, 35);

            //function -= Minus;
            //function(10, 35);
            #endregion

            Player player = new Player();
            Enemy enemy = new Enemy();
            //enemy.Attack(player.Damage);
            player.Damage(enemy);
        }
    }
}
