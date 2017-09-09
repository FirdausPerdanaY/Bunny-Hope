using UnityEngine;

[RequireComponent(typeof (BunnyController))]

public class BunnyUserControl : MonoBehaviour {

	private BunnyController m_Character;
	private bool m_Jump=false;
	// Use this for initialization
	private void Awake() {
		m_Character = GetComponent<BunnyController> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown(KeyCode.KeypadEnter)) || Input.GetMouseButtonDown(0)||(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began)) {
			m_Jump = true;
		
		}

	}

	void FixedUpdate()
	{
		//float h = Input.GetAxis ("Horizontal");
		m_Character.Move (1, m_Jump);
		m_Jump = false;
	}
}
