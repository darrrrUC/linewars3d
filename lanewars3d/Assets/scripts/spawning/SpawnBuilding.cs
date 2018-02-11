using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnBuilding : NetworkBehaviour {

    public GameObject _building;
    public Transform _spawnPosition;

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            var spawnUnit = Instantiate(_building, _spawnPosition.position, Quaternion.identity);
            NetworkServer.Spawn(spawnUnit);
        }
	}
}
