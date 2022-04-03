using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Robnik
{
    public class UIScore : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _text;

        public void ShowValue(int value)
        {
            _text.text = value.ToString();
        }
    }
}
