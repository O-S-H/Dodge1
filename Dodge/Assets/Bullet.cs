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


    // Update is called once per frame
    void Update()
    
    {
        
    }
}
