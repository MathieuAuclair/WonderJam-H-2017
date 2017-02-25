using UnityEngine;
using System.Collections;

// Analysis disable once CheckNamespace
public class Interact : MonoBehaviour {
	public enum impact {
		suspicious,
		stamina,
		propaganda
	};
	private float time = 0;

	void OnTriggerStay2D(Collider2D other){
		if (time > 1 && Input.GetAxis("Fire1") != 0) {
			time = 0;

		}
		time += Time.deltaTime;
	}

}
