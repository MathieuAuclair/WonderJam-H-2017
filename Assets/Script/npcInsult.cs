using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Analysis disable once CheckNamespace
public class npcInsult : MonoBehaviour {

	public Text insult;
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		switch (Random.Range (0, 3)) {
		case 0:
			insult.text = "Cunt!";
			break;
		case 1:
			insult.text = "Stupid!";
			break;
		case 2:
			insult.text = "Get Out!";
			break;
		case 3:
			insult.text = "Idiot!";
			break;
		}
	}
}

