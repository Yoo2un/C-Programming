using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region collection(Queue)
            /*Queue queue = new Queue();*/ //참조형

            //Enqueue: 데이터를 저장하는 멤버 함수
            //Dequeue: 데이터를 빼내는 멤버 함수
            //queue.Enqueue(10);//[10],[Queue]
            //queue.Enqueue("Queue");

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            #endregion

            #region collection Generic(Queue)
            //Queue<int> genericQueue = new Queue<int>();
            //genericQueue.Enqueue(99);
            //genericQueue.Enqueue(100);
            //genericQueue.Enqueue(101);

            ////Peek(): 맨 앞에 있는 원소를 출력하는 함수
            //Console.WriteLine(genericQueue.Peek());

            //genericQueue.Clear();
            //genericQueue.Dequeue();
            #endregion

            #region collection Generic(Stack)
            //Stack<string> stack = new Stack<string>();
            //stack.Push("A");
            //stack.Push("B");
            //stack.Push("C");

            //// Contains(): 특정 값의 유무확인(true,false)
            //Console.WriteLine(stack.Contains("A"));

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            #endregion

            #region 일반화(List)
            List<float> list = new List<float>();
            
            //Add(): 데이터 추가
            list.Add(10.0f);
            list.Add(20.0f);
            list.Add(30.0f);
            list.Add(40.0f);

            for(int i = 0; i <list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //Remove() : 특정한 원소 또는 값을 삭제하는 함수
            list.Remove(list[0]);
            Console.WriteLine(list[0]);

            //Insert(,) : 특정한 인덱스에 원하는 데이터를 추가하는 함수
            list.Insert(2, 82.1f);
            Console.WriteLine(list[2]);
            #endregion

        }
    }
}