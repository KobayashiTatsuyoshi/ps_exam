using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    const float OutOfWorldY = -20f;

    Rigidbody2D m_rb;
    public int Score { get; private set; }

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_rb.simulated = false;
    }

    private void Update()
    {
        if (transform.position.y < OutOfWorldY)
        {
            Destroy(gameObject);
        }
    }

    public void Release(int score, Vector2 force)
    {
        Score = score;
        m_rb.simulated = true;
        m_rb.AddTorque(force.sqrMagnitude);
        m_rb.AddForce(force, ForceMode2D.Impulse);
    }
}
