using System.Collections.Generic;
using UnityEngine;

namespace AssassinRunner.Gesture.Drawing
{
    public class DrawingData
    {
        public List<Vector2> Points { get; set; } = new List<Vector2>();
        public bool IsDrawing { get; set; } = false;
    }
}