using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 플레이어를 만들어주세요!
// 플레이어가 가질 수 있는 세부적인 내용들 => Gold, 경험치, 공격력, 방어력  (명사) 등등
// 세부속성이면서 명사이면서 값인것들로 표현되는 것들은 대부분 멤버 변수로 표현된다.

// 멤버면수의 선언은 int(자료형) 이름(식별자) 가 된다.
class Player
{
    bool IsFight;
    int Gold = 10;
    int Exp = 1000;
    int Att = 300;
    int Def = 100;
    int Hp = 400;
}
