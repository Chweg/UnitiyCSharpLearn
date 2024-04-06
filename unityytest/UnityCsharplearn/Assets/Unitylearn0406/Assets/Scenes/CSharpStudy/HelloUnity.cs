using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    int damage = 100;
    float time = 3.14f;
    string name = "이순신";

    private void Start() //게임 시작 후 한번만 실행.
    {
        Debug.Log("대미지의 값" + damage);
        Debug.Log("시간의 값" + time);
        Debug.Log("이름" + name);


        text.text = string.Format($"Only{damage} English{time} is available: 정말이니?");
        
    }
}