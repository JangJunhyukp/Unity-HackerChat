using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
{
    public Light pointLight; // Point Light ������Ʈ�� ����ų ����
    public float blinkInterval = 0.5f; // ������ ���� (��)
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
            pointLight.intensity = 0; // ����
            yield return new WaitForSeconds(blinkInterval);
            pointLight.intensity = originalIntensity; // ����
            yield return new WaitForSeconds(blinkInterval);
        }
    }

    public void sc()
    {
        StartCoroutine(BlinkLight());
    }
}
