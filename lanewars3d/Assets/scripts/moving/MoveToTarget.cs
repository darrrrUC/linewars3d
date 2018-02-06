using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour {

    public Transform _target;
    public float _speed;

	void Start()
    {
        _target = GameObject.Find("Target").transform;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_target.position);
    }
}
