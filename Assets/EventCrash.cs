using System.Collections;
using System.Collections.Generic;
using System;
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
            Debug.Log(randomEmail);
            SentrySdk.ConfigureScope(scope => 
            {
                scope.User = new User { 
                    Email = randomEmail
                };
            });
            eventID = SentrySdk.CaptureException(e);
            // Debug.Log(eventID);
            Debug.LogException(e);
            //Sleep for 4 secs
            Invoke("crashReports", 4);
        }
    }
    
    public void ExceptionToString()
    {
        try
        {
            throw new InvalidOperationException("Exception from A lady beetle 🐞");
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    public void crashReports() { 
        crashReport.SetActive(true);
    }

    private static string RandomString() { 
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[8];
        var random = new System.Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        var finalString = new String(stringChars) + "@yahoo.com";
        return finalString;
    }
}
