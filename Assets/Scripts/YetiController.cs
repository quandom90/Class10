using UnityEngine;
using System.Collections;

public class YetiController : MonoBehaviour {

	private Rigidbody2D _rigidBody;
	private bool _jump;
	private Animator _animator;
	private bool _grounded;

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody2D> ();
		_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//reading key press or mouse input? DO IT HERE
		//Reading Input.GetAcis? Here or FixedUpdate

		if ((!_jump) && (_grounded)) {
			_jump = Input.GetButtonDown ("Fire1");
		} 
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Platform") {
			_grounded = true;
			_animator.SetBool("Grounded", true);
		}
	}
	void FixedUpdate(){

		if (_jump) {
			_rigidBody.AddForce(new Vector2(0, 1000));
			_animator.SetTrigger("Jumping");
			_grounded = false;
			_animator.SetBool("Grounded", false);
			_jump = false;
		}
		var horizontal = Input.GetAxis ("Horizontal");
		var vertical = Input.GetAxis ("Vertical");

		if (horizontal < 0) {
			transform.localScale = new Vector3 (-1, 1, 1);
		} else if (horizontal > 0) {
			transform.localScale = new Vector3(1, 1, 1);
		}

		if (horizontal != 0) {
			_animator.SetBool ("Running", true);		
		} else {
			_animator.SetBool("Running", false);
		}
	     
		_rigidBody.velocity = new Vector2 (horizontal * 10, _rigidBody.velocity.y);
	}
}
