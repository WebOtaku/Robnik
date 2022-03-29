using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class BorderVerticalPosition : MonoBehaviour
    {
        [SerializeField]
        private Camera _camera;

        [SerializeField]
        private bool _isTop;

        private void Start()
        {
            SetPosition();
        }

        private void SetPosition()
        {
            Vector2 safeAreaPosition = _isTop ? Screen.safeArea.max : Screen.safeArea.min;
            float positionY = _camera.ScreenToWorldPoint(safeAreaPosition).y;
            transform.position = new Vector2(transform.position.x, positionY);
        }
    }
}
