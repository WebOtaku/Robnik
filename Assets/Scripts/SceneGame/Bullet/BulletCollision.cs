using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    [RequireComponent(typeof(CapsuleCollider2D))]
    public class BulletCollision : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // TODO: damage enemy
            if (collision.gameObject.name != "Player")
                ResetObject();
        }

        private void ResetObject()
        {
            transform.rotation = Quaternion.identity;
            gameObject.SetActive(false);
        }
    }
}
