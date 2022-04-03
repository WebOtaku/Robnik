using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Robnik
{
    public class ScoreCollector : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent<int> ScoreChanged;

        private static int _scoreCollected;

        private void OnDisable()
        {
            ObjectScore.OnChanged -= ObjectScore_OnChanged;
        }

        private void OnEnable()
        {
            ObjectScore.OnChanged += ObjectScore_OnChanged;
        }

        private void ObjectScore_OnChanged(int value)
        {
            _scoreCollected += value;
            ScoreChanged.Invoke(_scoreCollected);
        }

        private void Awake()
        {
            ScoreChanged.Invoke(_scoreCollected);
        }
    }
}
