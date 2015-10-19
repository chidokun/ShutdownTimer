using System;
using System.Diagnostics;


namespace ShutdownTimer
{
   /// <summary>
   /// Contain methods to shutdown computer
   /// </summary>
    public class Shutdown
    {
        private string _parameter;

        public string Parameter
        {
            get { return _parameter; }
            set { _parameter = value; }
        }

        public Shutdown()
        {
            Parameter = "";
        }
        public Shutdown(string parameter)
        {
            Parameter = parameter;
        }

        /// <summary>
        /// Check if your computer support Hybrid boot mode
        /// </summary>
        /// <returns></returns>
        public static bool HybridAbility()
        {
            return Environment.OSVersion.Version.Build > 7601;
        }

        /// <summary>
        /// Execute tasks
        /// </summary>
        public void Execute()
        {
            ProcessStartInfo start = new ProcessStartInfo("shutdown", Parameter);
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.ErrorDialog = false;
            Process.Start(start);
        }
    }
}
