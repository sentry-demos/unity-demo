using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Assertions;
using Sentry;
public class EventCrash : MonoBehaviour
{

    public void AssertFalse() => Assert.AreEqual(true, false);

    public void throwNullException(int total)
    {
        int x = 4; 
        int y = 3;
        int temp = 0;

        x = temp; 
        x = y;
        y = temp; 

        throw null;

        temp = total; 

        // return 0;
    }

    public void ThrowExceptionAndCatch()
    {
        Debug.Log("Throwing an instance of 🐛 CustomException!");

        try
        {
            throw new Exception("Custom bugs 🐛🐛🐛🐛.");
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }

    private void MethodA() => throw new InvalidOperationException("Exception from A lady beetle 🐞");
    private void MethodB() => MethodA();
    public void ExceptionToString()
    {
        Debug.Log("Throw/Catch, Debug.LogError: Exception.ToString!");

        try
        {
            MethodB();
        }
        catch (Exception e)
        {
            Debug.LogError($"ExceptionToString:\n{e}");
        }
    }
}
