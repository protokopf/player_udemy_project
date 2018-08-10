using Assets.Scripts.Abstract;
using UnityEngine;

namespace Assets.Scripts.Animation
{
    public class AnimationBehaviour : AbstractAnimationBehaviour
    {
        public Animator Animator;
        public SpriteRenderer SpriteRenderer;

        public override void HorizontalMove(float movement)
        {
            Animator.SetBool("Move", movement != 0);

            SpriteRenderer.flipX = movement < 0;
        }

    }
}
