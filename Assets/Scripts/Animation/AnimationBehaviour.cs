using Assets.Scripts.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Animation
{
    public class AnimationBehaviour : AbstractAnimationBehaviour
    {
        public Animator Animator;
        public SpriteRenderer SpriteRenderer;

        public override void HorizontalMove(float movement)
        {
            Animator.SetBool("IsRight", movement > 0);
            Animator.SetBool("IsLeft", movement < 0);
            SpriteRenderer.flipX = movement < 0;
        }
    }
}
