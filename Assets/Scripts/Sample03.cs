using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample03 : MonoBehaviour
{
    void Start()
    {
        // 足し算
        Debug.Log(1 + 1);
        // 少数バージョン
        Debug.Log(0.1f + 0.2f);

        // 引き算
        //Debug.Log(1 - 4);

        // 掛け算
        //Debug.Log(6 * 11);

        // 割り算
        //Debug.Log(4 / 3);

        // 割り算 少数バージョン
        //Debug.Log(4f / 3f);

        // 剰余
        //Debug.Log(4 % 3);

        // 先に計算をする ()
        //Debug.Log(2 + 1 * 3);
        //Debug.Log((2 + 1) * 3);

        // 左と右が等しいか
        //Debug.Log(2 == 2);
        //Debug.Log(2 == 1);
        //Debug.Log("abc" == "abc");

        // 左と右が異なるか
        //Debug.Log(2 != 1);

        // 左より右が大きいか
        //Debug.Log(2 > 1);
        // その逆
        //Debug.Log(2 < 1);

        // 左以上か
        //Debug.Log(2 >= 1);
        // その逆
        //Debug.Log(2 <= 1);
    }
}
