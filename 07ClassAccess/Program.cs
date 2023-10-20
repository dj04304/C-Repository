using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 객체지향의 캡슐화 은닉화를 대표하는 문법 -> 접근제한 지정자입니다.

    public int Att;
    protected int Hp;
    private int Def;

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }

}

namespace _07ClassAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // 생성자의 변수에 .을찍어 사용할 수 있는데 현재는 사용할 수 없는 상태이다.
            // 사용하기 위해서는 void Fight() 에서 public을 붙여준다면 공공에서 사용 가능하다.

            NewPlayer.Fight();
        }
    }
}
