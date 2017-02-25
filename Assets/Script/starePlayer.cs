using UnityEngine;
using System.Collections;

// Analysis disable once CheckNamespace
public class starePlayer : MonoBehaviour {

	public GameObject player;

	// Update is called once per frame
	void LateUpdate () {
		if (this.transform.position.x > player.gameObject.transform.position.x)
			this.gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		else
			this.gameObject.GetComponent<SpriteRenderer> ().flipX = false;
	}
}
