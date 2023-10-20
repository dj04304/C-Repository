using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Hp;
    int Att;

    void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }

}
// 위는 설계의 과정이다.


namespace _06LocalVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 설계대로 플레이어를 만듦 그 이름을 NewPlayer라고 해라
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            // 클래스 안에 있다면 멤버변수라고 한다.

            //여기는 시작용 함수가 있는 곳이고, 이는 함수안에 있는 녀석이라고하는데 이를 지역변수라고한다.
            int a = 0;
        }
    }
}
