using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameData GameData;
    public GameEvent OnWinEvent;

    // Start is called before the first frame update
    void Start()
    {
        //Reset the Remaining Dots.
        GameData.ResetLevel();
    }

  
    public void DecrementRemainingDots()
    {
        GameData.DotsRemaining--;

        if(GameData.DotsRemaining <= 0)
        {
            GameData.DotsRemaining = 0;
            OnWinEvent.Raise();
        }
    }

}
