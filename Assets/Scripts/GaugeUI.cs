using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲージのUI
/// </summary>
public class GaugeUI : MonoBehaviour
{
    // ゲージの量用Image
    [SerializeField] Image m_value;

    /// <summary>
    /// value に応じてスケールXを変更する
    /// </summary>
    /// <param name="value"></param>
    public void SetValue(float value)
    {
        m_value.rectTransform.localScale = new Vector3(value, m_value.rectTransform.localScale.y, m_value.rectTransform.localScale.z);
    }
}
