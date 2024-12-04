using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht4.Behaviour;
using CSharp_Expert.Opdracht4.BaseClass;


namespace CSharp_Expert.Opdracht4.Scenes
{
    public class StarPrefabScene : SceneBase
    {
        private Texture2D _starTexture;

        //Prefabs to Instantiate from
        private Rotater _rotatorPrefab;
        private Bouncer _bouncerPrefab;
        private Scaler _scalerPrefab;
        private ColorShifter _colorShifterPrefab;

        public StarPrefabScene(GraphicsDeviceManager graphics, Texture2D objectTexture, SpriteFont font) : base(graphics)
        {
            //TODO Create 4 prefabs
            _starTexture = objectTexture;
            _rotatorPrefab = new Rotater(1f, false);
            _bouncerPrefab = new Bouncer(1, new Vector2(0f, -1f), 100f);
            _scalerPrefab = new Scaler(0.5f, new Vector2(0.2f, 0.2f), new Vector2(1f, 1f));
            _colorShifterPrefab = new ColorShifter(1f);
        }

        protected void CreateStar(Vector2 pPosition, PrefabComponent pType)
        {
            List<MonoBehaviour> components = new List<MonoBehaviour>();

            //check type has flag
            if (pType.HasFlag(PrefabComponent.Rotater))
            {
                //create a new instance
                components.Add(new Rotater(1f, false));
            }

            if (pType.HasFlag(PrefabComponent.Bouncer))
            {
                components.Add(new Bouncer(1, new Vector2(0f, -1f), 100f));
            }

            if (pType.HasFlag(PrefabComponent.Scaler))
            {
                components.Add(new Scaler(0.5f, new Vector2(0.2f, 0.2f), new Vector2(1f, 1f)));
            }

            if (pType.HasFlag(PrefabComponent.ColorShifter))
            {
                components.Add(new ColorShifter(1f));
            }

            //creates a new spriterenderer
            components.Add(new SpriteRenderer(_starTexture));

            //creates a new object with the given parameters
            GameObject newGameObject = new GameObject(_starTexture, components.ToArray());
            newGameObject.Transform.Position = pPosition;
            GameObjects.Add(newGameObject);
        }


        public override void Initialize()
        {
            //CreateStar(new Vector2(200, 200), PrefabComponent.Rotater | PrefabComponent.Bouncer | PrefabComponent.Scaler | PrefabComponent.ColorShifter);
            base.Initialize();
        }
    }
}