using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInvoker : MonoBehaviour
{

    public GameEvent OnGameLoadEvent;

    public void RaiseLoadGameEvent()
    {
        OnGameLoadEvent.Raise();
    }
}
