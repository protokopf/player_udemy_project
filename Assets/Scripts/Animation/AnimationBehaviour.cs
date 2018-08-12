using Assets.Scripts.Abstract;
using UnityEngine;

namespace Assets.Scripts.Animation
{
    public class AnimationBehaviour : AbstractAnimationBehaviour
    {
        public Animator PlayerAnimator;
        public Animator SwordAnimator;

        public SpriteRenderer PlayerSpriteRenderer;
        public SpriteRenderer SwordSpriteRenderer;

        public override void Attack()
        {
            PlayerAnimator.SetTrigger("Attack");
            SwordAnimator.SetTrigger("Attack");
        }

        public override void HorizontalMove(float movement)
        {
            PlayerAnimator.SetBool("Move", movement != 0);

            if(movement > 0)
            {
                PlayerSpriteRenderer.flipX = false;
                SwordSpriteRenderer.flipX = false;
            }
            else if (movement < 0)
            {
                PlayerSpriteRenderer.flipX = true;
                SwordSpriteRenderer.flipX = true;
            }
        }

        public override void Jump(bool jumping)
        {
            PlayerAnimator.SetBool("Jump", jumping);
        }
    }
}
