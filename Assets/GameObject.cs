using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharpExpert.Assignment3.StudentStartPoints
{
    public class GameObject
    {
        //Fields
        private Transform _transform;
        private List<MonoBehaviour> _components = new List<MonoBehaviour>();

        //Properties
        public Transform Transform => _transform;

        //WARNING Not allowed to add a SpriteRenderer Property or SpriteRenderer Field in this class! Not all GameObjects need to be able to render and therefor it is not wise to add a Property or Field for it, unlike Transform

        //Methods
        public void AwakeComponents() { }
        public void StartComponents() { }

        public virtual void UpdateGameObject(GameTime pGameTime) { }
        public virtual void DrawGameObject(SpriteBatch pSpriteBatch) { }

        public void AddComponent(MonoBehaviour pBehaviour) { }
        public void RemoveComponent(MonoBehaviour pBehaviour) { }

        public T GetComponent<T>() where T : MonoBehaviour
        {
            for (int i = 0; i < _components.Count; i++)
            {
                if (_components[i] is T behaviour)//Also finds inherited class types (GetComponent<MonoBehaviour>() will return every component which is a MonoBehaviour or a child class of MonoBehaviour
                {
                    return behaviour;
                }

                //if (_components[i].GetType() == typeof(T))//Only finds specifically requested class types (GetComponent<MonoBehaviour>() will return only components which are of type MonoBehaviour, no child classes of MonoBehaviour
                //{
                //    return (T)_components[i];
                //}
            }
            return null;
        }
    }
}