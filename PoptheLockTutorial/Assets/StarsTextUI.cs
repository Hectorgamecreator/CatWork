using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshProUGUI _text;


    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
        _text.text = "Star: " + GameData.Stars.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Star: " + GameData.Stars.ToString();

    }
}
