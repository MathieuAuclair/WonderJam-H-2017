using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Analysis disable once CheckNamespace
public class doorHelpLabel : MonoBehaviour {

	public Text openDoor;
	public bool changed;
	public string msg;

	public void OnTriggerEnter2D (Collider2D other) {
		openDoor.text = "Press button to open";
		if (changed)
			openDoor.text = msg;
	}

	public void OnTriggerExit2D (Collider2D other) {
		openDoor.text = "";
	}
}
