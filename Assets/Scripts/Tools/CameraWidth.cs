using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Robnik.Tools
{
    [RequireComponent(typeof(Camera))]
    public class CameraWidth : MonoBehaviour
    {
        private const float Width = 1080.0f;
        private const float HalfSizeInPixels = 200.0f;

        private void Awake()
        {
            GetComponent<Camera>().orthographicSize = Width * Screen.height / Screen.width / HalfSizeInPixels;
        }
    }
}
