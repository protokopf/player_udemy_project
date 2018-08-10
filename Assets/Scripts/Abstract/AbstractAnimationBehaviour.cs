using UnityEngine;

namespace Assets.Scripts.Abstract
{
    public abstract class AbstractAnimationBehaviour: MonoBehaviour
    {
        public abstract void HorizontalMove(float movement);

        public abstract void Jump(bool jumping);
    }
}
