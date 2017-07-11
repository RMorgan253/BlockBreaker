using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		levelManager.LoadLevel("Win");
	}
	
	void OnCollisonEnter2D (Collision2D collision) {
		print ("Collison");
	}

}
