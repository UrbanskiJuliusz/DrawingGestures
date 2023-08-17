using System.Collections.Generic;
using UnityEngine;

namespace AssassinRunner.Gesture.Actions
{
    // Contract for actions that can be triggered by recognized gestures.
    public interface IGestureAction
    {
        bool IsGestureRecognized(List<Vector2> points);
        IGestureData GetActionData();
        void Execute(IGestureData data);
    }
}