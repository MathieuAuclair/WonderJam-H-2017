using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class quitMenu : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene ("Scene1");
	}
}
