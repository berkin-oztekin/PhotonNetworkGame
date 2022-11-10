using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;


public class PlayerMovement : MonoBehaviourPunCallbacks
{
    //public TextMeshPro scoreText;
    // private int score;
    //bool isGameOverReported;
    float speed = 2f;
  

    // Start is called before the first frame update
    void Start()
    {
        // scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = score.ToString();

        if (!photonView.IsMine) return;

        Vector2 movement = new Vector2();

        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 2f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y = -2f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = 2f;
            //FLip();
            //photonView.RPC("FlipFalse", RpcTarget.AllBuffered);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -2f;
            

            //photonView.RPC("FlipTrue", RpcTarget.AllBuffered);
        }


        transform.Translate(movement * speed * Time.deltaTime);

  
    }

    public void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
}






