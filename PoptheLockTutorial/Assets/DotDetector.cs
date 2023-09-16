using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    GameObject _currentDot;
    public GameData GameData;
    public GameEvent OnDotMissed;
    public GameEvent OnDotScored;


    void OnTriggerEnter2D(Collider2D other)
    {
        _currentDot = other.gameObject;
    }

    void  OnTriggerExit2D(Collider2D other)
    {
        _currentDot = null;
    }

void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!GameData.IsRunning && GameData.IsRunning)
            {

                if (_currentDot != null)
                {
                    Destroy(_currentDot);
                    OnDotScored.Raise();
                }
                else
                {
                    OnDotMissed.Raise();
                }
            }
        }
    }
}
