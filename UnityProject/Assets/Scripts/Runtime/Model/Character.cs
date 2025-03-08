using Game.Model;
using Leap.Forward.Composition;

namespace Game
{
    public partial class Character : ContainerBase<Character>
    {
        [AttachedModule]
        private CharacterHealth _healthManager;

        protected override void OnEnable()
        {
            base.OnEnable();
        }
    }
}
