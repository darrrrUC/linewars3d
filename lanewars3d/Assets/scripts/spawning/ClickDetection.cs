using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClickDetection : NetworkBehaviour {

    public GameObject _spawnUnit;
    public Transform _spawnPoint;

	void OnMouseDown()
    {

        Debug.Log("Attempting to spawn unity");
        CmdSpawnUnit();
    }

    [Command]
    private void CmdSpawnUnit()
    {
        _spawnPoint = GameObject.Find("spawnpoint").transform;
        var spawnUnit = Instantiate(_spawnUnit, _spawnPoint.position, Quaternion.identity);
        NetworkServer.Spawn(spawnUnit);
    }
}
