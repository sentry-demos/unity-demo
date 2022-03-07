using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions;
using Sentry;

public class EventCrash : MonoBehaviour
{

    public GameObject crashReport; 
    public Sentry.SentryId eventID;


    //play button error
    public void ThrowExceptionAndCatch()
    {
        Debug.Log("Throwing an instance of 🐛 CustomException!");

        try
        {
            throw new Exception("Custom bugs 🐛🐛🐛🐛.");
        }
        catch (Exception e)
        {
            string randomEmail = RandomString();
            
            SentrySdk.ConfigureScope(scope => 
            {
                scope.User = new User { 
                    Email = randomEmail
                };
            });
            eventID = SentrySdk.CaptureException(e);
            Debug.LogError(e);
            //Sleep for 3 secs
            Invoke("crashReports", 3);
        }
    }
    
    public void throwNull()
    {
        ScreenCapture.CaptureScreenshot(@"/Users/dannychakra/sc.png");
        SentrySdk.ConfigureScope(scope => { 
            
            scope.AddAttachment(@"/Users/dannychakra/sc.png");
        });
        Debug.Log("Adding attachment to Sentry");
        Debug.Log("Calling throwNull() function");
        throw null;
    }

    public void crashReports() { 
        crashReport.SetActive(true);
    }

    private static string RandomString() { 
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[8];
        var random = new System.Random();

        for (int i = 0; i < stringChars.Length; i++){
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        var finalString = new String(stringChars) + "@yahoo.com";
        Debug.LogWarning("Setting User: " + finalString);
        return finalString;
    }
}
