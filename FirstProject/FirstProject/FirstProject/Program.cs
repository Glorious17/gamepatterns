using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SFML;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace FirstProject
{
    class Program
    {
        public bool running = true;
        private Player player;

        static void Main(string[] args)
        {
            Program game = new Program();
            game.Run();
        }

        public void Run()
        {
            Initialize();

            var window = new RenderWindow(new VideoMode(800,600), "Pong", Styles.Default);
            DateTime previous_time = DateTime.Now;
            DateTime current_time;
            double delta;

            while (running)
            {
                current_time = DateTime.Now;
                delta = current_time.Subtract(previous_time).TotalMilliseconds;
                previous_time = current_time;

                window.DispatchEvents();
                window.Closed += (sender, evtArgs) => running = false;

                Update(delta);

                window.Clear(Color.Black);      
                Render(window);
                window.Display();
            }
        }

        private void Initialize()
        {
            //player = new Player(new Vector2u(20,20), new Vector2f(10,10));
            //player.setTexture("C:/Users/Jens/Desktop/6. Semester/Programming Patterns/FirstProject/pall.png");
            player = new Player(10, 100, new Vector2f(10, 200), Color.Green, 0);
            Console.Write(player.getSprite());
        }

        private void Update(double delta)
        {
            //Console.WriteLine("delta: " + delta);
        }

        private void Render(RenderWindow window)
        {
            window.Draw(player.getRect());
        }
    }
}
