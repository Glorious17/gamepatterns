using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;
using SFML.Graphics;

namespace FirstProject
{
    class Player
    {

        //Falls ein Sprite geladen wird
        private Texture texture;
        private Sprite sprite = new Sprite();

        //Falls ein Shape generiert wird
        private RectangleShape rect;

        public Player(Vector2u size, Vector2f position, int rotate = 0)
        {
            sprite.Position = position;
            sprite.Rotation = rotate;
        }

        public Player(int width, int height, Vector2f position, Color color, int rotate = 0)
        {
            rect = new RectangleShape(new Vector2f(width, height));
            rect.FillColor = color;
            rect.Rotation = rotate;
            rect.Position = position;
        }

        public void setTexture(String url)
        {
            texture = new Texture(new Image(url));
            sprite.Texture = texture;
        }

        public void setColor(Color c)
        {
            sprite.Color = c;
        }

        public void setPositionSprite(Vector2f pos)
        {
            sprite.Position = pos;
        }

        public void setPositionRect(Vector2f pos)
        {
            rect.Position = pos;
        }

        public void setRotation(int rotate)
        {
            sprite.Rotation = rotate;
        }

        public Sprite getSprite()
        {
            return sprite;
        }

        public RectangleShape getRect()
        {
            return rect;
        }

    }
}
