using Assets.Scripts.Entities;

namespace AssassinRunner.Gesture.Actions.Movement
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    public struct LineGestureData : IGestureData
    {
        public LineGestureData(Entity player, Direction direction, EntityPathController unitPathController)
        {
            this.player = player;
            this.direction = direction;
            this.unitPathController = unitPathController;
        }

        public readonly Entity player;
        public readonly Direction direction;
        public readonly EntityPathController unitPathController;
    }
}