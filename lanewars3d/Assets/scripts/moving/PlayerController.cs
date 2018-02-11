using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    public GameObject _building;
    public Transform _spawnPosition;

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdspawnBuilding();
        }
    }

    [Command]
    private void CmdspawnBuilding()
    {
        var spawnBuilding = Instantiate(_building, _spawnPosition.position, Quaternion.identity);
        NetworkServer.Spawn(spawnBuilding);
   
    }

    public override void OnStartLocalPlayer()
    {
        NetworkStartPosition start = new NetworkStartPosition();
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    
    
   
}
