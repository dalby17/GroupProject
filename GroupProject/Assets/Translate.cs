using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Translate : MonoBehaviour {
	
	bool virus = false;
	string IP = "IP";
	string data = "data";
	// Use this for initialization
	void Start () {
		// is it a virus
		int rand = Random.Range (0, 10);
		if (rand == 7) {
			virus = true;
		}
		
		// give ip address to box
		if (virus != true && this.gameObject.name == "Box1(Clone)") {
			// not a virus && first level
			rand = Random.Range (0, 89);
		}  else if (virus != true && this.gameObject.name != "Box1(Clone)") {
			// not a virus && not first level
			// have to use other data, just a clue
			rand = Random.Range (0, 99);
		} else {
			// virus
			rand = Random.Range (90, 99);
		}
		
		IP = IPspawn.ipAddresses[rand];
		
		// add in other data for further levels
		// level 2
		if (this.gameObject.name == "Box1(Clone)") {
			data = IP;
		}
		if (this.gameObject.name == "Box2(Clone)" && virus != true) {
			rand = Random.Range (0, 16);
			//data = IPspawn.fileSize [rand];
		} else {
			rand = Random.Range (17, 19);
			//data = IPspawn.fileSize [rand];
		}
		// level 3
		if (this.gameObject.name == "Box3(Clone)") {
			rand = Random.Range(0, 16);
			//data = IPspawn.fileType[rand];
		} else {
			rand = Random.Range (17, 19);
			//data = IPspawn.fileType [rand];
		}
		// level 4
		if (this.gameObject.name == "Box4(Clone)") {
			rand = Random.Range(0, 16);
			//data = IPspawn.origin[rand];
		} else {
			rand = Random.Range (17, 19);
			//data = IPspawn.origin [rand];
		}
		// level 5
		if (this.gameObject.name == "Box5(Clone)") {
			rand = Random.Range(0, 19);
			//data = IPspawn.keywords[rand];
		} else {
			rand = Random.Range (17, 19);
			//data = IPspawn.keywords [rand];
		}


	}
	
	// Update is called once per frame
	void Update () {
		// clicking
		if (mouseEntered) {
				if (Input.GetMouseButtonDown (1)) {
					this.GetComponent("textChanger").rightClick = true;	
				}
			}

		// move box
		float moveSpeed = 30f;
		transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
		
		// if below screen:
		//		update score
		//		
		if (transform.position.y <= -30) {
			if (virus == true) {
				theScore.score -= 100;
			} else {
				theScore.score += 25;
			}
			Destroy (gameObject);
		}
		
		// if end of level
		if (Timer.timeLeft <= 0) {
			Destroy (gameObject);
		}
	}

	public bool mouseEntered { get; set; }

}