using UnityEngine;

public class Sample07 : MonoBehaviour
{
    void Start()
    {
        int inputSeconds = 6 * 60 + 20; //1 の答え

        int jule = 600 * inputSeconds; //2の答え

        int time = jule / 500;

        int minutes = time / 60;
        int seconds = time % 60;
    }
}
