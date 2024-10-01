using Facade;

class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo các hệ thống con
        TV tv = new TV();
        SoundSystem soundSystem = new SoundSystem();
        BluRayPlayer bluRayPlayer = new BluRayPlayer();
        Lights lights = new Lights();

        // Tạo Facade để quản lý hệ thống
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, soundSystem, bluRayPlayer, lights);

        // Bắt đầu xem phim với một lệnh duy nhất
        homeTheater.WatchMovie();

        // Kết thúc xem phim
        homeTheater.EndMovie();
    }
}
