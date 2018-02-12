using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraAtPlayer : NetworkBehaviour {

    private Camera _camera;

    void Start()
    {
        if (isLocalPlayer)
        {
            
            return;
        }

        _camera.enabled = false;
    }

    public override void OnStartLocalPlayer()
    {
        _camera = Camera.main;
        Debug.Log("Player pos: " + this.transform.position);
        Debug.Log("Camera pos: " + _camera.transform.position);
        var tmp = _camera.transform.position = this.transform.position;
        tmp.y = 10;
        _camera.transform.position = tmp;
        
    }
}
