using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ ����
    private Rigidbody playerRigidbody;
    //�̵��� ������ �ӷ�
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
        //���� ������Ʈ���� Rigidbody ���۳�Ʈ�� ã�� player Rigidbody�� �Ҵ�.

        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("vertical");

        //���� �̵��ӵ��� �Է°��� �̵��ӷ��� ����� ����
        float xspeed = xInput * speed;
        float zspeed = zInput * speed;


        Vector3 newVelocvity = new Vector3(xspeed, 0f, zspeed);
        //������ٵ��� �ӵ��� newvelocity�� �Ҵ�
        playerRigidbody.velocity = newVelocvity;
    }

    public void Die() 
    {
        gameObject.SetActive(false);
    }
}

