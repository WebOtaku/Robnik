using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class DestroyEffect : MonoBehaviour
    {
        public static event Action<Transform> OnEffectActivated;

        public void Activate()
        {
            OnEffectActivated?.Invoke(transform);
        }
    }
}
