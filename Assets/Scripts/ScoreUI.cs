using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// スコアUI
/// </summary>
public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    Text m_text;

    // テキストにそのまま受け取った値を表示
    public void SetScore(int value)
    {
        m_text.text = value.ToString();
    }
}
