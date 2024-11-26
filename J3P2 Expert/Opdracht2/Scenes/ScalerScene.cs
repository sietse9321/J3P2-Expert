using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2.Scenes
{
    public class ScalerScene : SceneBase
    {
        private Texture2D _objectTexture;
        private SpriteFont _font;

        public ScalerScene(Texture2D objectTexture, SpriteFont font)
        {
            _objectTexture = objectTexture;
            _font = font;
        }

        public override void Initialize()
        {
            base.Initialize();

            Vector2[] positions =
            [
                new(150, 150),
                new(400, 150),
                new(700, 150),
                new(700, 400),
                new(75, 400),
                new(250, 400),
                new(400, 400)
            ];

            //creates object with texture, speed, minimumscale, maximumscale, and the position
            ObjectInitialize(_objectTexture, 1.0f, new Vector2(1f, 0.2f), new Vector2(1f, 2f), positions[0]);
            ObjectInitialize(_objectTexture, 1.0f, new Vector2(0.2f, 1f), new Vector2(2f, 1f), positions[1]);
            ObjectInitialize(_objectTexture, 0.5f, new Vector2(0.2f, 1f), new Vector2(2f, 1f), positions[2]);
            ObjectInitialize(_objectTexture, 0.5f, new Vector2(0.5f, 0f), new Vector2(1f, 1f), positions[3]);
            ObjectInitialize(_objectTexture, 2.0f, new Vector2(0f, 0f), new Vector2(1f, 1f), positions[4]);
            ObjectInitialize(_objectTexture, 1.0f, new Vector2(0f, 0f), new Vector2(1f, 1f), positions[5]);
            ObjectInitialize(_objectTexture, 0.5f, new Vector2(0f, 0f), new Vector2(1f, 1f), positions[6]);
        }

        private void ObjectInitialize(Texture2D texture, float speed, Vector2 minScale, Vector2 maxScale, Vector2 position)
        {
            //creates object with texture, speed, minimumscale and maximumscale
            var gameObject = new ScalerObject(texture, speed, minScale, maxScale);
            //adds a textrenderer with the following parameters
            gameObject.AddTextRenderer(_font, $"Scale speed: {speed}\nMinScale: {minScale}\nMaxScale: {maxScale}", Color.Red);
            //sets the objects position
            gameObject.Transform.Position = position;
            //adds it to the gameobjects list
            GameObjects.Add(gameObject);
        }
    }
}