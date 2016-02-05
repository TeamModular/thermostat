// MoveTo.cs
using UnityEngine;
using System.Collections;

public class moveTo : MonoBehaviour 
{
	public Vector2 minimumLimits;
	public Vector2 maximumLimits;

	bool waiting;

	NavMeshAgent agent;

	void Start()
	{
		waiting = false;
		agent = GetComponent<NavMeshAgent> ();
	}

	IEnumerator SetNewDestinationAfterWaiting(float time)
	{
		yield return new WaitForSeconds (2);

		Vector3 location = new Vector3 (Random.Range (minimumLimits.x, maximumLimits.x), 0, Random.Range (minimumLimits.y, maximumLimits.y));
		agent.destination = location; 
		waiting = false;
	}

	void Update () 
	{
		if (agent.velocity == Vector3.zero && !waiting) 
		{
			StartCoroutine (SetNewDestinationAfterWaiting (1));
			waiting = true;
		} 
	}


}