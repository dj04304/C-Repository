using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    NameSpace

    ex) 두 명의 프로그래머가 있다고 가정해보자

    A프로그래머가 마나 포션을 만들어야 하고 B프로그래머가 힐링 포션을 만들어야 하는 상황이다.

    그런데 둘 다 class이름을 potion 이라고 짓는 실수가 일어날 수 있다.

    이를 식별자 라고 한다. 
    
    식별자가 겹치게되면 포션을 사용하게 될 때, 마나포션인지 힐링포션인지 모르게되는 현상이 일어나게된다.

    이럴때 namespace를 이용해 누가 어떤것을 만들었는지를 알 수 있게 해주는 역할을 해준다.

    물론 class의 이름을 하나하나 신중히 지으면 되지만, 수만개의 class가 되어버린다면 namespace가 빛을 발휘하게 된다.

    심지어 이미 C# 내에 이미 정의되어있는 class와 겹치지 않을 수 있다.
 */

namespace APRO
{
    // (APRO의) potion 이라는 뜻으로 된다.
    class Potion 
    {

    }
}

namespace BPRO
{
    // (BPRO의) potion 이라는 뜻으로 된다.
    class Potion
    {

    }
}


