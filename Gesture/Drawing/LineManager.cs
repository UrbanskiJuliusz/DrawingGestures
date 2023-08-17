using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace AssassinRunner.Gesture.Drawing
{
    public class LineManager : MonoBehaviour
    {
        public IEnumerator DrawPoints(LineRenderer lineRenderer, DrawingData drawingData)
        {
            Vector2 positionToAdd;
            Camera mainCamera = Camera.main;
            lineRenderer.positionCount = 0;

            while (drawingData.IsDrawing)
            {
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)
                positionToAdd = Touchscreen.current.primaryTouch.position.ReadValue();
#else
                positionToAdd = Mouse.current.position.ReadValue();
#endif

                Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(new Vector3(positionToAdd.x, positionToAdd.y, 1f)) - mainCamera.transform.position;

                drawingData.Points.Add(positionToAdd);
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, mouseWorldPosition);

                yield return null;
            }
        }

        public void CreateAndFadeOutLineCopy(LineRenderer lineRenderer, GameObject linePrefab)
        {
            Vector3[] newPos = new Vector3[lineRenderer.positionCount];
            lineRenderer.GetPositions(newPos);

            GameObject lineObject = Instantiate(linePrefab, this.transform);
            LineRenderer newLineRenderer = lineObject.GetComponent<LineRenderer>();
            newLineRenderer.positionCount = lineRenderer.positionCount;
            newLineRenderer.SetPositions(newPos);

            lineObject.transform.SetParent(lineRenderer.transform.parent);
            lineObject.transform.localPosition = lineRenderer.transform.localPosition;
            lineObject.transform.localRotation = lineRenderer.transform.localRotation;
        }
    }
}