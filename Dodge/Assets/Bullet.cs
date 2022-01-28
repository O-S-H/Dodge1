using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private Rigidbody bulletRigidbody;
  
    public float speed = 8f;
   
    void Start()
    {
        //게임 오브젝트에서 리지드바디 컴포넌트를 찾아 블릿리지드바디에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드바디의 속도 = 압쪽방향 *이동속력
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)  // 트리거 충돌시 자동으로 실행되는 메서드
    {
        if (other.tag == "Player") // 충동한 상대방 게임 오브젝트 Player 태그를 가진 경우
        {
            PlayerController playerController = other.GetComponent <PlayerController>(); // 상대방 게임 오브젝트에서  PlayerController 컴포넌트를 가져오기

            if(playerController != null)  // 상대방으로부터 playerController 컴포넌트를 가져오는데 성공했다면
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
