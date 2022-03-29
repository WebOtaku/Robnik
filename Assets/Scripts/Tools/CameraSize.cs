using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik.Tools
{
    public class CameraSize : MonoBehaviour
    {
        private const float SizeX = 1920.0f;
        private const float SizeY = 1080.0f;
        private float _targetSizeX = 0f;
        private float _targetSizeY = 0f;
        private const float HalfSize = 200.0f; // половина высоты в пикселях
        [SerializeField] private bool _isHorizontal = true;

        private void Awake() {
            _targetSizeX = _isHorizontal ? SizeX : SizeY;
            _targetSizeY = _isHorizontal ? SizeY : SizeX;
            CameraResize();
        }

        private void CameraResize()
        {
            float screenRatio = (float)Screen.width / (float)Screen.height;
            float targetRatio = _targetSizeX / _targetSizeY;
            Debug.Log(screenRatio);
            Debug.Log(targetRatio);

            if (screenRatio >= targetRatio)
            {
                Resize();
            }
            else
            {
                float differentSize = targetRatio / screenRatio;
                Debug.Log(differentSize);
                Resize(differentSize);
            }
        }

        private void Resize(float differentSize = 1.0f)
        {
            Camera.main.orthographicSize = _targetSizeY / HalfSize * differentSize;
        }
    }

}
