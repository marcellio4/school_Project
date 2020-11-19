using System.Collections;
using System.Collections.Generic;

namespace Flyweight
{
    public static class PlatformFactory
    {

        private static Hashtable _flyweights = new Hashtable();
        public static IPlatform PlatformInstance(string name)
        {
            if (_flyweights.ContainsKey(name))
            {
                return ((IPlatform)_flyweights[name]);
            }
            _flyweights.Add(name, new ScalaPlatform());
            return ((IPlatform)_flyweights[name]);
        }
    }
}