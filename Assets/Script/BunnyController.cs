using UnityEngine;
using UnityEngine.UI;

public class BunnyController : MonoBehaviour {

	// Use this for initialization
	public float maxSpeed = 10f;
	bool facingRight = true;
	private bool grounded=true ;
	private Transform groundCheck;
	float groundRadius=0.2f;
	public LayerMask whatIsGround;
	private Rigidbody2D m_rigidbody2D ;
	float jumpForce = 700f;

	bool doubleJump= false;

	private Animator anim;



	void Awake () {
		groundCheck = transform.Find ("GroundCheck");
		anim = GetComponent<Animator> ();
		m_rigidbody2D = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void FixedUpdate () {


		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", m_rigidbody2D.velocity.y);

		if (grounded) {
			doubleJump = false;
	
		}
			

		}


public void Move(float move, bool jump)
{
	anim.SetFloat ("Speed", Mathf.Abs (move));
		m_rigidbody2D.velocity = new Vector2 (move * maxSpeed, m_rigidbody2D.velocity.y);

	if (move > 0 && !facingRight) {
		Flip ();
	}
	else if (move < 0 && facingRight) {
		Flip ();
	}


		if ((grounded || !
			doubleJump) && jump)
		{
	
		anim.SetBool ("Ground", false);
	
		m_rigidbody2D.velocity= new Vector2(m_rigidbody2D.velocity.x,0);
	
		m_rigidbody2D.AddForce (new Vector2 (0, jumpForce));
	

			if (!grounded) {
				doubleJump = true;
	
			}
	}
}

	void Flip()
	{
		facingRight=!facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x*=-1;
		transform.localScale = theScale;
	}
}
