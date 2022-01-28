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
    private void OnTriggerEnter(Collider other)  // Ʈ���� �浹�� �ڵ����� ����Ǵ� �޼���
    {
        if (other.tag == "Player") // �浿�� ���� ���� ������Ʈ Player �±׸� ���� ���
        {
            PlayerController playerController = other.GetComponent <PlayerController>(); // ���� ���� ������Ʈ����  PlayerController ������Ʈ�� ��������

            if(playerController != null)  // �������κ��� playerController ������Ʈ�� �������µ� �����ߴٸ�
            {
                playerController.Die();

            }

        }

    }
   
    // Update is called once per frame
    void Update()
    
    {
        
    }
}
