using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゴール判定を検知するクラス
/// </summary>
public class GoalTrigger : MonoBehaviour
{
    // ゴールしたことを伝える
    [SerializeField] Goal m_goal;

    // ゴール領域に上から入ったボール
    List<Ball> m_balls = new List<Ball>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball == null) return; //Ballコンポーネントが見つからないなら終了

        // まだリストに登録されてない　かつ　位置が上なら
        if (!m_balls.Contains(ball) && IsOverTrigger(ball.transform))
        {
            // リストに追加
            m_balls.Add(ball);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball == null) return; //Ballコンポーネントが見つからないなら終了

        // リストに登録されている　かつ　位置が下なら
        if (m_balls.Contains(ball) && !IsOverTrigger(ball.transform))
        {
            // リストから外す
            m_balls.Remove(ball);

            // ここまでで　上から入ってきたボールが下に抜けたことになる　→　得点追加
            m_goal.AddScore(ball.Score);
        }
    }

    // このクラスより座標が上かどうか
    private bool IsOverTrigger(Transform other)
    {
        return other.position.y >= transform.position.y;
    }
}
