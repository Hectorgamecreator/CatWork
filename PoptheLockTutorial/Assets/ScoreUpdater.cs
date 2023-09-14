using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{

    public int RemainingDots = 10;

    TMPro.TextMeshPro _text;

   public void DecrementDots()
    {
        RemainingDots--;
        if(RemainingDots < 0)
        {
            RemainingDots = 0;
        }
    }

    void Start()
    {
        _text = GetComponent<TMPro.TextMeshPro>();
    }

    void Update()
    {
        _text.text = RemainingDots.ToString();
    }
}
