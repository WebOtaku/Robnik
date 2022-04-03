using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class ObjectScore : MonoBehaviour
    {
        public static event Action<int> OnChanged;

        [SerializeField, Range(10, 1000)]
        private int _score = 10;

        public void Activate()
        {
            OnChanged?.Invoke(_score);
        }
    }
}
