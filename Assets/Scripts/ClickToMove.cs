using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
	public Camera cam;
	public NavMeshAgent agent;
	private Ray ray;
	private RaycastHit hit;

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ray = cam.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				agent.SetDestination(hit.point);
			}
		}
	}
}
