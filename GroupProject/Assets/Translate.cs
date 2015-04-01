using UnityEngine;
using System.Collections;

public class Translate : MonoBehaviour {

	bool virus = false;
	// Use this for initialization
	void Start () {
		int rand = Random.Range (0, 10);
		if (rand == 7) {
			virus = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		float moveSpeed = 5f;
		transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
		if (transform.position.y <= -23) {
			if (virus == true) {
				theScore.score -= 100;
			} else {
				theScore.score += 25;
			}
			Destroy (gameObject);
		}
	}
}
