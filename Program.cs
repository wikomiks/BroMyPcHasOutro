using System.Media;
using System.Diagnostics;

namespace outro
{
    internal class Program
    {
        static void Main()
        {
            SoundPlayer sound = new SoundPlayer("outro.wav");
            sound.PlaySync();
            Process.Start("shutdown.exe", "-s -t 00");
        }
    }
}
