using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Robnik
{
    public class EnemySpawnTimer : MonoBehaviour
    {
        [SerializeField, Range(1f, 100f)]
        private float _spawnInterval = 10f;

        [SerializeField]
        private UnityEvent OnSpawn;

        private WaitForSeconds _wait;

        private IEnumerator Timer()
        {
            while (true)
            {
                OnSpawn.Invoke();
                yield return _wait;
            }
        }

        public void StartTimer()
        {
            _wait = new WaitForSeconds(_spawnInterval);
            StartCoroutine(Timer());
        }
    }
}
