using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor1.BL;

namespace TextEditor1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm1 form = new MainForm1();
            MessageService service = new MessageService();
            FileManager1 manager = new FileManager1();
            MainPresenter presenter = new MainPresenter(form, manager, service);
            
            
            Application.Run(form);
        }
    }
}
