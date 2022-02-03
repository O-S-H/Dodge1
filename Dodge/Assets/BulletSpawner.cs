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
        target = FindObjectOfType<PlayerController>().transform; // PleyrController 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 지정// 트랜스폼 값을 가져온다?ㄴ
    }

   
    void Update()
    {
        
    }
}
