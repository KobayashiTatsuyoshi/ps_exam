using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeUI : MonoBehaviour
{
    [SerializeField] Image m_bg;
    [SerializeField] Image m_value;

    public void SetValue(float value)
    {
        m_value.rectTransform.localScale = new Vector3(value, m_value.rectTransform.localScale.y, m_value.rectTransform.localScale.z);
    }
}
