using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Analysis disable once CheckNamespace
public class npcInsult : MonoBehaviour {

	public Text insult;
	public string insult1, insult2, insult3, insult4;
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		switch (Random.Range (0, 4)) {
		case 0:
			insult.text = insult1;
			break;
		case 1:
			insult.text = insult2;
			break;
		case 2:
			insult.text = insult3;
			break;
		case 3:
			insult.text = insult4;
			break;
		}
	}
}

