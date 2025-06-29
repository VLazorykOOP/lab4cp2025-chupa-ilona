using System;
using System.Windows.Forms;

namespace LibraryManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string role = loginForm.UserRole; // отримуємо роль з LoginForm
                    Application.Run(new MainForm(role));
                }
            }
        }
    }
}

