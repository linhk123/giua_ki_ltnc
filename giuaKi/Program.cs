using System;
using System.Threading;
using System.Windows.Forms;

namespace giuaKi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool createdNew;
            using var mutex = new Mutex(true, "giuaKi_single_instance_mutex", out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("The application is already running.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new WinForms());
            }
            catch (Exception ex)
            {
                // Show a friendly message and consider logging ex.ToString() to the output pane or a file.
                MessageBox.Show("Unhandled error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}