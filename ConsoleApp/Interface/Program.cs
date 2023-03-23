namespace Interface
{
    interface IMouse
    {
       void Drag();
        //인터페이스는 함수외에는 선언X
        //int value;
    }
    interface IKeyBoard
    {
        void Typing();
    }
    class Computer : IMouse, IKeyBoard
    {
        //자동구현 프로퍼티
        public float Signal
        {
            get;//반환
            set;//저장
        } = 16.5f;
        //선택적 매개변수
        public void Power(string button, bool onoff = false )
        {
            Console.WriteLine("전원의 상태: " + onoff);
        }
        //명명된 매개변수
        public void Info(string name, int year)
        {
            Console.WriteLine("컴퓨터의 이름: " + name);
            Console.WriteLine("컴퓨터 제작년도: " + year);
        }
        public void Drag()
        {
            Console.WriteLine("Computer Mouse drag");
        }

        public void Typing()
        {
            Console.WriteLine("Computer Keyboard Type");
        }
    }
    class CellPhone : IMouse 
    {
        public void Drag()
        {
            Console.WriteLine("CellPhone Touch Drag");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region interface
            //Computer computer = new Computer();
            //CellPhone cellPhone = new CellPhone();
            //참조 변수로 사용하는건 가능
            //IMouse mouse = computer;

            //mouse.Drag();
            //mouse = cellPhone;
            //mouse.Drag();

            //computer.Drag();
            //computer.Typing();

            //cellPhone.Drag();
            #endregion
            Computer computer = new Computer();
            //computer.Power("Force Quit Button");
            //computer.Power("Force Quit Button",true);

            computer.Info("LG PC", 2023);
            computer.Info(year: 1999, name: "Samsung PC");
            computer.Signal = 100;

            Console.WriteLine("Signal: " + computer.Signal);
        }
    }
}
