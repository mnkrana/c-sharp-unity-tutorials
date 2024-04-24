using UnityEngine;
using UnityEngine.UI;

namespace Tutorial.FindObjects
{
    public class ImageFinder : MonoBehaviour
    {
        private Image image;

        private void Start()
        {
            image = GetComponent<Image>();                        
        }

        public void ChangeColor()
        {
            image.color = Color.red;
        }
    }
}