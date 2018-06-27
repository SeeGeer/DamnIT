using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager {

    public static string username;
    public static int score;
    public static int teamId;
    public static int day = 0;
    public static int level = 0;

    public static int ticketNum = 0;
    public static int correctTicketNum = 0;
    public static int incorrectTicketNum = 0;

    public static int[] popUpWindowsCount = new int[3] {2,2,2};// one smaller: 2 means 3 windows
    public static int countWindow = 0;


    public static bool LoggedIn { get { return username != null; } }


    public static void LogOut()
    {
        username = null;
    }
}
