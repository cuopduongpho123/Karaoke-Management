using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laptrinhwin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//<<<<<<< HEAD
            Application.Run(new ThanhToan());
//=======
            
//>>>>>>> ab7850fe5df507b7a2a57d21598dc4b4f463cec3
        }
    }
}
