using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sentry;

public class UserFeedback : MonoBehaviour
{
    private string name; 
    private string email;
    private string info;

    private Sentry.SentryId eventID;

    public EventCrash nullException; 

    
    public void getName(string s) { 

        name = s; 
    }
    public void getEmail(string s) { 

        email = s; 
    }
    public void getInfo(string s) { 

        info = s; 
    }

    public void enterUserFeedback() { 
        eventID = nullException.eventID;
        SentrySdk.CaptureUserFeedback(eventID, email, info, name);
    }


}
