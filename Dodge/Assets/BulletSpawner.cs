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
        target = FindObjectOfType<PlayerController>().transform; // PleyrController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����// Ʈ������ ���� �Ҵ�
    }

   
    void Update()
    {
        timeafterSpawn += Time.deltaTime;  // timeAfterSpawn ����
        if (timeafterSpawn >= spawnRate) // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        {

            timeafterSpawn = 0f; // ������ �ð��� ����


            //bulletPrefab ��������
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            //������ ���� ������ spawnRateMin,spawnRateMax ���̿��� �������� ����
            GameObject bullet 
                = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
