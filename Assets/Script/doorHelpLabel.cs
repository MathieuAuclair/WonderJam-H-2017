using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Analysis disable once CheckNamespace
public class doorHelpLabel : MonoBehaviour {

	public Text openDoor;

	public void OnTriggerEnter2D (Collider2D other) {
		openDoor.text = "Press button to open";
	}

	public void OnTriggerExit2D (Collider2D other) {
		openDoor.text = "";
	}
}
