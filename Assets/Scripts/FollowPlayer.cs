using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour {

	// Use this for initialization
	public NavMeshAgent agent;
	public GameObject target;
	void Start () {
		target = SceneManager.instance.player.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			target = SceneManager.instance.player.gameObject;
		else {
			float distance=10f;
			Vector3 hostPos=gameObject.transform.position;
			Vector3 targetPos=target.transform.position;
			Ray ray=new Ray(hostPos,(targetPos-hostPos).normalized*10);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit,distance))
			{
				if(hit.collider.gameObject==target)
				{
					//float angle = Vector3.Angle((targetPos - hostPos), gameObect.Transform.forward);
					//if(angle<5f)
					//{
						//Do something
					//}
					agent.SetDestination(hit.point);

				}
			}
		}
	}
}
