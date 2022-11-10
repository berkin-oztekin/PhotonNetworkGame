using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;
   

    void Start() {
        rb.velocity = transform.right * speed; //*Time.Delta 

    }
        public void OnTriggerEnter2D(Collider2D hitInfo)
    {
     
        PlayerEnemy enemy = hitInfo.GetComponent<PlayerEnemy>();
        if(enemy != null)
        {
           
                enemy.TakeDamage(damage);

        }
     
        Destroy(gameObject);
        Debug.Log(hitInfo.name);
    }
 
}

