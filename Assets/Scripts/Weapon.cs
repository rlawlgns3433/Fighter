using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab; // 발사체
    [SerializeField]
    private float attackRate = 0.1f;

    public void StartFiring()
    {
        StartCoroutine("TryAttack");
    }

    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }

    private IEnumerator TryAttack()
    {
        while (true)
        {
            // 발사체 오브젝트 생성
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(attackRate);
        }
    }
}
