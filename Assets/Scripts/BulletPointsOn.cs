using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletPointsOn : MonoBehaviour {

    public GameObject notePadText;
    public GameObject bulletPointsText;
    public GameObject NotePad;
    public void ShowBulletPoints()
    {
        notePadText.SetActive(false);
        bulletPointsText.SetActive(true);
        NotePad.transform.SetAsLastSibling();
    }
}
