// MoveTo.cs
using UnityEngine;
using System.Collections;

public class moveTo : MonoBehaviour 
{
	public Vector2 minimumLimits;
	public Vector2 maximumLimits;

	NavMeshAgent agent;

	void Start()
	{
		agent = GetComponent<NavMeshAgent> ();
	}

	void Update () 
	{
		if (agent.velocity == Vector3.zero) 
		{
			Vector3 location = new Vector3 (Random.Range (minimumLimits.x, maximumLimits.x), 0, Random.Range (minimumLimits.y, maximumLimits.y));
			agent.destination = location; 
		}
	}



}