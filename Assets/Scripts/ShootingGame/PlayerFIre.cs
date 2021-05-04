using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ư�� ������ �̻����� ������������
/// �ʿ�Ӽ� : �̻���������(����), �̻����� ���� ��ġ
/// 1. ��ư�� ������
/// 2. �̻��� �������� �����
/// 3. �̻����� �߻��Ѵ�
/// </summary>

public class PlayerFIre : MonoBehaviour
{

    // �̻����� ������ ������
    public GameObject missilePrefabs;

    // �̻����� ���� ��ġ
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
        // 1. (Fire1)��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �̻��� �������� �����
            GameObject missile = Instantiate(missilePrefabs);

            // 3. �̻����� �߻��Ѵ�
            bbangya.PlayOneShot(bbangyaSound);
            missile.transform.position = missilePos.transform.position;
        }

    }
}
