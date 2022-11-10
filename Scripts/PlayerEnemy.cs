using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemy : MonoBehaviourPunCallbacks
{
    public int health = 1;
    public GameObject playerPrefab; 
    // Start is called before the first frame update
   
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if(health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
   
}
