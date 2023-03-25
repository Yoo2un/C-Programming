namespace Abstract
{
    abstract class Item
    {
        protected int price = 1000;

        abstract public void Function();

        abstract public void WaitTime();
        public void Info()
        {
            Console.WriteLine("Item의 가격: " + price);
        }

    }
    class Posion : Item
    {
        const string type = "포션류";//초기화 꼭 해야함 절대 바뀌지 않을 타입만 const
        readonly int itemCode; //초기화 하지 않아도 됨 동적으로 바꿀 때는 readonly 단 속도가 느리다
        public Posion()
        {
            itemCode = 2189;
            Console.WriteLine("item Code : " + itemCode);
        }
        //메소드 숨기기 info를 덮어씌웠기 때문에 info()호출
        new public void Info()
        {
            //base -> 부모 함수 호출
            base.Info();
            Console.WriteLine("포션 가격: " + price);
        }
        //미리 봉인하는 것
        sealed public override void WaitTime()
        {
            Console.WriteLine("몇 초 대기");
        }
        public override void Function()
        {
            Console.WriteLine("체력 회복");
        }
    }
    class HealthPosion : Posion
    {
        public override void Function()
        {
            Console.WriteLine("능력치 증가");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Item item = new Item();
            #region 추상클래스
            //Item item = new Posion();
            //item.Function();
            //item.Info();
            #endregion
            #region base
            //Posion posion = new Posion();
            //posion.Info();
            #endregion
            #region 문자열 보간
            //문자열 보간
            int year = 2023;
            var date = DateTime.Now; //자동 자료형 맞춰줌
            Console.WriteLine("{0}년 {1:HH:mm:ss:ms}", year, date);
            //0에 year가 들어가고 1에 date가 들어가게된다
            #endregion
        }
    }

}