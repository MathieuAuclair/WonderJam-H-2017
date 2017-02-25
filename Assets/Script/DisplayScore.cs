using UnityEngine;
using System.Collections;

// Analysis disable once CheckNamespace
public class DisplayScore : MonoBehaviour {

	private bool UIshown = true;
	public GameObject player;
	public GameObject camScene;
	public int stamina = 100, propaganda = 0, suspicius = 0, days = 10;
	private float time = 0;

	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Fire2") != 0 && UIshown && time > 2) {
			UIshown = false;
			time = 0;
			camScene.GetComponent<StickyCamera> ().playerFollowed = this.gameObject;
		} 
		else if (Input.GetAxis ("Fire2") != 0 && time > 2) {
			camScene.GetComponent<StickyCamera> ().playerFollowed = player;
			time = 0;
			UIshown = true;
		}
		if(time <= 2)
		time += Time.deltaTime;
	}
}
