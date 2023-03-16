using System.Runtime.InteropServices;

namespace Class
{
    #region get/set class
    //class Dog//12byte
    //{
    //    private int age;

    //    public int Age
    //    {
    //        get 
    //        {
    //            return age;
    //        }
    //        set 
    //        {
    //            if(value >= 18)
    //            {
    //                value = 18;
    //            }
    //            age = value; 
    //        }
    //    }
    //    protected char grade; 
    //    private float health;

    //    //기본 접근지정자: private

    //}
    //class Shiba : Dog //상속 받아서 12byte
    //{
    //    public void Info()
    //    {
    //        grade = 'A';
    //        Console.WriteLine("grade: " + grade);
    //    }
    //}
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 클래스
            //Dog dog = new Dog(); //힙에 할당
            //dog.Age = 20;
            //Console.WriteLine("강아지 나이: " + dog.Age);
            //Shiba shiba = new Shiba();
            //shiba.Info();
            #endregion
            #region 백준 - 단어길이 재기
            string result = Console.ReadLine();
            Console.WriteLine(result.Length);
            #endregion
        }
    }
}