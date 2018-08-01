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
        public override float GetHorizontalMovement()
        {
            return Input.GetAxis("Horizontal");
        }
    }
}
