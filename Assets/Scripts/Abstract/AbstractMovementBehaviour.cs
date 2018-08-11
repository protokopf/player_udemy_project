using UnityEngine;

namespace Assets.Scripts.Abstract
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractMovementBehaviour : MonoBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract float GetHorizontalMovement();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract bool GetHasJumped();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract bool GetHasAttacked();
    }
}
