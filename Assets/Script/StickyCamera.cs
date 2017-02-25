using UnityEngine;
using System.Collections;

public class StickyCamera : MonoBehaviour {

	public GameObject playerFollowed;
	private float moveX, moveY;

	
	// Update is called once per frame
	void LateUpdate () {
		moveX = 0;
		moveY = 0;
		if (playerFollowed.transform.position.x != this.transform.position.x) {
			moveX = playerFollowed.transform.position.x - this.transform.position.x;
		}
		if (playerFollowed.transform.position.y != this.transform.position.y) {
			moveY = playerFollowed.transform.position.y - this.transform.position.y;
		}
		this.transform.Translate (moveX*Time.deltaTime, moveY*Time.deltaTime, 0);
	}
}
