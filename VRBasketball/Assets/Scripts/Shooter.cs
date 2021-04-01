using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject ballPrefabs;
    [SerializeField] Transform hands;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Shoot();
    }
    void Shoot()
    {
        Instantiate(ballPrefabs,hands.position, hands.rotation);
    }
}
