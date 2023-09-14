using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    GameObject _currentDot;
    bool _isRunning = false;

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
        if(Input.GetMouseButtonDown(0))
        {
            if(!_isRunning)
            {
                _isRunning = true;
                return;
            }

            if(_currentDot !=null)
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
