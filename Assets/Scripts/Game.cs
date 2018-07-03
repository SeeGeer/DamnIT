using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public Text playerDisplay;

    int ticketNum;
    WindowControl windowControl;

    private void Awake() //display information
    {


        if (DBManager.username == null)
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        playerDisplay.text = DBManager.username;



    }

    public void CallSaveData() // save data when exit or enter the next level
    {
        StartCoroutine(SavePlayerData());
        //DBManager.LogOut();
        //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    IEnumerator SavePlayerData()
    {

        WWWForm form = new WWWForm();
        form.AddField("username", DBManager.username);
        form.AddField("score", DBManager.score);
        form.AddField("day", DBManager.day);
        

        WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);

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

