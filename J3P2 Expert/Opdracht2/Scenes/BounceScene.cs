using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2.Scenes
{
    public class BounceScene : SceneBase
    {
        private Texture2D _objectTexture;
        private SpriteFont _font;

        public BounceScene(Texture2D objectTexture, SpriteFont font)
        {
            _objectTexture = objectTexture;
            _font = font;
        }

        public override void Initialize()
        {
            base.Initialize();

            Vector2[] positions =
            [
                new(400, 300),
                new(300, 200),
                new(500, 200),
                new(650, 200),
                new(250, 400),
                new(600, 400)


            ];
            //add objects
            ObjectInitialize(_objectTexture, 1, new Vector2(-1,-1),250f, positions[0]);
            ObjectInitialize(_objectTexture, 1, new Vector2(1,1),250f, positions[0]);
            ObjectInitialize(_objectTexture, 5f, new Vector2(0,1),150f, positions[1]);
            ObjectInitialize(_objectTexture, .5f, new Vector2(1,0),50f, positions[2]);
        }

        //TODO: change this
        private void ObjectInitialize(Texture2D texture, float speed, Vector2 direction, float amplitude, Vector2 position)
        {
            var gameObject = new BouncerObject(texture, speed, direction ,amplitude, position);
            gameObject.AddTextRenderer(_font, $"Direction: {direction},\n amplitude: {amplitude}\nspeed: {speed}", Color.Red);
            gameObject.Transform.Position = position;
            GameObjects.Add(gameObject);
        }
    }
}