using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnerController : MonoBehaviourPunCallbacks
{
[SerializeField] private GameObject[] prefabs;
private int rand;
private Touch touch;
private Vector3 tpose;

    private void Start()
    {

    }
    void Update()
    {

        //     Input.touchCount = 0;
    }
    public void bttnscript()
    {
        PhotonNetwork.Instantiate("AndyGreenDiffuse", tpose, Quaternion.identity,0);
    }
}
