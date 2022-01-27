using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private Rigidbody bulletRigidbody;
  
    public float speed = 8f;
   
    void Start()
    {
        //���� ������Ʈ���� ������ٵ� ������Ʈ�� ã�� ��������ٵ� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���ʹ��� *�̵��ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }


    // Update is called once per frame
    void Update()
    
    {
        
    }
}
