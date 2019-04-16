namespace Tools
{
    public static class ElapsedTimeLoggerLevel
    {
        private static string level;
        private static object _lockObject = new object();
        public static string Level
        {
            get { return string.Format("{0}({1})", level, level.Length); }
        }
        public static void IncLevel()
        {
            lock (_lockObject)
            {
                level += "*";
            }
        }
        public static void ReduceLevel()
        {
            lock (_lockObject)
            {
                if (level.Length > 0)
                {
                    level = level.Substring(0, level.Length - 1);
                }
            }
        }
    }
}
