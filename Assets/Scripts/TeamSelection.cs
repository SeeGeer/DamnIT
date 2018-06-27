using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TeamSelection : MonoBehaviour {

    public int teamId = 1;

    private void Awake()
    {
        Debug.Log("score = " + DBManager.score);
        if (DBManager.teamId != 0)// already belongs to a team
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu"); // go to the game page directly
        }
    }


    public void CallTeamSelection()
    {
        DBManager.teamId = teamId;
        StartCoroutine(Select(teamId));
    }
    IEnumerator Select(int teamId)
    {
        WWWForm form = new WWWForm();
        form.AddField("teamId", teamId);
        form.AddField("username", DBManager.username);

        WWW www = new WWW("http://localhost/sqlconnect/teamselection.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Team Selected successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        else
        {
            //print(www.text);
            Debug.Log("Team Selected Failed, Error #" + www.text);

        }


    }
}
