using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObjectRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Скорость вращения объекта

    void OnGUI()
    {
        // Создаем горизонтальный слайдер в пользовательском интерфейсе Unity
        rotationSpeed = GUI.HorizontalSlider(new Rect(10, 10, 100, 20), rotationSpeed, 0f, 100f);
    }

    void Update()
    {
        // Применяем вращение к объекту
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}


