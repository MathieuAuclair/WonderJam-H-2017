using UnityEngine;
using System.Collections;

// Analysis disable once CheckNamespace
public class WarpDoor : MonoBehaviour {
	public float delay = 3;
	public GameObject exitDoor;
	private bool tp = true;
	private float time = 0;
	void OnTriggerEnter2D (Collider2D other) {
		other.transform.position = new Vector3(exitDoor.transform.position.x,exitDoor.transform.position.y,-0.1f);
		exitDoor.GetComponent<BoxCollider2D>().enabled = false;
		time = delay;
		tp = true;
		}

		public void Update()
		{
			if(tp)
				time -= Time.deltaTime;
			if (time < 0)
			{
				exitDoor.GetComponent<BoxCollider2D>().enabled = true;
				tp = false;
			}
		}
	}
	

