using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountToNum : MonoBehaviour {

    public Text CountDisplay;
    public Text ticketDisplay;
    public int TargetNum;
    public GameObject CloseButton;

	// Use this for initialization
	void Start () {
        StartCoroutine(CountToTarget());
        
        
    }

    private void Update()
    {

        CountDisplay.text = "" + DBManager.ticketNum;
        ticketDisplay.text = "" + DBManager.ticketNum;
    }

    IEnumerator CountToTarget()
    {
        
        while (TargetNum > DBManager.ticketNum)
        {
            yield return new WaitForSeconds(0.06f);
            DBManager.ticketNum ++;
        }

        CloseButton.SetActive(true);




    }
}
