using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickTest : MonoBehaviour
{
    public GameObject father;
    public GameObject together;

    public bool self = true;

    public void OnPointerDown()
    {
        if(self != false)
        {
            int index = transform.GetSiblingIndex();
            //transform.SetSiblingIndex(index + 10);
            transform.SetAsLastSibling();
        }


        if (father)
        {
            int fatherIndex = father.transform.GetSiblingIndex();
            father.transform.SetAsLastSibling();
        }

        if (together)
        {
            together.transform.SetAsLastSibling();
        }

    }
}
