namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class OperatingSystem // Singleton
    {
        private static OperatingSystem _instance;

        public string OperatingSystemName { get; private set; }


        private OperatingSystem(string operationSystemName)
        {
            OperatingSystemName = operationSystemName;
        }


        public static OperatingSystem GetInstance(string operationSystemName)
        {
            return _instance ?? (_instance = new OperatingSystem(operationSystemName));
        }
    }
}