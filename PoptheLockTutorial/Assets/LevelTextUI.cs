using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTextUI : MonoBehaviour
{

    public GameData GameData;
    TMPro.TextMeshProUGUI _text;


    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Level: " + GameData.CurrentLevel.ToString();

    }
}
