using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla models = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            models.Drive();
            mx410.Drive();
        }
    }
}
