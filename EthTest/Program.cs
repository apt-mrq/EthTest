using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace EthTest
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int invoke_interval = 0;
            Console.WriteLine("Введи время в минутах: ");
            int interVal = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(interVal.ToString());
            invoke_interval = ((interVal*60)*1000);
            eth_off();
            System.Threading.Thread.Sleep(invoke_interval);
            eth_on();
        }

        public static void eth_off()
        {
            ProcessStartInfo off_eth_psi = new ProcessStartInfo();
            off_eth_psi.FileName = @"C:\Windows\System32\cmd.exe";
            off_eth_psi.WorkingDirectory = @"C:\Windows\System32";
            off_eth_psi.UseShellExecute = false;
            off_eth_psi.CreateNoWindow = true;
            off_eth_psi.RedirectStandardInput = true;
            off_eth_psi.Verb = "runas";
            Process off_eth_pr = new Process();
            off_eth_psi.Arguments = string.Format(@"/c netsh interface set interface ""Ethernet"" disable");
            off_eth_pr.StartInfo = off_eth_psi;
            off_eth_pr.Start();
            off_eth_pr.WaitForExit();
            off_eth_pr.Close();
        }
        public static void eth_on()
        {
            ProcessStartInfo off_eth_psi = new ProcessStartInfo();
            off_eth_psi.FileName = @"C:\Windows\System32\cmd.exe";
            off_eth_psi.WorkingDirectory = @"C:\Windows\System32";
            off_eth_psi.UseShellExecute = false;
            off_eth_psi.CreateNoWindow = true;
            off_eth_psi.RedirectStandardInput = true;
            off_eth_psi.Verb = "runas";
            Process off_eth_pr = new Process();
            off_eth_psi.Arguments = string.Format(@"/c netsh interface set interface ""Ethernet"" enable");
            off_eth_pr.StartInfo = off_eth_psi;
            off_eth_pr.Start();
            off_eth_pr.WaitForExit();
            off_eth_pr.Close();
        }
    }
}
