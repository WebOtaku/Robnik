using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class EnemyDestruction : MonoBehaviour
    {
        public void Activate()
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
