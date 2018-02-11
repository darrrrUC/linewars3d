using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class OneCamera : NetworkBehaviour {

    public Camera _camera;

	void Update () {
        if (!isLocalPlayer)
        {
            _camera.enabled = false;
            return;
        }
	}
}
