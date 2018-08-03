﻿using Assets.Scripts.Abstract;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public AbstractMovementBehaviour MovementBehaviour;

        public Rigidbody2D RidigBody;

        public float JumpAcceleration;

        public float RaycastDistance;

        public LayerMask LayerMask;


        // Use this for initialization
        public void Start ()
        {
        }
	
        // Update is called once per frame
        public void Update ()
        {
            float horizontalMovement = MovementBehaviour.GetHorizontalMovement();
            float verticalMovement = RidigBody.velocity.y;
            Debug.DrawRay(transform.position, Vector2.down, Color.green);


            if (MovementBehaviour.GetHasJumped() && IsGrounded())
            {
                verticalMovement += JumpAcceleration;
            }

            RidigBody.velocity = new Vector2(horizontalMovement, verticalMovement);
        }

        private bool IsGrounded()
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, RaycastDistance, LayerMask);
            return hit.collider != null;
        }
    }
}
