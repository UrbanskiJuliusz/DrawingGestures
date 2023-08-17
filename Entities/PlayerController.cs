using AssassinRunner.Gesture.Actions;
using UnityEngine;

namespace Assets.Scripts.Entities
{
    [RequireComponent(typeof(EntityPathController))]
    public class PlayerController : MonoBehaviour
    {
        public void PerformAction(IGestureAction action, IGestureData data)
        {
            action.Execute(data);
        }
    }
}