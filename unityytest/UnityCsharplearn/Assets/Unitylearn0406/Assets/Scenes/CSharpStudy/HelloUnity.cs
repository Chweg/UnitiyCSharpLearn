using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    int damage = 100;
    float time = 3.14f;
    string name = "�̼���";

    private void Start() //���� ���� �� �ѹ��� ����.
    {
        Debug.Log("������� ��" + damage);
        Debug.Log("�ð��� ��" + time);
        Debug.Log("�̸�" + name);


        text.text = string.Format($"Only{damage} English{time} is available: �����̴�?");
        
    }
}