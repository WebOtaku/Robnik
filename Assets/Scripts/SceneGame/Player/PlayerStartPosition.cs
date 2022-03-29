using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class PlayerStartPosition : MonoBehaviour
    {
        private const float Offset = 3.0f;

        private void Start()
        {
            SetPosition();
        }

        private void SetPosition()
        {
            var positionY = new SafeAreaData().GetMin().y + Offset;
            transform.position = new Vector2(transform.position.x, positionY);
        }
    }
}
