using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoControl : MonoBehaviour {

    public GameObject logo;
    public int disappearTime;

    private void Start()
    {
        StartCoroutine(LogoDisappear());
    }
    IEnumerator LogoDisappear()
    {
        yield return new WaitForSeconds(disappearTime);
        logo.SetActive(false);
    }
}
