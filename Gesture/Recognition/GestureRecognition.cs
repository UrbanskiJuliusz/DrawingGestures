using System.Collections.Generic;
using UnityEngine;
using System;
using AssassinRunner.Gesture.Actions;
using Zenject;

namespace AssassinRunner.Gesture.Recognition
{
    public class GestureRecognizer : MonoBehaviour
    {
        [Inject] private List<IGestureAction> gestureActions;
        public event Action<IGestureAction> OnGestureRecognized = delegate { };

        public void RecognizeGesture(List<Vector2> points)
        {
            if (points.Count < 2)
            {
                Debug.LogWarning("Not enough points to create a gesture.");
                return;
            }

            bool isRecognized = false;
            foreach (var action in gestureActions)
            {
                if (action.IsGestureRecognized(points))
                {
                    isRecognized = true;
                    OnGestureRecognized.Invoke(action);
                    break;
                }
            }

            if (!isRecognized)
            {
                Debug.LogWarning("No gesture action was recognized.");
            }
        }
    }
}