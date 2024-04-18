using System;
using UnityEngine;

namespace Tutorial.Actions
{
    public static class TutorialEvents
    {
        public static Action<Color32> OnColorChange;
        public static Action<Vector3> OnScaleChange;
    }
}