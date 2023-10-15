using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenURL : MonoBehaviour
{
    public Button urlButton;
    void Start()
    {
        urlButton.onClick.AddListener(Open);
    }

    private void Open()
    {
        Application.OpenURL("https://t.me/gamingcompany2023");
    }
}
