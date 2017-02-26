using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class winEnd : MonoBehaviour {

	private bool init;

	void Start(){
		init = true;
	}

	public GameObject cameraScene, UI, player;
	
	// Update is called once per frame
	void Update () {
		if (UI.GetComponent<DisplayScore> ().win) {
				player.GetComponent<MovingPlayer> ().spam.enabled = false;
				if (init) {
				cameraScene.transform.position = new Vector3(400,50, cameraScene.transform.position.z);
					init = false;
				}
				cameraScene.transform.Translate (0, -0.5f * Time.deltaTime, 0);
				cameraScene.GetComponent<StickyCamera> ().enabled = false;
			if (Input.GetKeyDown(KeyCode.R))
				SceneManager.LoadScene ("Menu");
			}
		}
	}

