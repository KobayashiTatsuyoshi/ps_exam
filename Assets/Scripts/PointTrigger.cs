using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    [SerializeField] Goal m_goal;

    List<Ball> m_balls = new List<Ball>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null && ball.transform.position.y >= transform.position.y && !m_balls.Contains(ball))
        {
            m_balls.Add(ball);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null && ball.transform.position.y <= transform.position.y && m_balls.Contains(ball))
        {
            m_balls.Remove(ball);
            m_goal.AddScore(ball.Score);
        }
    }
}
