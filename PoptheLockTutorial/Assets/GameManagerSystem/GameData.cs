
using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int CurrentLevel;
    public int MaxUnlockedLevel;
    public int DotsRemaining;
    public int Stars;
    public bool IsRunning = false;

    public void ResetLevel()
    {
        IsRunning = false;
        DotsRemaining = CurrentLevel;
    }
}