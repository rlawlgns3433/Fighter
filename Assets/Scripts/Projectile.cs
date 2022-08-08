using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            // 부딪힌 적 오브젝트 (Enemy)
            Destroy(collision.gameObject);
            // 부딪힌 내 오브젝트 (발사체)
            Destroy(gameObject);
        }
    }
}
