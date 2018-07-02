using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour {

    public GameObject[] results;


    public void OnMakeChoice()
    {
        foreach (GameObject result in results)
        {
            if (result)
            {
                if(result.tag == "Email")
                {
                    ChangeSize();
                }
                result.SetActive(true);
                result.transform.SetAsLastSibling();
                if (result.GetComponent<ClickTest>())
                {
                    if (result.GetComponent<ClickTest>().father)
                    {
                        result.GetComponent<ClickTest>().father.transform.SetAsLastSibling();
                    }
                }
            }
        }





    }

    public void ChangeSize()
    {
        GameObject titleObject = GameObject.FindWithTag("Title");
        RectTransform rt = titleObject.GetComponent<RectTransform>();
        float CurrentV = rt.sizeDelta.y;
        CurrentV += 30;
        rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, CurrentV);
        //rectTransform.sizeDelta = new Vector2(yourWidth, yourHeight);
    }
}
