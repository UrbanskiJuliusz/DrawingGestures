using Assets.Scripts.Entities;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace AssassinRunner.Gesture.Actions.Movement
{
    public class HorizontalLineGestureAction : IGestureAction
    {
        [Inject] private EntityController playerController;

        float gestureHorizontalDistance;
        float gestureVerticalDistance;

        public bool IsGestureRecognized(List<Vector2> points)
        {
            gestureHorizontalDistance = points[^1].x - points[0].x;
            gestureVerticalDistance = points[^1].y - points[0].y;

            return Mathf.Abs(gestureHorizontalDistance) > Mathf.Abs(gestureVerticalDistance);
        }

        public IGestureData GetActionData()
        {
            if (gestureHorizontalDistance > 0)
                return new LineGestureData(playerController.Entity, Direction.Right, playerController.EntityPathController);
            else
                return new LineGestureData(playerController.Entity, Direction.Left, playerController.EntityPathController);
        }

        public void Execute(IGestureData data)
        {
            if (data is LineGestureData lineData)
            {
                float direction = (lineData.direction == Direction.Left) ? -1 : 1;
                lineData.player.Path = lineData.unitPathController.ChangePath(direction, lineData.player.Path);
            }
        }
    }
}