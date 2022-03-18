using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample05 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(6 * 60 + 20); // 1の答え

        Debug.Log(600 * 380); // 2の答え
        //Debug.Log(600 * (6 * 60 + 20)); //こちらでもよい

        Debug.Log(228000 / 500); // 3の答え

        Debug.Log(456 / 60); // 4の分の答え

        Debug.Log(456 % 60); // 4の秒の答え
    }
}
