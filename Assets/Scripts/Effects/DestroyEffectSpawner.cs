using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    [RequireComponent(typeof(DestroyEffectGenerator))]
    public class DestroyEffectSpawner : MonoBehaviour
    {
        private DestroyEffectGenerator _generator;

        private void Awake()
        {
            _generator = GetComponent<DestroyEffectGenerator>();
        }

        private void OnDisable()
        {
            DestroyEffect.OnEffectActivated -= DestroyEffect_OnEffectActivate;
        }

        private void OnEnable()
        {
            DestroyEffect.OnEffectActivated += DestroyEffect_OnEffectActivate;
        }

        private void DestroyEffect_OnEffectActivate(Transform obj)
        {
            GameObject effect = _generator.GetFreeEffect();
            effect.transform.position = obj.position;
            effect.SetActive(true);
        }
    }
}
