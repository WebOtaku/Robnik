using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public abstract class PlayerCannonBase : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bulletPrefab;

        [SerializeField, Range(1, 20)]
        private int _bulletCount;

        protected BulletsPool _bulletsPool;

        private WaitForSeconds _wait;

        public void Activate()
        {
            _wait = new WaitForSeconds(.5f);
            StartCoroutine(Timer());
        }

        private void Start() {
            _bulletsPool = FindObjectOfType<BulletsPool>();
            _bulletsPool.AddBullets(_bulletPrefab, _bulletCount);
        }

        private IEnumerator Timer()
        {
            while (true)
            {
                Shot();
                yield return _wait;
            }
        }

        protected abstract void Shot();
    }
}
