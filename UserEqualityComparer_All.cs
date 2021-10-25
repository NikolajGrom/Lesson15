using System;
using System.Collections.Generic;
using System.Linq;

class UserEqualityComparer_All : IEqualityComparer<User>
    {
        public bool Equals(User b1, User b2)
        {
            if(b1.Age != b2.Age)
                return false;
            if(b1.Name != b2.Name)
                return false;
            if(b1.SName != b2.SName)
                return false;
            
            return true;
        }

        public int GetHashCode(User bx)
        {
            int hCode = bx.Name.Length + bx.SName.Length;
            return hCode.GetHashCode();
        }
    }