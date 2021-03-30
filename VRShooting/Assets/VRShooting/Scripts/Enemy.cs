using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //nodejs에서본 친구 audioSource에서 가져오자.
public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip; //출현 오디오
    [SerializeField] AudioClip hitClip; //총알 명중오디오

    [SerializeField] Collider enemyCollider;
    [SerializeField] Renderer enemyRenderer; //렌더는 표시하는거래네요

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //컴포넌트 취득
        audioSource.PlayOneShot(spawnClip); //출현소리재생
    }
    void OnHitBullet()
    {
        audioSource.PlayOneShot(hitClip); //총알명중시 소리재생
        GoDown();
     }
    void GoDown()
    {
        enemyCollider.enabled = false;
        enemyRenderer.enabled = false; // 충돌,표시판정 지움

        Destroy(gameObject, 1f); //1초뒤 제거
    }
}