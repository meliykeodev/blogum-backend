using System;

using Mapster;

namespace blogum_core.Helpers
{
    public class AppMapper
    {
        public static T Map<T>(object source)
        {
            return source.Adapt<T>();
        }

    }
}
