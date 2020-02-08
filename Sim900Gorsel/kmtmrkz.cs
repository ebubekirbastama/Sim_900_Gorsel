using System.IO.Ports;
using System.Threading;

/// <summary>
/// Ebubekir Bastama  www.ebubekirbastama.com
/// </summary>
namespace Sim900Gorsel
{
    public class kmtmrkz
    {
        public static Thread th; static string returndgr;
        public static SerialPort sp = new SerialPort();
        public static string  bekracommand(string cmd)
        {
           
            if (sp.IsOpen)
            {
                sp.Write(cmd);
                returndgr = sp.ReadExisting().ToString();
            }
            return returndgr;
        }
    }
}
