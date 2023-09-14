
using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int CurrentLevel;
    public int MaxUnlockedLevel;
    public int DotsRemaining;
    public int Stars;

    public void ResetLevel()
    {
        DotsRemaining = CurrentLevel;
    }
}