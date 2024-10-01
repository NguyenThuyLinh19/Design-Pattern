using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private TV _tv;
        private SoundSystem _soundSystem;
        private BluRayPlayer _bluRayPlayer;
        private Lights _lights;

        public HomeTheaterFacade(TV tv, SoundSystem soundSystem, BluRayPlayer bluRayPlayer, Lights lights)
        {
            _tv = tv;
            _soundSystem = soundSystem;
            _bluRayPlayer = bluRayPlayer;
            _lights = lights;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Preparing to watch a movie...");
            _lights.Dim();
            _tv.On();
            _tv.SetInputChannel();
            _soundSystem.On();
            _soundSystem.SetVolume(10);
            _bluRayPlayer.On();
            _bluRayPlayer.Play();
            Console.WriteLine("Movie is now playing!");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie...");
            _tv.On();
            _soundSystem.On();
            _bluRayPlayer.On();
            Console.WriteLine("Movie is finished!");
        }
    }

}
