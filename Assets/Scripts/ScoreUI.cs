using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    Text m_text;

    public void SetScore(int value)
    {
        m_text.text = value.ToString();
    }
}
