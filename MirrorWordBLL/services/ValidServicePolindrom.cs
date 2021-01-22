using MirrorWordBLL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MirrorWordBLL.services
{
    public class ValidServicePolindrom : IValidServicePolindrom
    {
        public bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}


