using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class PlayerCannonMultiple : PlayerCannonBase
    {
        [SerializeField]
        private List<Transform> _bulletsStartPosition;

        protected override void Shot()
        {
            foreach (var item in _bulletsStartPosition)
            {
                var bullet = _bulletsPool.GetBullet();
                if (bullet == null)
                {
                    Debug.Log("!");
                }
                else
                {
                    bullet.transform.position = item.position;
                    bullet.transform.Rotate(transform.rotation.eulerAngles);
                    bullet.SetActive(true);
                }
            }

        }
    }
}
