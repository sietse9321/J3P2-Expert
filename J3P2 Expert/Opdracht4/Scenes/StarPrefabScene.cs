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

        public StarPrefabScene(Texture2D objectTexture, SpriteFont font)
        {
            //TODO Create 4 prefabs
            _starTexture = objectTexture;
            _rotatorPrefab = new Rotater(1f, false);
            _bouncerPrefab = new Bouncer(1, new Vector2(0f, -1f), 100f, new Vector2(200f, 400f));
            _scalerPrefab = new Scaler(0.5f, new Vector2(0.2f, 0.2f), new Vector2(1f, 1f));
            _colorShifterPrefab = new ColorShifter(1f);
        }

        protected void CreateStar(Vector2 pPosition, PrefabComponent pType)
        {
            //A list to contain all possible components
            List<MonoBehaviour> components = new List<MonoBehaviour>();

            //A series of if statements, adding a prefab (by use of a copy constructor) to the "components" list if pType has the associated Flag

            //if ((pType & PrefabComponent.A) != 0)
            if (pType.HasFlag(PrefabComponent.Rotater))
            {
                components.Add(_rotatorPrefab);
            }

            // //if ((pType & PrefabComponent.B) != 0)
            if (pType.HasFlag(PrefabComponent.Bouncer))
            {
                components.Add(_bouncerPrefab);
            }
            //
            // //if ((pType & PrefabComponent.C) != 0)
            if (pType.HasFlag(PrefabComponent.Scaler))
            {
                components.Add(_scalerPrefab);
            }
            //
            // //if ((pType & PrefabComponent.D) != 0)
            if (pType.HasFlag(PrefabComponent.ColorShifter))
            {
                components.Add(_colorShifterPrefab);
            }

            //Creates a string based on the combination of different components, for example: just "A", or "A, B, C, D" and everything in between
            string componentCombinationString = pType.ToString();

            //TODO Create a SpriteRenderer component and add it to the "components" List
            components.Add(new SpriteRenderer(_starTexture));
            //OPTIONAL TODO Make sure this object draws the test of "componentCombinationString" underneath it, maybe via SpriteRenderer or a TextRenderer component?

            //TODO Create a new GameObject and add all components in the "components" list to the new GameObject (preferable via the Constructor using the "params" keyword, see (Extra Criteria)
            GameObject newGameObject = new GameObject(_starTexture, components.ToArray());
            newGameObject.Transform.Position = pPosition;
            GameObjects.Add(newGameObject);
        }
        //TODO: add the basic initialize

        public override void Initialize()
        {
            CreateStar(new Vector2(200, 200), PrefabComponent.Rotater | PrefabComponent.Bouncer | PrefabComponent.Scaler | PrefabComponent.ColorShifter);
            base.Initialize();
        }


        // public override void Update(GameTime gameTime)
        // {
        //     base.Update(gameTime);
        // }
    }
}