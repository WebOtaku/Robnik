using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class StartEvents : MonoBehaviour
    {
        [SerializeField]
        private GameEvent _startScene;

        [SerializeField]
        private GameEvent _gameplay;
        private void Start()
        {
            _startScene.Init();
            _gameplay.Init();
        }
    }
}
