using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Assertions;
using Sentry;
public class EventCrash : MonoBehaviour
{

    public void AssertFalse() => Assert.AreEqual(true, false);

    public void throwNullException()
    {
        throw null;
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
