using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트 변수
    private Rigidbody playerRigidbody;
    //이동에 적용할 속력
    public float speed = 8f;


   
    void Start()
    {
        
    }

    private void Update()
    {
        //if(Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //} 

        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
        playerRigidbody = GetComponent<Rigidbody>();
        //게임 오브젝트에서 Rigidbody 컴퍼넌트를 찾아 player Rigidbody에 할당.

        //수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("vertical");

        //실제 이동속도를 입력갑솨 이동속력을 사용해 결정
        float xspeed = xInput * speed;
        float zspeed = zInput * speed;


        Vector3 newVelocvity = new Vector3(xspeed, 0f, zspeed);
        //리지드바디의 속도에 newvelocity에 할당
        playerRigidbody.velocity = newVelocvity;
    }

    public void Die() 
    {
        gameObject.SetActive(false);
    }
}

