using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Abstract;
using UnityEngine;

namespace Assets.Scripts.Movement
{
    public class KeyboardMovementBehaviour: AbstractMovementBehaviour
    {
        public override bool GetHasAttacked()
        {
            return Input.GetKeyDown(KeyCode.E);
        }

        public override bool GetHasJumped()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }

        public override float GetHorizontalMovement()
        {
            return Input.GetAxisRaw("Horizontal");
        }
    }
}
