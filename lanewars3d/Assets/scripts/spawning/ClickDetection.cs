using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClickDetection : NetworkBehaviour {

    public GameObject _spawnUnit;
    public Transform _spawnPoint;

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdSpawnUnit();
        }

    }



    [Command]
    private void CmdSpawnUnit()
    {
        var spawnUnit = Instantiate(_spawnUnit, _spawnPoint.position, Quaternion.identity);
        NetworkServer.Spawn(spawnUnit);
    }
}
