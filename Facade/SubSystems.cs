using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TV
    {
        public void On() => Console.WriteLine("TV is On");
        public void SetInputChannel() => Console.WriteLine("TV channel is set to HDMI");
    }

    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound System is On");
        public void SetVolume(int level) => Console.WriteLine($"Sound System volume set to {level}");
    }

    public class BluRayPlayer
    {
        public void On() => Console.WriteLine("Blu-ray Player is On");
        public void Play() => Console.WriteLine("Blu-ray Player is playing");
    }

    public class Lights
    {
        public void Dim() => Console.WriteLine("Lights are dimmed");
    }

}
