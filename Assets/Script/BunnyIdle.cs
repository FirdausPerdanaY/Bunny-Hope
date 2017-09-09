using UnityEngine;

[RequireComponent(typeof (MenuController))]

public class BunnyIdle : MonoBehaviour {

	private MenuController m_Character;
	// Use this for initialization
	private void Awake() {
		m_Character = GetComponent<MenuController> ();


	}

	// Update is called once per frame
	void Update () {
		


	}

	void FixedUpdate()
	{
		//float h = Input.GetAxis ("Horizontal");
	

	}
}
