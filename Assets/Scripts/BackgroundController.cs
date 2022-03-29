using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class BackgroundController : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _sprite;
        private float _speed = 2.0f;
        private float _positionMinY;
        private Vector2 _restartPosition;

        private void Awake() {
            _restartPosition = transform.position = new Vector2(transform.position.x, new SafeAreaData().GetMin().y);
            _positionMinY = _sprite.bounds.size.y * 2 - _restartPosition.y; // 2 высоты спрайта
        }

        void Update()
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
            if(transform.position.y <= -_positionMinY)
            {
                    transform.position = _restartPosition;
            }
        }
    }
}
