using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
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
        if (!isGameover)
        {


            surviveTime += Time.deltaTime;
            timetext.text = "Time : " + (int)surviveTime;  // timetext. text(오브젝트 내에 있는 필드(변수))  //debug.log 랑 똑같다. ""뒤에는 유니티가 뒷열을 string으로 형변환 해준다.
        }

        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public void Endgame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime)
        {

            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);

        }
        recordText.text = "Best time : " + (int)bestTime;

    }
    
    
    
}
