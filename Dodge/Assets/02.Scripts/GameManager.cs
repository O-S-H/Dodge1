using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timetext;// �����ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� ������Ʈ


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
            timetext.text = "Time : " + (int)surviveTime;  // timetext. text(������Ʈ ���� �ִ� �ʵ�(����))  //debug.log �� �Ȱ���. ""�ڿ��� ����Ƽ�� �޿��� string���� ����ȯ ���ش�.
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
