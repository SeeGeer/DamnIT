using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Button registerButton;
    public Button loginButton;
    public Button playButton;
    public Text playerDisplay;

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player： " + DBManager.username;
        }
        registerButton.interactable = !DBManager.LoggedIn;
        loginButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;
    }

    public void GoToRegister()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToLogIn()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToGame()
    {
        //check whether the user has a team
        /*if(DBManager.teamId == 0)
        {
            SceneManager.LoadScene("TeamSelection");//team selection scene
        }
        else
        {
            SceneManager.LoadScene("Level");
        }*/
        SceneManager.LoadScene("Level");

    }
}
