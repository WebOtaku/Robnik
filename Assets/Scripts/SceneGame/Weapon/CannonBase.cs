using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public abstract class CannonBase : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bulletPrefab;

        [SerializeField, Range(0, 20)]
        private int _bulletCount;

        protected BulletsPool _bulletsPool;

        private void OnEnable() {
            if (_bulletsPool == null)
                _bulletsPool = FindObjectOfType<BulletsPool>();
            if (_bulletCount > 0)
                _bulletsPool.AddBullets(_bulletPrefab, _bulletCount);
        }

        protected void BulletActivate(Transform bulletStartPosition)
        {
            var bullet = _bulletsPool.GetBullet(_bulletPrefab);
            bullet.transform.position = bulletStartPosition.position;
            bullet.transform.Rotate(transform.rotation.eulerAngles);
            bullet.SetActive(true);
        }

        public abstract void Shot();
    }
}
