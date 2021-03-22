using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampBlink : MonoBehaviour
{
    public Light light;
    public float blinkFrequency = 3f;
    void Start()
    {
        StartCoroutine(Blink());
    }


    IEnumerator Blink()
    {
        while (true)
        {
            light.intensity = 0.1f;

            yield return new WaitForSeconds(0.1f);
            light.intensity = 3.47f;
            yield return new WaitForSeconds((Random.Range(0f, blinkFrequency)));
        }
        
    }
}

