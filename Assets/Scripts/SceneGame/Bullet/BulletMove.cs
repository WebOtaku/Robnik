using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class BulletMove : MonoBehaviour
    {
        [SerializeField, Range(10, 25)]
        private float _speed = 25f;

        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        private void FixedUpdate()
        {
            _rigidbody2D.velocity = transform.up * _speed;
        }
    }
}
