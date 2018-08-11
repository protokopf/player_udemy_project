using Assets.Scripts.Abstract;
using UnityEngine;

namespace Assets.Scripts.Animation
{
    public class AnimationBehaviour : AbstractAnimationBehaviour
    {
        public Animator Animator;
        public SpriteRenderer SpriteRenderer;

        public override void Attack()
        {
            Animator.SetTrigger("Attack");
        }

        public override void HorizontalMove(float movement)
        {
            Animator.SetBool("Move", movement != 0);

            if(movement > 0)
            {
                SpriteRenderer.flipX = false;
            }
            else if (movement < 0)
            {
                SpriteRenderer.flipX = true;
            }
        }

        public override void Jump(bool jumping)
        {
            Animator.SetBool("Jump", jumping);
        }
    }
}
