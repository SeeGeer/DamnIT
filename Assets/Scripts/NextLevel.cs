using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    // Use this for initialization
    public string SceneName;
	void Start () {
        DBManager.day += 1; //day == 1 means I have already gone over day 1


        DBManager.ticketNum = 0;
        DBManager.correctTicketNum = 0;
        DBManager.incorrectTicketNum = 0;

        

        StartCoroutine(SwitchLevel());
	}
	
    IEnumerator SwitchLevel()
    {
        yield return new WaitForSeconds(3.0f);
        StartCoroutine(SavePlayerData());
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
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
