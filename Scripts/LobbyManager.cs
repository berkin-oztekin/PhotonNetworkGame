using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public void OnCreateGameButtonClicked()
    {
        Debug.Log("OnCreateGameButtonClicked");
        PhotonNetwork.CreateRoom("SE352x");
    }

    public void OnJoinGameButtonClicked()
    {
        Debug.Log("OnJoinGameButtonClicked");
        PhotonNetwork.JoinRoom("SE352x");
    }

    public void QuitGameButtonClicked()
    {
        Debug.Log("QuitGameButtonClicked");
        Application.Quit();
    }

    public override void OnPlayerEnteredRoom(Player other)
    {
        //if (PhotonNetwork.IsMasterClient)
        //{
        //    if (PhotonNetwork.CurrentRoom.PlayerCount == 15)
        //    {
                PhotonNetwork.LoadLevel("GameScene");
               
        //    }
        //}
    }

    
}
