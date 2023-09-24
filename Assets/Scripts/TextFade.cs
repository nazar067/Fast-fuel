using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    public Text textComponent; // Ссылка на компонент Text вашего текста.
    public Color[] colors; // Массив цветов для переливания.
    public float lerpDuration = 1f; // Длительность перехода между цветами в секундах.

    private int currentColorIndex = 0; // Индекс текущего цвета в массиве.
    private float lerpStartTime; // Время начала перехода.

    private void Start()
    {
        textComponent = GetComponent<Text>(); // Получаем компонент Text, если его нет в инспекторе.
        textComponent.color = colors[currentColorIndex]; // Устанавливаем начальный цвет текста.
        lerpStartTime = Time.time; // Запоминаем время начала перехода.
    }

    private void Update()
    {
        // Рассчитываем прошедшее время с начала перехода.
        float lerpTime = Time.time - lerpStartTime;

        // Рассчитываем прогресс перехода от 0 до 1 в зависимости от времени.
        float lerpProgress = Mathf.Clamp01(lerpTime / lerpDuration);

        // Интерполируем цвет между текущим и следующим цветами.
        Color lerpedColor = Color.Lerp(colors[currentColorIndex], colors[(currentColorIndex + 1) % colors.Length], lerpProgress);

        // Применяем цвет к компоненту Text.
        textComponent.color = lerpedColor;

        // Если достигнут конечный цвет, переключаемся на следующий цвет и сбрасываем время начала перехода.
        if (lerpProgress >= 1f)
        {
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            lerpStartTime = Time.time;
        }
    }
}
