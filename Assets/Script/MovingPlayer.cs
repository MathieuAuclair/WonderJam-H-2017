using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Analysis disable once CheckNamespace
public class MovingPlayer : MonoBehaviour {
	public Text spam;
	public GameObject UIspam;
	public float playerSpeed;
	public float playerSpeedWhileJump = 25;
	public int jumpPulse;
	public int flapping;
	public int facing = 1;
	private float jumpTime = 0;
	private float time = 0;
	private float initSpeed;
	private float moveX = 0;
	private Rigidbody2D rb;
	private bool jumpReady = true;
	public bool spamDisplay;

	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		initSpeed = playerSpeed;
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (this.transform.position.y < -250)
			this.transform.position = new Vector3 (132,29,-1);


		moveX = Input.GetAxis ("Horizontal");

		if (moveX != 0) {
			//jumpy
			if (time <= 0.1)
				this.transform.Rotate (0, 0, flapping);
			else if (time > 0.1) {
				this.transform.Rotate (0, 0, -flapping);
				time = 0;
			}
			time += Time.deltaTime;
		}
		this.transform.Translate ((moveX / (100 - playerSpeed)) * facing, 0, 0);

		if ((moveX < 0 && facing == 1) || (moveX > 0 && facing == -1)) {
			this.transform.Rotate (0, 180, 0);
			facing = facing * -1;
		}


		if (Input.GetAxis ("Jump") > 0 && jumpReady && jumpTime > 0.2) { //Y to jump with a controller
			rb.AddForce (new Vector2 (0, 10 * jumpPulse));
			jumpReady = false;
			jumpTime = 0;
		}

		jumpTime += Time.deltaTime;
			
		//check for falling on side
		if (this.transform.localEulerAngles.z > 70 && this.transform.localEulerAngles.z < 290 && !UIspam.GetComponent<DisplayScore>().usedSpam) {
			if (spamDisplay) {
				switch (Random.Range (0, 5)) {
				case 0:
					spam.text = "WTF!?!!";
					break;
				case 1:
					spam.text = "JEEZZZ!";
					break;
				case 2:
					spam.text = "GOD DAMMIT!";
					break;
				case 3:
					spam.text = "THANKS OBAMA!";
					break;
				case 4:
					spam.text = "F***! OFF!!";
					break;
				case 5:
					spam.text = "SHIT!";
					break;
				}
				spamDisplay = false;
			}
		} else if (!UIspam.GetComponent<DisplayScore>().usedSpam){
			spam.text = "";
			spamDisplay = true;
		}

	}


	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Floor") {
			jumpReady = true;
			playerSpeed = initSpeed;
		}
	}


	void OnCollisionExit2D (Collision2D col) {
		playerSpeed = playerSpeedWhileJump;
	}
}