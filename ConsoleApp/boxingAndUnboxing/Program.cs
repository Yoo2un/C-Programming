using System.Collections;

namespace boxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region 박싱
                        //값 형식 -> 참조형식으로 변환해주는 과정
                        //암묵적 형변환이 발생
                        //참조에 할당하는 것보다 20배 시간 소요
                        int data = 100;
                        object obj = data;
                        //Console.WriteLine(obj);
            #endregion
            # region 언박싱
            //박싱되어 있는 참조형식 -> 값형식으로 변환
            //명시적 형변환이 발생
            //메모리 할당하는 것보다 4배 소요
            int value = (int)obj;
            //Console.WriteLine(value);
            #endregion
            #region ArrayList
            //<T>제네릭
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(100);
            //arrayList.Add(3.56);
            //arrayList.Add("pizza");
            //arrayList.Add(obj);

            //Console.WriteLine(arrayList.Capacity);


            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            #endregion
            #region string
            //string name = "kim";
            //Console.WriteLine(name);
            //name = "Umi";
            //Console.WriteLine(name);
            #endregion
            #region 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            int result = int.Parse(Console.ReadLine());
            Console.WriteLine(result);
            #endregion
        }
    }
}