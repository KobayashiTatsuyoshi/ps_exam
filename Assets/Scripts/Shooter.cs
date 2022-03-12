using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シュートする人クラス
/// </summary>
public class Shooter : MonoBehaviour
{
    const int ADD_SCORE = 2;

    [SerializeField] BallFactory m_ballFactory;
    [SerializeField] GaugeUI m_gauge;
    [SerializeField] Vector2 m_justForce;
    Ball m_ball;
    float m_shootPower;

    void Update()
    {
        if (m_ball == null) m_ballFactory.RequestBall(this);

        if (Input.GetKey(KeyCode.Space))
        {
            //スペースキーを押している間
            m_shootPower += 1f * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            //スペースキーを離したフレーム
            Shoot(m_shootPower);
            m_shootPower = 0f;
        }
        m_gauge.SetValue(m_shootPower);
    }

    /// <summary>
    /// 次にシュートする用のボールをセットする
    /// </summary>
    /// <param name="ball"></param>
    public void SetBall(Ball ball)
    {
        ball.transform.parent = transform;
        ball.transform.localPosition = Vector3.zero;
        m_ball = ball;
    }

    /// <summary>
    /// ボールをシュートする
    /// </summary>
    /// <param name="power">シュートするときの力倍率</param>
    public void Shoot(float power)
    {
        if (m_ball == null) return;

        var force = m_justForce * Mathf.Clamp(power, 0.5f, 1.5f);
        m_ball.Release(ADD_SCORE, force);
        m_ball = null;
    }
}
