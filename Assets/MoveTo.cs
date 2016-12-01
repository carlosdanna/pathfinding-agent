using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {


    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Goto(Transform goal) {
        agent.destination = goal.position;
    }
}
