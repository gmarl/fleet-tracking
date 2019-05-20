using System;
using System.Windows.Forms;

namespace FM
{

    public static class GlobalVar
    {
        /// <summary>
        /// Global variable that is constant.
        /// </summary>
        //public const string conString = "Data Source=GHB-RNET-01\\FLEETMGMNT;Initial Catalog=GHBWFM;Integrated Security=True";

        public const string conString = "Data Source=GREG-HP\\SQLEXPRESS;Initial Catalog=GHBWFM;Integrated Security=True";
        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int _userid;
        public static DateTime _date;

        public static int _security;

        public static int _whse;
        public static DateTime __date = DateTime.Now; // used for edit records section
          }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
