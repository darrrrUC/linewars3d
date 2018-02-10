using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClickDetection : NetworkBehaviour {

    public GameObject _spawnUnit;
    public Transform _spawnPoint;

	void OnMouseDown()
    {
        CmdSpawnUnit();
    }

    [Command]
    private void CmdSpawnUnit()
    {
        var spawnUnit = Instantiate(_spawnUnit, _spawnPoint.position, Quaternion.identity);
        NetworkServer.Spawn(spawnUnit);
    }
}
