using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowControl : MonoBehaviour {

    public Sprite[] popUpWindows;
    Sprite currentImage;


    private void Start()
    {
        currentImage = popUpWindows[0];
        Debug.Log("level"+DBManager.level);
        this.GetComponentInChildren<Image>().sprite = currentImage;
    }

    public void DisplayWindows(Sprite currentImage)
    {
        this.GetComponentInChildren<Image>().sprite = currentImage;
    }


}
