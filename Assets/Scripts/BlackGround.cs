using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackGround : MonoBehaviour
{
    public Material backgroundMaterial;

    [Range(0f, 2f)]                                                     // �����̴� �ӵ�.
    public float moveSpeed = 0.1f;
    void Update()
    {
        // �����̴� ����
        Vector2 dir = Vector2.up;

        // offset ���� P = P0 +vt
        backgroundMaterial.mainTextureOffset += dir * moveSpeed * Time.deltaTime;
    }
}
