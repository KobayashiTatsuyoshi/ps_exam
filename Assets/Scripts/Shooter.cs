using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] BallFactory m_ballFactory;
    [SerializeField] GaugeUI m_gauge;
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

    public void SetBall(Ball ball)
    {
        ball.transform.parent = transform;
        ball.transform.localPosition = Vector3.zero;
        m_ball = ball;
    }

    public void Shoot(float power)
    {
        if (m_ball == null) return;

        var force = new Vector2(10f, 14f) * Mathf.Clamp(power, 0.5f, 1.5f);
        m_ball.Release(2, force);
        m_ball = null;
    }
}
