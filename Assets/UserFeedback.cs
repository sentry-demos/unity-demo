using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sentry;

public class UserFeedback : MonoBehaviour
{
    // [ SerializeField]
    private string name; 
    // [ SerializeField]
    private string email;
    // [ SerializeField]
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
    //    Debug.Log("here is what happens to enterUserFeedback" + eventID);
    //    Debug.Log("Name: " + name +  "email: " + email + " info: " + info);
        // if(name == "") { 
        eventID = nullException.eventID;
        Debug.Log(eventID);
        // } else { 
        //     Debug.Log("YES!");
        // }
        // var eventID = SentrySdk.CaptureMessage("An event that will receive user feedback.");
        SentrySdk.CaptureUserFeedback(eventID, email, info, name);
    }


}
