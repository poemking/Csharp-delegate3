using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinProj_delegate3
{
    public delegate int DelegateDefine(string MyPara);
    class ClassA
    {
        public DelegateDefine DelegateObj;
    }
}
