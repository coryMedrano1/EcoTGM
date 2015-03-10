using UnityEngine;
using System.Collections;

public class enemyParaAttackScript : MonoBehaviour {
	
	public bool inArea = false;

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

			inArea = true;

		}

	}

	void OnTriggerExit2D(Collider2D otherObject)
	{

		if(otherObject.gameObject.tag == "Player")
		{

			inArea = false;

		}

	}
}
