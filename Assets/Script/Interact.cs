using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Analysis disable once CheckNamespace
public class Interact : MonoBehaviour {
	public int impact;
	private float time = 0;
	public Text staminaLevel, suspiciousLevel, propaganda;
	public GameObject UIdisplay;

	void OnTriggerStay2D(Collider2D other){
		if (time > 1 && Input.GetAxis("Fire1") != 0) {
			time = 0;
			interactWith (impact);
		}
		time += Time.deltaTime;
	}

	//sorry for the eyes burns, i'm tired, out of hope, and i can't even think... poor code...
	void interactWith (int type) {
		switch (type) {
		case 1://sleep
			UIdisplay.GetComponent<DisplayScore> ().stamina += 1;
			staminaLevel.text = UIdisplay.GetComponent<DisplayScore> ().stamina + "%";
			break;
		case 2:
			UIdisplay.GetComponent<DisplayScore> ().suspicius += 1;
			staminaLevel.text = UIdisplay.GetComponent<DisplayScore> ().suspicius + "%";
			break;
		case 3:
			UIdisplay.GetComponent<DisplayScore> ().propaganda += 1;
			staminaLevel.text = UIdisplay.GetComponent<DisplayScore> ().propaganda + "%";
			break;
		}
	}
}
