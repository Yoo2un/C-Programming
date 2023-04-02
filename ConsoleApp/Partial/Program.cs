
using A;

public class Base
{
    int itemNumber;

    public void Construct()
    {
        Console.WriteLine("건물을 지었습니다");
    }
    public class Village
    {
        Base aclass = new Base();
        int bNumber;
        public void Info()
        {
            bNumber = aclass.itemNumber;
        }
    }
}

namespace A
{
    class Function
    {
        public Function()
        {
            Console.WriteLine("A namespace");
        }

    }
}
namespace B
{
    class Function
    {
        public Function()
        {
            Console.WriteLine("B namespace");
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial 클래스
            //Player player = new Player();
            //player.Talk();
            //player.Movement();
            //player.Attack();
            #endregion
            #region 중첩클래스
            //Base aclass = new Base();

            //Base.Village nestedClass = new Base.Village();
            //nestedClass.Info();
            #endregion
            //namespace 이름을 넣어서 구분
            B.Function B_function = new B.Function();
            A.Function A_function = new A.Function();
        }
    }