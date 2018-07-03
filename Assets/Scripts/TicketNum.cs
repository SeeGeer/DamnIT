using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicketNum : MonoBehaviour {

    public Text ticketDisplay;
    public void AddTicketNum()
    {
        DBManager.ticketNum += 1;
        ticketDisplay.text = "" + DBManager.ticketNum;
    }


}
