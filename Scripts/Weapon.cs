using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

public class Weapon : MonoBehaviourPunCallbacks
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    // Update is called once per frame

    void Update()
    {
        if (!photonView.IsMine) 
            return;

        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }

    }

    private void Shoot()
    {
        Debug.Log("Shooted");
        GameObject obj = PhotonNetwork.Instantiate(bulletPrefab.name, new Vector2(firepoint.transform.position.x, firepoint.transform.position.y), Quaternion.identity);

        //Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
    
}
