using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    private int EnemyHealth = 20;


    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Died();
        }
    }

    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
        Debug.Log(EnemyHealth);
    }


    private void Died()
    {
        Destroy(gameObject);
    }
}
