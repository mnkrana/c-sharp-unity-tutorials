using UnityEngine;

namespace Tutorial.FindObjects
{
    public class ColorManager : MonoBehaviour
    {
        public void ChangeColors()
        { 
            var finders = FindObjectsOfType<ImageFinder>();
            foreach(var finder in finders)
            {
                finder.ChangeColor();
            }

            FindTransforms();
        }

        public void FindTransforms()
        {
            var transforms = GetComponentsInChildren<Transform>();
            foreach(var trans in transforms)
            {
                if(trans == transform) continue;
                Debug.Log($"Name {trans.name}");
            }
        }
    }
}