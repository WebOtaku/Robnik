using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class CannonMultiple : CannonBase
    {
        [SerializeField]
        private List<Transform> _bulletsStartPosition;

        public override void Shot()
        {
            foreach (var item in _bulletsStartPosition)
            {
                BulletActivate(item);
            }
        }
    }
}
