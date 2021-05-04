using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 버튼을 누르면 미사일이 나가도록하자
/// 필요속성 : 미사일프리팹(공장), 미사일이 나갈 위치
/// 1. 버튼을 누르면
/// 2. 미사일 프리팹을 만든다
/// 3. 미사일이 발사한다
/// </summary>

public class PlayerFIre : MonoBehaviour
{

    // 미사일을 생성할 프리팹
    public GameObject missilePrefabs;

    // 미사일이 나갈 위치
    public GameObject missilePos;

    public GameObject pung;

    [SerializeField]
    AudioClip bbangyaSound;

    AudioSource bbangya;

    [SerializeField]
    AudioClip dieSoundClip;
    AudioSource dieSound;


    void Start()
    {
        bbangya = GetComponent<AudioSource>();
        dieSound = GetComponent<AudioSource>();

    }


    void Update()
    {
        // 1. (Fire1)버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 미사일 프리팹을 만든다
            GameObject missile = Instantiate(missilePrefabs);

            // 3. 미사일이 발사한다
            bbangya.PlayOneShot(bbangyaSound);
            missile.transform.position = missilePos.transform.position;
        }

    }
}
