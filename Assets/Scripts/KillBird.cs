using UnityEngine;
using System.Collections;

public class KillBird : MonoBehaviour {

	public void KillMe(){
		Destroy (gameObject);
	}

	public void CHangeSpeed(){
		var animator = GetComponent<Animator> ();
		animator.speed = Random.Range (.1f, 2f);
	}

}
