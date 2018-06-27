using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicketNum : MonoBehaviour {

    public Text ticketDisplay;
    public void AddTicketNum()
    {
        DBManager.ticketNum += 1;
        ticketDisplay.text = "Finished Ticket: " + DBManager.ticketNum;
    }

    public void AddCorrectNum()
    {
        DBManager.correctTicketNum += 1;
    }

    public void AddInCorrectNum()
    {
        DBManager.incorrectTicketNum += 1;
    }
}
