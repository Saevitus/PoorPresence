namespace PoorPresence
{
    public partial class Console : Form
    {
        public Console(MainForm Form)
        {
            InitializeComponent();
        }

        // print function that checks if it's being called from an outside thread,
        // if it is an invoke is required, and we use the MethodInvoker delegate
        // to call the MainConsole.AppendText function instead
        public void Print(string str)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (!MainConsole.InvokeRequired)
            {
                MainConsole.AppendText(str);
                return;
            }

            MainConsole.Invoke((MethodInvoker)delegate
            {
                MainConsole.AppendText(str);
            });
        }
    }
}
