using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class EnemyWaves : MonoBehaviour
    {
        private LevelData _level;
        private int _indexWave;
        private int _indexEnemy;
        private List<GameObject> _enemies = new List<GameObject>();

        private void Awake()
        {
            //int index = new LevelNameData().GetLevelIndex(); // если будут реализованы уровни
            int index = 1;
            _level = Resources.Load<LevelData>($"Levels/Level{index}");
        }

        public void Generate()
        {
            float offset = 1.0f;
            Vector2 startPosition = new Vector2(0, new SafeAreaData().GetMax().y + offset);

            foreach (var wave in _level.Waves)
            {
                for (int i = 0; i < wave.CountInWave; i++)
                {
                    var enemy = Instantiate(wave.EnemyPrefab, transform);
                    enemy.transform.position = startPosition;
                    enemy.SetActive(false);
                    _enemies.Add(enemy);
                }
            }
        }

        public void Activate()
        {
            StartCoroutine(EnemyActivate());
        }

        private IEnumerator EnemyActivate()
        {
            WaitForSeconds wait = new WaitForSeconds(0.5f);
            var count = _level.Waves[_indexWave].CountInWave;

            while (count > 0)
            {
                count--;
                _enemies[_indexEnemy].gameObject.SetActive(true);
                _indexEnemy++;
                yield return wait;
            }

            if (_indexWave < _level.Waves.Count - 1)
            {
                Invoke(nameof(Activate), _level.Waves[_indexWave].WaitAfterWave);
                _indexWave++;
            }
        }
    }
}
