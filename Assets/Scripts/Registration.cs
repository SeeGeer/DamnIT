using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

	public void CallRegister()
    {
        StartCoroutine(Register());
    }
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://localhost/sqlconnect/register.php", form);
        yield return www;
        if(www.text == "0")
        {
            Debug.Log("User Created Successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            //print(www.text);
            Debug.Log("User Creation Failed, Error #" + www.text);

        }

 
    }

    public void VarifyInputs()
    {
        //submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
        submitButton.interactable = (nameField.text.Length >= 1 && passwordField.text.Length >= 1);

    }

    public void GoBackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
