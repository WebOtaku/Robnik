using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik
{
    public class EnemyDesctruction : MonoBehaviour
    {
        public void Activate()
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
