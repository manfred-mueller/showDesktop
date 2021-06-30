using System;

namespace showDesktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Type typeShell = Type.GetTypeFromProgID("Shell.Application");
            var objShell = Activator.CreateInstance(typeShell);

            typeShell.InvokeMember("ToggleDesktop", System.Reflection.BindingFlags.InvokeMethod, null, objShell, null);
        }
    }
}