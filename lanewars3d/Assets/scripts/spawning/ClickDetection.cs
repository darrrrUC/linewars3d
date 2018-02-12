using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClickDetection : NetworkBehaviour {

    public GameObject _spawnUnit;
    private Transform _spawnPoint;

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Attempting to spawn unit");
            CmdSpawnUnit();
        }

    }



    [Command]
    private void CmdSpawnUnit()
    {
        var spawnUnit = Instantiate(_spawnUnit, _spawnPoint.position, Quaternion.identity);
        NetworkServer.Spawn(spawnUnit);
    }

    public override void OnStartLocalPlayer()
    {
        _spawnPoint = GameObject.Find("BuildingSpawn").transform;
    }
}
