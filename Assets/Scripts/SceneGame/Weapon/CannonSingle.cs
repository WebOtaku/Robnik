using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class CannonSingle : CannonBase
    {
        [SerializeField]
        private Transform _bulletStartPosition;

        public override void Shot()
        {
            BulletActivate(_bulletStartPosition);
        }
    }
}
