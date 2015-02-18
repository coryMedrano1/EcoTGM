using UnityEngine;
using System.Collections;

public class attackScript : MonoBehaviour {

	Animator attacks;
	bool isAttacking = false;

	private characterControllerScript characterScript;
	public GameObject character;

	void Awake()
	{
		characterScript = character.GetComponent<characterControllerScript>();

	}

	// Use this for initialization
	void Start () {

		attacks = GetComponent<Animator>();

	}

	void FixedUpdate()
	{
		attacks.SetBool("attack", isAttacking);

	}
	
	// Update is called once per frame
	void Update () {

		if(characterScript.grounded && isAttacking == false && Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			attacks.SetBool("attack", true);

			collider2D.enabled = true;

		}

		else
		{
			collider2D.enabled = false;

		}
	
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		
		if(otherObject.gameObject.tag == "enemy")
		{

			Destroy(otherObject.gameObject);
			
		}
		
	}

}
