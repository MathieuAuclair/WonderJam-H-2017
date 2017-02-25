using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class doorHelpLabel : MonoBehaviour {

	public Text openDoor;

	void OntriggerEnter2D (Collider2D other) {
		openDoor.text = "Press button to open";
	}

	void OntriggerExit2D (Collider2D other) {
		openDoor.text = "";
	}
}
