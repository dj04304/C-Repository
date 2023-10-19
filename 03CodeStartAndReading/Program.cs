using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CodeStartAndReading
{
    internal class Program
    {
        // 코드가 실행된다고 함은 어디서 부터 인가? -> 한줄 한줄씩 OS가 위에서부터 아래로 읽어준다.
        static void Main(string[] args)
        {
            // 아무튼 의미있는 코드
            // 위에서 부터 한 줄 씩 읽는 것은 쉽지가 않다.
            // 이를 ide가 도와준다. (디버깅 중 코드 한줄씩 실행 -> F10을 눌러보면 된다.)
            Console.WriteLine("안녕1");
            Console.WriteLine("안녕2");
            Console.WriteLine("안녕3");
            Console.WriteLine("안녕4");
            Console.WriteLine("안녕5");

        }
    }
}
