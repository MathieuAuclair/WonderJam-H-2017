using UnityEngine;
using System.Collections;

// Analysis disable once CheckNamespace
public class WarpDoor : MonoBehaviour {
	public GameObject exitDoor;
	private float time = 0;


	void OnTriggerStay2D (Collider2D other) {
		if (time > 1 && Input.GetAxis("Fire1") != 0) {
			time = 0;
			other.transform.position = new Vector3 (exitDoor.transform.position.x, exitDoor.transform.position.y, -0.1f);
		}
		time += Time.deltaTime;
		}
	}
	

