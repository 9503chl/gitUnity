using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] float spawnInterval = 3f;

    EnemySpawner[] spawners; //  EnemySpawner의 리스트
    float timer = 0f;

    void Start()
    {
        spawners = GetComponentsInChildren<EnemySpawner>();//자식오브젝트에있는 Enemy리스트 취득
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(spawnInterval < timer) //출현 간격 즉 3초지났을때
        {
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();
            timer = 0f; //초기화
        }
    }
}
