using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObjectRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // �������� �������� �������

    void OnGUI()
    {
        // ������� �������������� ������� � ���������������� ���������� Unity
        rotationSpeed = GUI.HorizontalSlider(new Rect(10, 10, 100, 20), rotationSpeed, 0f, 100f);
    }

    void Update()
    {
        // ��������� �������� � �������
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}


