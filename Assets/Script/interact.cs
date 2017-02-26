using UnityEngine;
using System.Collections;

public class interact : MonoBehaviour {

	public int typeStamPropSuspi;
	public GameObject UI;
	private bool buttonPressed, prop;

	void OnTriggerEnter2D(Collider2D other){
		buttonPressed = true;
	}

	void OnTriggerExit2D(Collider2D other){
		buttonPressed = false;
		prop = false;
		UI.GetComponent<DisplayScore> ().mkPropaganda = false;
		UI.GetComponent<DisplayScore> ().work = false;
	}

	// Update is called once per frame
	void Update () {

		if (buttonPressed) {
			switch (typeStamPropSuspi) {
			case 1:
				UI.GetComponent<DisplayScore> ().stamina = 100;
				break;
			case 2:
				UI.GetComponent<DisplayScore> ().mkPropaganda = true;
				break;
			case 3:
				UI.GetComponent<DisplayScore> ().work = true;
				break;
			}
		}


	}
}
