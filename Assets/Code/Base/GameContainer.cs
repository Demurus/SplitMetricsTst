/*using System.Collections.Generic;

namespace Code.Base
{
    public class GameContainer
    {
        private static Dictionary<string, object> _instances = new Dictionary<string, object>();
        
        public static void Set<T>(T instance) where T : class
        {
            string key = typeof(T).ToString();
            _instances[key] = instance;
        }
        
        public static T Get<T>() where T : class
        {
            string key = typeof(T).ToString();
            if (_instances.ContainsKey(key))
                return _instances[key] as T;

            return null;
        }
    }
}*/