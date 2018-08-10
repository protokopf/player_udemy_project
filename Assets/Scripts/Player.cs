using Assets.Scripts.Abstract;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        private bool _wasGrounded = true;
        private bool _isJumping = false;

        public AbstractMovementBehaviour MovementBehaviour;
        public AbstractAnimationBehaviour AnimationBehaviour;

        public Rigidbody2D RidigBody;

        public float JumpAcceleration;

        public float JumpOffsetSeconds;

        public float Speed = 1.0f;

        public float RaycastDistance;

        public LayerMask LayerMask;
	
        // Update is called once per frame
        public void Update ()
        {
            float horizontalMovement = MovementBehaviour.GetHorizontalMovement();
            Debug.DrawRay(transform.position, Vector2.down * RaycastDistance, Color.green);

            bool isGrounded = IsGrounded();

            if(!_wasGrounded && isGrounded)
            {
                _isJumping = false;
            }
            _wasGrounded = isGrounded;

            if (!_isJumping)
            {
                AnimationBehaviour.HorizontalMove(horizontalMovement);
                if (MovementBehaviour.GetHasJumped() && isGrounded)
                {
                    _isJumping = true;
                    AnimationBehaviour.Jump();
                    StartCoroutine(JumpCoroutine());
                }
            }

            RidigBody.velocity = new Vector2(horizontalMovement * Speed, RidigBody.velocity.y);         
        }

        private bool IsGrounded()
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, RaycastDistance, LayerMask);
            return hit.collider != null;
        }

        private IEnumerator JumpCoroutine()
        {
            yield return new WaitForSeconds(JumpOffsetSeconds);
            RidigBody.velocity = new Vector2(RidigBody.velocity.x, RidigBody.velocity.y + JumpAcceleration);
        }
    }
}
