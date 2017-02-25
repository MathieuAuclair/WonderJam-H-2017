using UnityEngine;
using System.Collections;

// Analysis disable once CheckNamespace
public class npcPatrols : MonoBehaviour {
	public float speedPatrol;
	public float timeInterval;
	private float time = 0;
	private float switchSide = 1;
	// Update is called once per frame
	void Update () {
		this.transform.Translate (speedPatrol * switchSide, 0, 0);
		if (timeInterval < time) {
			time = 0;
			switchSide = switchSide * -1;
			if(switchSide < 0)
				this.gameObject.GetComponent<SpriteRenderer> ().flipX = true;
			else
				this.gameObject.GetComponent<SpriteRenderer> ().flipX = false;
		}
		time += Time.deltaTime;
			
	}
}
