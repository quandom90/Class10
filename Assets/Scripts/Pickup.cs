using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Hit");
		if (collider.gameObject.tag == "Player") {
			var gc = GameObject.FindGameObjectWithTag("GameController");
			gc.GetComponent<GameController>().IncrementScore(1);

			Destroy(gameObject);
		}
	}
	
}
