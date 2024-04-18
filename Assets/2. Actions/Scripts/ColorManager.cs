using UnityEngine;

namespace Tutorial.Actions
{
    public class ColorManager : MonoBehaviour
    {        
        public void OnRedClick()
        {
            TutorialEvents.OnColorChange?.Invoke(Color.red);
            TutorialEvents.OnScaleChange?.Invoke(Vector3.one * 0.5f);
        }

        public void OnGreenClick()
        {
            TutorialEvents.OnColorChange?.Invoke(Color.green);
            TutorialEvents.OnScaleChange?.Invoke(Vector3.one);
        }
    }
}