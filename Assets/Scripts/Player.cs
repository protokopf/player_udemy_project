using Assets.Scripts.Abstract;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public AbstractMovementBehaviour MovementBehaviour;

        public Rigidbody2D RidigBody;

        // Use this for initialization
        public void Start ()
        {
		
        }
	
        // Update is called once per frame
        public void Update ()
        {
            float horizontalMovement = MovementBehaviour.GetHorizontalMovement();
            RidigBody.velocity = new Vector2(horizontalMovement, RidigBody.velocity.y);
        }
    }
}
