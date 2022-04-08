using System;
using System.Media;

namespace Sound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory+ "\\bell.wav";
            player.Play();
            Console.ReadLine();
        }
    }
}
