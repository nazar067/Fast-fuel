using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    public Text textComponent; // ������ �� ��������� Text ������ ������.
    public Color[] colors; // ������ ������ ��� �����������.
    public float lerpDuration = 1f; // ������������ �������� ����� ������� � ��������.

    private int currentColorIndex = 0; // ������ �������� ����� � �������.
    private float lerpStartTime; // ����� ������ ��������.

    private void Start()
    {
        textComponent = GetComponent<Text>(); // �������� ��������� Text, ���� ��� ��� � ����������.
        textComponent.color = colors[currentColorIndex]; // ������������� ��������� ���� ������.
        lerpStartTime = Time.time; // ���������� ����� ������ ��������.
    }

    private void Update()
    {
        // ������������ ��������� ����� � ������ ��������.
        float lerpTime = Time.time - lerpStartTime;

        // ������������ �������� �������� �� 0 �� 1 � ����������� �� �������.
        float lerpProgress = Mathf.Clamp01(lerpTime / lerpDuration);

        // ������������� ���� ����� ������� � ��������� �������.
        Color lerpedColor = Color.Lerp(colors[currentColorIndex], colors[(currentColorIndex + 1) % colors.Length], lerpProgress);

        // ��������� ���� � ���������� Text.
        textComponent.color = lerpedColor;

        // ���� ��������� �������� ����, ������������� �� ��������� ���� � ���������� ����� ������ ��������.
        if (lerpProgress >= 1f)
        {
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            lerpStartTime = Time.time;
        }
    }
}
