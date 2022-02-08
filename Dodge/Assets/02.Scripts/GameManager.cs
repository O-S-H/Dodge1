using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameObjectText;
    public Text timetext;// 생존시간을 표시할 텍스트 컴포넌트
    public Text recordText; // 최고 기록을 표시할 컴포넌트


    private float surviveTime;
    private bool isGameover;
    void Start()
    {
        surviveTime = 0;
        isGameover = false;

    }

  
    void Update()
    {
        
    }

    
    
    
}
