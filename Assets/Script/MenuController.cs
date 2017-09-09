using UnityEngine;

public class MenuController : MonoBehaviour {

	public float maxSpeed = 10f;
	//bool facingRight = true;
	private bool grounded ;
	private Transform groundCheck;
	float groundRadius=0.2f;
	public LayerMask whatIsGround;
	private Rigidbody2D m_rigidbody2D ;


	private Animator anim;



	private void Start () {
		groundCheck = transform.Find ("GroundCheck");
		anim = GetComponent<Animator> ();
		m_rigidbody2D = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void FixedUpdate () {


		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", m_rigidbody2D.velocity.y);


	}





}
