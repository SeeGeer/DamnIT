using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {
    public GameObject disappearObject;

    public void DisappearAfterClick()
    {
        disappearObject.SetActive(false);
    }
}
