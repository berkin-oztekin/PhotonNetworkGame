using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;


public class GameManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
   
    void Start()
    {
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(8f,-8f),Random.Range(4f, -4f), 1f ), Quaternion.identity);
        //player.AddComponent<BulletScript>();
       
    }

    public void OnEnemyShooted()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            SpawnPlayer();
        }
    }
    void SpawnPlayer()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            if (playerPrefab!= null)
            {
                PhotonNetwork.Destroy(playerPrefab);
            }
            playerPrefab = PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(8f, -8f), Random.Range(4f, -4f), 1f), Quaternion.identity);
        }
    }
}

