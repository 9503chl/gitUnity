using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject ballPrefabs;
    [SerializeField] Transform hands;
    [SerializeField] float bulletInterval = 0.5f;

    void OnEnable(){
        InvokeRepeating("Shoot", 1.0f, bulletInterval); // Invoke 설정시간마다 호출함.
    }
    void OnDisable()
    {
        CancelInvoke("Shoot"); //호출 취소
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Shoot();
    }
    void Shoot()
    {
        Instantiate(ballPrefabs,hands.position, hands.rotation);
    }
}
