using UnityEngine;
using System.Collections;

public class switchScript : MonoBehaviour {

	public GameObject blockingPillar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if(otherObject.gameObject.tag == "Player")
		{
			

		}
	}
}
