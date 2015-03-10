using UnityEngine;
using System.Collections;

public class UIControlScript : MonoBehaviour {

	public float Hp = 100f;

	public GUIText playerHP;

	public GameObject player;

	public Transform respawnPosition;

	void Awake()
	{
		playerHP.GetComponent<GUIText>();

		player.GetComponent<Component>();
		
	}

	// Use this for initialization
	void Start () {

		respawnPosition.transform.position = GameObject.FindWithTag("Respawn").transform.position;

	
	}
	
	// Update is called once per frame
	void Update () {
	
		playerHP.guiText.text = "HP: " + Hp;

		if(Hp == 0)
		{

			player.gameObject.transform.position = respawnPosition.transform.position;

			Hp = 100;

		}

	}
}
