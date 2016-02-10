// MoveTo.cs
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class moveTo : MonoBehaviour 
{
	public List<GameObject> rooms;

	bool waiting;

	NavMeshAgent agent;
	Animation animator;

	void Start()
	{
		animator = GetComponent<Animation> ();
		waiting = true;
		agent = GetComponent<NavMeshAgent> ();
	}

	IEnumerator SetNewDestinationAfterWaiting(float time)
	{
		yield return new WaitForSeconds (2);

		int randomRoom = Random.Range (0, rooms.Count - 1);

		BoxCollider collider = rooms[randomRoom].GetComponent<BoxCollider> ();
		float maxX = collider.bounds.max.x;
		float maxY = collider.bounds.max.z;
		float minX = collider.bounds.min.x;
		float minY = collider.bounds.min.z;

		Vector3 location = new Vector3 (Random.Range (minX, maxX), 0, Random.Range (minY, maxY));
		agent.destination = location; 
		waiting = true;
	}

	void Update () 
	{
		if (agent.velocity == Vector3.zero && waiting) 
		{
			StartCoroutine (SetNewDestinationAfterWaiting (1));
			waiting = false;
		}
		if (agent.velocity == Vector3.zero) 
		{
			animator.Play ("idle",PlayMode.StopAll);
		} else 
		{
			animator.Play ("walk",PlayMode.StopAll);
		}
	}


}