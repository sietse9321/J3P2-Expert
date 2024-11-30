using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace CSharpExpert.Assignment3.StudentStartPoints
{
    public class StarPrefabScene : SceneBase
    {
        //Prefabs to Instantiate from
        private Rotater _rotatorPrefab;
        private Bouncer _bouncerPrefab;
        private Scaler _scalerPrefab;
        private ColorShifter _colorShiferPrefab;

        public StarPrefabScene(Game1 pGame)
        {
            //TODO Create 4 prefabs
            //_rotatorPrefab = new Rotator(...);
            //_bouncerPrefab = new Bouncer(...);
            //_scalerPrefab = new Scaler(...);
            //_colorShifterPrefab = new ColorShifter(...);
        }

        protected void CreateStar(Vector2 pPosition, PrefabComponent pType)
        {
            //A list to contain all possible components
            List<MonoBehaviour> components = new List<MonoBehaviour>();

            //A series of if statements, adding a prefab (by use of a copy constructor) to the "components" list if pType has the associated Flag

            //if ((pType & PrefabComponent.A) != 0)
            if (pType.HasFlag(PrefabComponent.Rotater))
            {
                components.Add(new Rotater(_rotatorPrefab));
            }

            //if ((pType & PrefabComponent.B) != 0)
            if (pType.HasFlag(PrefabComponent.Bouncer))
            {
                components.Add(new Bouncer(_bouncerPrefab));
            }

            //if ((pType & PrefabComponent.C) != 0)
            if (pType.HasFlag(PrefabComponent.Scaler))
            {
                components.Add(new Scaler(_scalerPrefab));
            }

            //if ((pType & PrefabComponent.D) != 0)
            if (pType.HasFlag(PrefabComponent.ColorShifter))
            {
                components.Add(new ColorShifter(_colorShiferPrefab));
            }

            //TODO Create a transform for the newGameObject
            Transform transform;// = new Transform(...);

            //Creates a string based on the combination of different components, for example: just "A", or "A, B, C, D" and everything in between
            string componentCombinationString = pType.ToString();

            //TODO Create a SpriteRenderer component and add it to the "components" List
            //components.Add(new SpriteRenderer(...));
            //OPTIONAL TODO Make sure this object draws the test of "componentCombinationString" underneath it, maybe via SpriteRenderer or a TextRenderer component?

            //TODO Create a new GameObject and add all components in the "components" list to the new GameObject (preferable via the Constructor using the "params" keyword, see (Extra Criteria)
            GameObject newGameObject;// = new DGameObject(...,components.ToArray());
            //_gameObjects.Add(newGameObject);
        }
    }
}