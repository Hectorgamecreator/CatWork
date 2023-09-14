using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public int Speed = 5;
    public Direction _direction = Direction.Clockwise;
    Vector3 _initialPos; 

    Transform _anchor;
    bool _isRunning = false;

    void Start ()
    {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        _initialPos = GetComponent<Transform>().localPosition;

    }

    void Update()
    {
        //Do this only if motor already started
        if (_isRunning)
        {
            transform.RotateAround(_anchor.position, Vector3.forward, Speed * Time.deltaTime * -(int)_direction);
        }


        if(_didTap)
        {
            if (!_isRunning)
            {
                _isRunning = true;
                return;
            }
            ChangeDirection();
        }
    }

    bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }

void ChangeDirection()
    {
        switch(_direction)
        {
            case Direction.Clockwise:
                _direction = Direction.AntiClockwise;
                break;
                case Direction.AntiClockwise:
                _direction = Direction.Clockwise;
                break;
        }
    }

    public void ResetPosition()
    {
        transform.localPosition = new Vector3(0, _initialPos.y, 0);
        transform.localRotation = Quaternion.identity;
       
    }

    public void Stop()
    {
        _isRunning = false;
    }
}



public enum Direction
{
    Clockwise = 1,
    AntiClockwise = -1
}