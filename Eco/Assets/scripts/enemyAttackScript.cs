using UnityEngine;
using System.Collections;

public class enemyAttackScript : MonoBehaviour {

	public float enemyAttackPower = 25f; 

	Animator enemyAttacks;
	bool attack = false;

	private enemyParaAttackScript areaScript;
	public GameObject area;

	private UIControlScript hpScript;
	public GameObject playerHP;


	void Awake()
	{
		areaScript = area.GetComponent<enemyParaAttackScript>();

		hpScript = playerHP.GetComponent<UIControlScript>();
		
	}

	// Use this for initialization
	void Start () {

		enemyAttacks = GetComponent<Animator>();
	
	}

	void FixedUpdate()
	{
		enemyAttacks.SetBool("isPositioned", attack);
		
	}
	
	// Update is called once per frame
	void Update () {

		if(areaScript.inArea == true)
		{

			enemyAttacks.SetBool("isPositioned", true);
			
			collider2D.enabled = true;


		}

		if(areaScript.inArea == false)
		{

			enemyAttacks.SetBool("isPositioned", false);
			
			collider2D.enabled = false;

		}
	
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		
		if(otherObject.gameObject.tag == "Player")
		{

			hpScript.Hp = hpScript.Hp - enemyAttackPower;
			
		}
		
	}

}
