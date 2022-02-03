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
        timeafterSpawn = 0f; //�ֱٻ������� �����ð��� 0�� �ʱ�ȭ
        spawnRate = Random.Range(spawnRateMin, spawnRateMax); //ź�� ���������� spawnRaterMin �� spawnRateMax ���̿��� ��������
        target = FindObjectOfType<PlayerController>().transform; // PleyrController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����// Ʈ������ ���� �����´�?��
    }

   
    void Update()
    {
        
    }
}
