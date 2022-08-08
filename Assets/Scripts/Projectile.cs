using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            // �ε��� �� ������Ʈ (Enemy)
            Destroy(collision.gameObject);
            // �ε��� �� ������Ʈ (�߻�ü)
            Destroy(gameObject);
        }
    }
}
