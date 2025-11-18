using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion; // 👈 ESTA LÍNEA AGREGA EL NAMESPACE DONDE ESTÁ Form1

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ✅ Ya reconoce Form1
        }
    }
}