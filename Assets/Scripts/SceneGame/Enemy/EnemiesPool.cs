using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class EnemiesPool : MonoBehaviour
    {
        private readonly Dictionary<string, List<GameObject>> _enemies = new Dictionary<string, List<GameObject>>();

        public void AddEnemies(GameObject enemyPrefab, int count)
        {
            if (_enemies.ContainsKey(enemyPrefab.name) == false)
                _enemies.Add(enemyPrefab.name, new List<GameObject>());

            for (int i = 0; i < count; i++)
            {
                Create(enemyPrefab);
            }
        }

        private GameObject Create(GameObject enemyPrefab)
        {
            var enemy = Instantiate(enemyPrefab, transform);
            enemy.SetActive(false);
            _enemies[enemyPrefab.name].Add(enemy);
            return enemy;
        }

        public GameObject GetEnemy(GameObject enemyPrefab)
        {
            if (_enemies.ContainsKey(enemyPrefab.name))
            {
                for (int i = 0; i < _enemies[enemyPrefab.name].Count; i++)
                {
                    if (!_enemies[enemyPrefab.name][i].activeInHierarchy)
                        return _enemies[enemyPrefab.name][i];
                }
                return Create(enemyPrefab);
            }
            else _enemies.Add(enemyPrefab.name, new List<GameObject>());


            return Create(enemyPrefab);
        }
    }
}
