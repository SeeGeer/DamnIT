using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        //WWW www = new WWW("http://localhost/sqlconnect/login.php", form);
        WWW www = new WWW("sijier.000webhostapp.com/login.php", form);
        
        yield return www;

        if(www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.score = int.Parse(www.text.Split('\t')[1]);
            DBManager.teamId = int.Parse(www.text.Split('\t')[2]);
            DBManager.day = int.Parse(www.text.Split('\t')[3]);
            print("day: " + DBManager.day);

            if(DBManager.day == 0)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
            if (DBManager.day == 1)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Level 2");
            }
            if (DBManager.day == 2)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Level 3");
            }




        }
        else
        {
            Debug.Log("user login failed. Error #" + www.text);
        }
    }


    public void VarifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 1 && passwordField.text.Length >= 1);
        //submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);

    }

    public void GoToRegister()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}
