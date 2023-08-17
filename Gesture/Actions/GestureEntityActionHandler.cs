using AssassinRunner.Gesture.Recognition;
using Assets.Scripts.Entities;
using UnityEngine;

namespace AssassinRunner.Gesture.Actions
{
    public class GestureEntityActionHandler : MonoBehaviour
    {
        [SerializeField] private EntityController entityController;
        [SerializeField] private GestureRecognizer gestureRecognizer;

        private void OnEnable() => gestureRecognizer.OnGestureRecognized += HandleGestureAction;

        private void OnDisable() => gestureRecognizer.OnGestureRecognized -= HandleGestureAction;

        public void HandleGestureAction(IGestureAction recognizedAction)
        {
            var actionData = recognizedAction.GetActionData();
            entityController.PerformAction(recognizedAction, actionData);
        }
    }
}