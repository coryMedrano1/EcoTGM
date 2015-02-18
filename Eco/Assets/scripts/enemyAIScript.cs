using UnityEngine;
using System.Collections;

public class enemyAIScript : MonoBehaviour {

	public Transform target;
	public float enemySpeed = 3f;
	public float stopDistance;
	Transform enemyTransform;

	// Use this for initialization
	void Start () {

		enemyTransform = transform;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance(target.position, enemyTransform.position) > stopDistance)
		{
			//get direction from target
			Vector3 direction = target.position - enemyTransform.position;
			//normalize the direction
			direction.Normalize();
			//move in direction of target
			enemyTransform.position += direction * enemySpeed * Time.deltaTime;

		}
	
	}

}
