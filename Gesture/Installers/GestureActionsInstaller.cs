using AssassinRunner.Gesture.Actions;
using AssassinRunner.Gesture.Actions.Movement;
using Assets.Scripts.Entities;
using Zenject;

namespace AssassinRunner.Gesture.Installers
{
    public class GestureActionsInstaller : MonoInstaller
    {
        public EntityController PlayerController;

        public override void InstallBindings()
        {
            Container.Bind<EntityController>().FromInstance(PlayerController).AsSingle();

            Container.Bind<IGestureAction>().To<HorizontalLineGestureAction>().AsTransient();
            Container.Bind<IGestureAction>().To<VerticalLineGestureAction>().AsTransient();
        }
    }
}