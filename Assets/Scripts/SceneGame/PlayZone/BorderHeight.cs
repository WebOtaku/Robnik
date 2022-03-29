using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class BorderHeight : MonoBehaviour
    {
        [SerializeField]
        private Camera _camera;
        private const float FullSize = 2.0f;

        private void Start()
        {
            SetSize();
        }

        private void SetSize()
        {
            float yScale = _camera.ScreenToWorldPoint(Screen.safeArea.max).y * FullSize;
            BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
            boxCollider2D.size = new Vector2(boxCollider2D.size.x, yScale);
        }
    }
}
