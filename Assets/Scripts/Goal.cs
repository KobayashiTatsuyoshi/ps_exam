using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    ScoreUI m_scoreUI;
    private int m_score;

    private void Start()
    {
        m_score = 0;
    }

    public void AddScore(int additive)
    {
        m_score += additive;
        m_scoreUI.SetScore(m_score);
    }
}
