using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAtLast : MonoBehaviour {

    public GameObject luckyObject;
    public void setAsLastSib()
    {
        luckyObject.transform.SetAsLastSibling();
    }
}
