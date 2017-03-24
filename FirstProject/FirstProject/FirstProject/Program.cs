using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SFML;
using SFML.Graphics;
using SFML.Window;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var rw = new RenderWindow(VideoMode.FullscreenModes[0], "Helloworld", Styles.Default);
            bool running = true;
            while(running)
            {
                rw.Clear(Color.Cyan);
                rw.DispatchEvents();
                rw.Closed += (sender, evtArgs) => running = false;
                rw.Display();
            }
        }
    }
}
