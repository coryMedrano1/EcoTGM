using UnityEngine;
using System.Collections;

public class attackScript : MonoBehaviour {

	public float playerAttackPower = 25f;

	Animator attacks;
	bool isAttacking = false;

	private characterControllerScript characterScript;
	public GameObject character;

	private enemyAIScript enemyScript;
	public GameObject enemy;
	
	public AudioClip swordSoundEffect;

	void Awake()
	{
		characterScript = character.GetComponent<characterControllerScript>();

		enemyScript = enemy.GetComponent<enemyAIScript>();



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

			audio.PlayOneShot(swordSoundEffect);

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

			enemyScript.enemyHP = enemyScript.enemyHP - playerAttackPower;
			
		}
		
	}

}
