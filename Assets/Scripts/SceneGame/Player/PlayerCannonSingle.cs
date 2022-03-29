using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class PlayerCannonSingle : PlayerCannonBase
    {
        [SerializeField]
        private Transform _bulletStartPosition;

        protected override void Shot()
        {
            var bullet = _bulletsPool.GetBullet();
            if (bullet == null) {
                Debug.Log("!");
            }
            else
            {
                bullet.transform.position = _bulletStartPosition.position;
                bullet.transform.Rotate(transform.rotation.eulerAngles);
                bullet.SetActive(true);
            }
        }
    }
}
