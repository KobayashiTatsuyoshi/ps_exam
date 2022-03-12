using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゴール用クラス
/// </summary>
public class Goal : MonoBehaviour
{
    // スコア反映用 UI
    [SerializeField] ScoreUI m_scoreUI;
    
    // 累計スコア
    private int m_score;

    private void Start()
    {
        m_score = 0;
    }

    /// <summary>
    /// 得点を加え、スコアUIに反映する
    /// </summary>
    /// <param name="additive">加える点数</param>
    public void AddScore(int additive)
    {
        m_score += additive;
        m_scoreUI.SetScore(m_score);
    }
}
