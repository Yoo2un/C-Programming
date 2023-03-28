using System.Linq.Expressions;

namespace Anonymous
{
    class Vector<T>
    {
        private T[] element = new T[10];
        public Vector()
        {
            for(int i = 0; i < element.Length; i++)
            {
                Console.WriteLine(element.Length);
            }
        }
        public T Index(int index)
        {
            return element[index];
        }

    }
    internal class Program
    {
        delegate int Calculator(int x, int y);
        
        //<T> 형식 매개변수
        // 호출할 때 <>사이에 T 대신 형식의 이름을 넣으면
        // 컴파일러는 메서드의 나머지 부분에 대해서 매개변수 값으로 치환
        static void Resolution<T>(T x,T y)
        {
            Console.WriteLine("X 해상도: " + x + " " + "Y 해상도: " + y);
        }
        static void Main(string[] args)

        {
            #region 무명형식
            //무명형식
            //이름이 없는 형식
            //선언과 동시에 인스턴스 할당
            //var instance = new { name = "James", age = 19 };
            ////무명 형식은 값을 참조해서 수정할 수 없다
            ////instance.name - "jone";
            //Console.WriteLine(instance.name);
            //Console.WriteLine(instance.age);
            #endregion
            #region 무명 메소드
            //Calculator calculator;
            ////무명 메소드도 delegate 타입과 일치해야함
            //calculator = delegate (int x, int y)
            //{
            //    return x + y;
            //};
            //Console.WriteLine(calculator(10, 20));

            ////람다식
            //calculator = (x, y) => x + y;

            //Console.WriteLine(calculator(5, 5));
            #endregion
            //일반화 프로그래밍
            //데이터 형식을 정해놓고 사용하는게 아니라
            //특수한 형식을 사용하는 코드의 데이터 형식을 일반화하여
            //오버로딩하지 않고, 모든 형식을 지원할 수 있는 프로그래밍 방법
            Resolution<int>(10, 20);
            Resolution<float>(1925.5f, 1300.5f);
        
            Vector<int> vector = new Vector<int>();
            
        }
    }
}