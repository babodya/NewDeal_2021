using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackGround : MonoBehaviour
{
    public Material backgroundMaterial;

    [Range(0f, 2f)]                                                     // 움직이는 속도.
    public float moveSpeed = 0.1f;
    void Update()
    {
        // 움직이는 방향
        Vector2 dir = Vector2.up;

        // offset 조절 P = P0 +vt
        backgroundMaterial.mainTextureOffset += dir * moveSpeed * Time.deltaTime;
    }
}
