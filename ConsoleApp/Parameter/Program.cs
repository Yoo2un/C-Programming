namespace Parameter
{
    internal class Program
    {
        //함수 -> 메소드(C#/Java)
        //ref: 참조형 매개변수
        //static void Calculator(ref int x) //정적함수로
        //{
        //    x -= 100;
        //}
        ////in: 참조형 매개변수이면서, 매개변수에 상수화가 이루어진 변수
        //static void Function(in int x)
        //{
        //    //값 변경X
        //    //x = 3000;
        //    Console.WriteLine("매개변수 값: " + x);
        //}
        ////out: 참조형 매개변수이면서,출력용 매개변수
        //static void RayCast(out int x)
        //{
        //    //out 매개변수는 외부에 있는 변수가 값을 초기화 안해도 가능
        //    x = 250;
        //}

        //static int RayCastHit(out int x, out int y)
        //{
        //    x = 300;
        //    y = 400;
        //    return 10;
        //}
        ////가변길이 매개변수
        //static void Info(params int[] list)
        //{
        //    int result = 0;

        //    foreach(int element in list)
        //    {
        //        result += element;
        //    }
        //    Console.WriteLine("result값: " + result);
        //}
        static void Main(string[] args)
        {

            #region 매개변수 한정
            #region 기타
            //Program program = new Program();
            //Program.Calculator();
            #endregion
            //ref 매개변수는 외부에서 초기화 해야함
            //int data = 1000;
            //int data2 = 2000;
            //int data3;

            //Calculator(ref data);
            //Console.WriteLine("data의 값: " + data);
            ////in
            //Function(data2);
            ////out
            //RayCast(out data3);

            //Console.WriteLine("data3값: " + data3);
            #endregion
            #region 백준-코딩은 체육과목입니다
            //int N = int.Parse(Console.ReadLine());
            //while(N >= 0)
            //{
            //    N -= 4;
            //    if(N < 0)
            //    {
            //        break;
            //    }    
            //    Console.Write("long ");

            //}
            //Console.Write("int");
            #endregion
            //가변길이 매개변수
            //Info(10, 20);
            //Info(10, 20, 35, 45);
        }
    }
}