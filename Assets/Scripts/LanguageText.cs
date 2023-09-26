using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageText : MonoBehaviour
{
    public int language;
    public string[] text;
    private Text textLine;

    private void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
        textLine = GetComponent<Text>();
        if (textLine)
        {
            textLine.text = "" + text[language];
        }
        
    }
}
