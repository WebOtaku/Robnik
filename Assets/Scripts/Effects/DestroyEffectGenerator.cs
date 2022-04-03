using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class DestroyEffectGenerator : MonoBehaviour
    {
        private const int DefaultCount = 3;

        [SerializeField]
        private ParticleSystem _prefab;

        private List<GameObject> _effects = new List<GameObject>();

        private void Awake()
        {
            for (int i = 0; i < DefaultCount; i++)
            {
                Create();
            }
        }

        private GameObject Create()
        {
            GameObject effect = Instantiate(_prefab.gameObject, transform);
            _effects.Add(effect);
            return effect;
        }

        public GameObject GetFreeEffect()
        {
            foreach (var item in _effects)
            {
                if (item.activeInHierarchy == false)
                {
                    return item;
                }
            }

            return Create();
        }
    }
}
