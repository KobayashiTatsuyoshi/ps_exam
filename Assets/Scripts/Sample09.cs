using UnityEngine;

public class Sample09 : MonoBehaviour
{
    void Start()
    {
        int x = 0;
        while (x < 10)
        {
            Debug.Log("x は " + x);
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("i は " + i);
        }
    }
}