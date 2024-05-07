namespace Singleton.Concept
{
    internal class ConfigManager
    {
        private Dictionary<string, object> Settings = new Dictionary<string, object>();
        private static ConfigManager Instance = new ConfigManager();
        private ConfigManager() 
        {
            
        }
        public void Set(string key, object value)
        {
            Settings.Add(key, value);
        }

        public object Get(string key)
        {
            if(Settings.ContainsKey(key)) 
                return Settings[key];
            else
                return null;
        }

        public static ConfigManager GetInstance()
        {
            return Instance;
        }
    }
}
