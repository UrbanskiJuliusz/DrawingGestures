using UnityEngine.InputSystem;

namespace AssassinRunner.Gesture.Drawing
{
    public interface IGestureDrawer
    {
        void StartDrawing(InputAction.CallbackContext context);
        void StopDrawing(InputAction.CallbackContext context);
    }
}