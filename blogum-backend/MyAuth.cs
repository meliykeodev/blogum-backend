using System;
using blogum_core.enums;

namespace blogum_backend
{
    public class MyAuth: Attribute
    {
        public MyAuth(
            Ranks rank
            )
        {

        }
    }
}
