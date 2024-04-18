using UnityEngine;
using UnityEngine.UI;

namespace Tutorial.Actions
{
    public class ColorChanger : MonoBehaviour
    {
        private Image image;

        void Start()
        {
            image = GetComponent<Image>();
        }

        private void OnEnable()
        {
            TutorialEvents.OnColorChange += ColorChange;
            TutorialEvents.OnScaleChange += ScaleChange;
        }

        private void OnDisable()
        {
            TutorialEvents.OnColorChange -= ColorChange;
            TutorialEvents.OnScaleChange -= ScaleChange;
        }

        private void ScaleChange(Vector3 vector)
        {
            transform.localScale = vector;
        }


        private void ColorChange(Color32 color)
        {
            image.color = color;
        }
    }
}