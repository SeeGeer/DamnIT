﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyResult : MonoBehaviour {

    public Text resultDisplay;
    public int day;

    private void Start()
    {
        ShowResult();
    }

    public void ShowResult()
    {
        DBManager.score += 5 * DBManager.correctTicketNum - DBManager.incorrectTicketNum;
        resultDisplay.text = "Here is your day " + day + " result \n \n" +
            "- Your rating is XXX \n" +
            "- You are ranking #3 in your group \n \n \n" +
            "Leaderboard:\n" +
            " - Lola Loggins \n" +
            " - Ali Algo-Rithim \n" +
            " - " + DBManager.username + "\n" +
            " - Priya Privathy \n" +
            " - Audra Auther \n" +
            " - Sammy Sakuritiea \n \n" +

            "- Have a good night!";
    }
}
