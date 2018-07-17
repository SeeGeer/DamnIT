using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{

    private void Start()
    {
        if (DBManager.username == null)
        {
            print("no users");
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            StartCoroutine(SavePlayerData());
        }
        
    }



    IEnumerator SavePlayerData()
    {

        WWWForm form = new WWWForm();
        form.AddField("username", DBManager.username);
        form.AddField("score", DBManager.score);
        form.AddField("day", DBManager.day);

        //WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);
        WWW www = new WWW("sijier.000webhostapp.com/savedata.php", form);
        yield return www;

        if (www.text == "0")
        {
            Debug.Log("Game Saved");
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);
        }


        //UnityEngine.SceneManagement.SceneManager.LoadScene(0);

    }
}

