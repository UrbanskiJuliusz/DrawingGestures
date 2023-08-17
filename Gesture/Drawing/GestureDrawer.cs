using AssassinRunner.Gesture.Recognition;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

namespace AssassinRunner.Gesture.Drawing
{
    public class GestureDrawer : MonoBehaviour, IGestureDrawer
    {
        [Header("Dependencies")]
        [SerializeField] private GestureRecognizer gestureRecognizer;
        [SerializeField] private LineManager lineManager;

        [Header("Drawing Settings")]
        [SerializeField] private LineRenderer lineRenderer;
        [SerializeField] private GameObject linePrefab;

        private DrawingData drawingData = new DrawingData();

        public void StartDrawing(InputAction.CallbackContext context)
        {
            if (lineRenderer == null)
            {
                Debug.LogError("LineRenderer is not set.");
                return;
            }

            if (context.started)
            {
                drawingData.IsDrawing = true;
                StartCoroutine(lineManager.DrawPoints(lineRenderer, drawingData));
            }
        }

        public void StopDrawing(InputAction.CallbackContext context)
        {
            drawingData.IsDrawing = false;
            StopAllCoroutines();

            gestureRecognizer.RecognizeGesture(drawingData.Points);
            lineManager.CreateAndFadeOutLineCopy(lineRenderer, linePrefab);

            drawingData.Points.Clear();
            lineRenderer.positionCount = 0;
        }
    }
}