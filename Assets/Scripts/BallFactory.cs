using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボールを生成するクラス
/// </summary>
public class BallFactory : MonoBehaviour
{
    // ボールのプレハブ
    [SerializeField] Ball m_ballPrefab;
    
    // リクエストした人をキャッシュする
    Shooter m_requster;

    public void RequestBall(Shooter requster)
    {
        // ボールを受け取りたい人をキャッシュしておく
        m_requster = requster;
    }

    void Update()
    {
        if (IsBallSuppliable(m_requster))
        {
            // ボールを生成しキャッシュから外す
            Ball ball = Instantiate(m_ballPrefab);
            m_requster.SetBall(ball);
            m_requster = null;
        }
    }

    // ボールを渡していいかチェックする　いったんnullじゃなければ即渡し
    private bool IsBallSuppliable(Shooter shooter)
    {
        return shooter != null;
    }
}
