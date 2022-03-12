using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactory : MonoBehaviour
{
    [SerializeField] Ball m_ballPrefab;
    Shooter m_requster;

    public void RequestBall(Shooter requster)
    {
        m_requster = requster;
    }

    void Update()
    {
        if (m_requster != null)
        {
            Ball ball = Instantiate(m_ballPrefab);
            m_requster.SetBall(ball);
            m_requster = null;
        }
    }
}
