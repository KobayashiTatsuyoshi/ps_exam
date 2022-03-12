using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボールクラス
/// </summary>
public class Ball : MonoBehaviour
{
    Rigidbody2D m_rb;

    // 領域Y
    const float OUT_OF_BOUNDS_Y = -20f;

    /// <summary>
    /// ゴールに入ったときに入る得点
    /// </summary>
    public int Score { get; private set; }

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();

        // シュートまでは物理が働かないように
        m_rb.simulated = false;
    }

    private void Update()
    {
        // ボールが領域外に出たらインスタンスを消す
        if (IsOutOfBounds())
        {
            Destroy(gameObject);
        }
    }

    // 領域外にいるか判定
    private bool IsOutOfBounds()
    {
        return transform.position.y < OUT_OF_BOUNDS_Y;
    }

    /// <summary>
    /// ボールがシュートされる
    /// </summary>
    /// <param name="score">ボールがゴールした時の加算得点</param>
    /// <param name="force">ボールを打つ力</param>
    public void Release(int score, Vector2 force)
    {
        Score = score;
        m_rb.simulated = true;
        m_rb.AddTorque(force.sqrMagnitude);
        m_rb.AddForce(force, ForceMode2D.Impulse);
    }
}
