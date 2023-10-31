using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorIM : MonoBehaviour
{
    public GameObject[] errorim;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    IEnumerator ImageUp()
    {
        int RI = Random.Range(0, 4);
        errorim[RI].SetActive(true);
        yield return new WaitForSeconds(1f);
        errorim[RI].SetActive(false);
    }

    public void SCI()
    {
        StartCoroutine(ImageUp());
    }
}
