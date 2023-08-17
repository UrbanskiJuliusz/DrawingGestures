using Assets.Scripts.Entities;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace AssassinRunner.Gesture.Actions.Movement
{
    public class VerticalLineGestureAction : IGestureAction
    {
        [Inject] private EntityController playerController;

        float gestureHorizontalDistance;
        float gestureVerticalDistance;

        public bool IsGestureRecognized(List<Vector2> points)
        {
            gestureHorizontalDistance = points[^1].x - points[0].x;
            gestureVerticalDistance = points[^1].y - points[0].y;

            return Mathf.Abs(gestureVerticalDistance) > Mathf.Abs(gestureHorizontalDistance);
        }

        public IGestureData GetActionData()
        {
            if (gestureVerticalDistance > 0)
                return new LineGestureData(playerController.Entity, Direction.Up, playerController.EntityPathController);
            else
                return new LineGestureData(playerController.Entity, Direction.Down, playerController.EntityPathController);
        }

        public void Execute(IGestureData data)
        {
            if (data is LineGestureData lineData)
            {
                lineData.player.JumpTriggered = (lineData.direction == Direction.Up);
                lineData.player.RollTriggered = (lineData.direction == Direction.Down);
            }
        }
    }
}