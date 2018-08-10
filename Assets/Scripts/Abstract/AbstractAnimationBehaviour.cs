using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Abstract
{
    public abstract class AbstractAnimationBehaviour: MonoBehaviour
    {
        public abstract void HorizontalMove(float movement);
    }
}
