using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy가 아래로 이동한다
/// 필요속성 : 이동속도
/// 1. 미사일 방향 구하기
/// 2. 이동하기
/// 3. 충돌하게 되면 둘다 Destory하자
/// </summary>

/// <summary>
/// 30%로 확률로 Player쪽으로 나머지는 아래 방향으로 이동하게 하자
/// 1. Random함수를 사용하여 
/// 2. 30%는 player쪽으로 이동
///    a. 플레이어를 찾기
///    b. 방향구하기
/// 3. 나머지는 아래로
/// </summary>

public class EnemyMove : MonoBehaviour
{

    // 이동속도
    public float speed = 5;

    // 방향 변수
    Vector3 dir;

    public GameObject pung;

    void Start()
    {

        // 1.Random함수를 사용하여 => 0 부터 9안에서 랜덤 int 값
        int ranValue = Random.Range(0, 10);

        // a.플레이어를 찾기
        GameObject player = GameObject.Find("Player");

        // 2. 30%는 player쪽으로 이동
        if (ranValue < 3 && player != null)
        {
           
            // b.방향구하기 : 플레이어쪽 방향 (Player포지션 - Enemy포지션) : 방향 벡터
            dir = player.transform.position - transform.position;

            //  방향 크기 벡터 1로 만들기
            dir.Normalize();
        }
        else
        {
            // 3. 나머지는 아래로
            dir = Vector3.down;
        }


    }

    void Update()
    {
        // 1. 방향(아래) 구하기
        // Vector3 dir = Vector3.down;

        // 2. 이동하기 P = P0 +vt
        transform.position += dir * speed * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject pungPung = Instantiate(pung);
        pungPung.transform.position = gameObject.transform.position;
        // collision = 충돌한 상대방
        //상대방 gameobject 파괴
        Destroy(collision.gameObject);
        //자기자신 gameobject 파괴
        Destroy(gameObject);
        // 2초 후 파괴 이펙트 파괴
        Destroy(pungPung, 0.3f);

    }
}
