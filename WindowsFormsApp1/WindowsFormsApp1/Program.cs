using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static Form1 f1 = new Form1();
        public static ZD1 zd1 = new ZD1();
        public static ZD2 zd2 = new ZD2();
        public static ZD3 zd3 = new ZD3();
        public static ZD4 zd4 = new ZD4();
        public static ZD4_1 zd4_1 = new ZD4_1();
        public static ZD4_2 zd4_2 = new ZD4_2();
        public static ZD5 zd5 = new ZD5();
        public static ZD5_1 zd5_1 = new ZD5_1();
        public static ZD6 zd6 = new ZD6();
        public static ZD7 zd7 = new ZD7();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
