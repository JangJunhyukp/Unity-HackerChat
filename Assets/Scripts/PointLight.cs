using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
{
    public Light pointLight; // Point Light ÄÄÆ÷³ÍÆ®¸¦ °¡¸®Å³ º¯¼ö
    public float blinkInterval = 0.5f; // ±ô¹ÚÀÓ °£°Ý (ÃÊ)
    private float originalIntensity;
    // Start is called b
    // efore the first frame update
    void Start()
    {
        originalIntensity = pointLight.intensity;
    }

    IEnumerator BlinkLight()
    {
        while (true)
        {
            pointLight.intensity = 0; // ²¨Áü
            yield return new WaitForSeconds(blinkInterval);
            pointLight.intensity = originalIntensity; // ÄÑÁü
            yield return new WaitForSeconds(blinkInterval);
        }
    }

    public void sc()
    {
        StartCoroutine(BlinkLight());
    }
}
