using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class EnemySpawn : MonoBehaviour {
        [SerializeField]
        private GameObject _enemyPrefab;

        [SerializeField, Range(0, 20)]
        private int _enemyCount;

        protected EnemiesPool _enemiesPool;

        private void OnEnable()
        {
            if (_enemiesPool == null)
                _enemiesPool = FindObjectOfType<EnemiesPool>();
            if (_enemyCount > 0)
                _enemiesPool.AddEnemies(_enemyPrefab, _enemyCount);
        }

        public void EnemyActivate()
        {
            float offset = 1.0f;
            Vector2 startPosition = new Vector2(0, new SafeAreaData().GetMax().y + offset);

            var enemy = _enemiesPool.GetEnemy(_enemyPrefab);
            enemy.transform.position = startPosition;
            enemy.SetActive(true);
        }
    }
}
