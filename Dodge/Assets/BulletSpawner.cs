using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawnRate;
    private float timeafterSpawn;
    
    void Start()
    {
        timeafterSpawn = 0f; //최근생성이후 누적시간을 0을 초기화
        spawnRate = Random.Range(spawnRateMin, spawnRateMax); //탄알 생성간격을 spawnRaterMin 과 spawnRateMax 사이에서 랜덤지정
        target = FindObjectOfType<PlayerController>().transform; // PleyrController 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 지정// 트랜스폼 값을 할당
    }

   
    void Update()
    {
        timeafterSpawn += Time.deltaTime;  // timeAfterSpawn 갱신
        if (timeafterSpawn >= spawnRate) // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        {

            timeafterSpawn = 0f; // 누적된 시간을 리셋


            //bulletPrefab 복제본을
            //transform.position 위치와 transform.rotation 회전으로 생성
            //다음번 생성 간격을 spawnRateMin,spawnRateMax 사이에서 랜덤으로 지정
            GameObject bullet 
                = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
