using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailMessages : MonoBehaviour {

    public Text welcomeText;
    private void Start()
    {
        if (DBManager.day != 0)
        {
            welcomeText.text = 
                "Welcome back! Time to get coffee and sit down to work. " +
                "\nThere’s only " + (5 - DBManager.day) + " more days until your employee " +
                "\nreview …";
        }
        else
        {
            welcomeText.text =
                "Welcome to Zoftup Technologies! You have 5 days to prove that " +
                "\nyou belong on our I.T. team. Our company’s founder, Zena Zoftup, " +
                "\nwill show you your duties in the employee orientation. Learn the " +
                "\nrules and put them into practice. If you do that, you should be able " +
                "\nto pass your employee review at the end of 5 days and be promoted! " +
                "\nIf you do not pass the review, we will terminate your employment.";
        }
    }



}
