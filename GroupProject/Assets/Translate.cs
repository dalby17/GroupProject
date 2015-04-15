using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Translate : MonoBehaviour {

	bool virus = false;
	string IP = "IP";
	string data = "data";
	int click = 0;
	public GameObject popup;
	// Use this for initialization
	void Start () {
		// is it a virus
		int rand = Random.Range (0, 10);
		if (rand == 7) {
			virus = true;
		}

		// give ip address to box
		if (virus != true && this.gameObject.name == "Button1(Clone)") {
			// not a virus && first level
			rand = Random.Range (0, 89);
		}  else if (virus != true && this.gameObject.name != "Button1(Clone)") {
			// not a virus && not first level
			// have to use other data, just a clue
			rand = Random.Range (0, 99);
		} else {
			// virus
			rand = Random.Range (90, 99);
		}

		IP = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 1);


		// add in other data for further levels
		// level 2
		if (this.gameObject.name == "Button2(Clone)" && virus != true) {
			rand = Random.Range (0, 16);
			data = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 2);
		} else {
			rand = Random.Range (17, 19);
			data = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 2);
		}
		// level 3
		if (this.gameObject.name == "Button3(Clone)") {
			rand = Random.Range(0, 16);
			data = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 4);
		} else {
			rand = Random.Range (17, 19);
			data = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 4);
		}
		// level 4
		if (this.gameObject.name == "Button4(Clone)") {
			rand = Random.Range(0, 16);
			data = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 3);
		} else {
			rand = Random.Range (17, 19);
			data = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(rand, 3);
		}

	}
	
	// Update is called once per frame
	void Update () {
		// change text
		if (click == 1 && this.gameObject.name != "Button1(Clone)") {
			IP = data;
		}
		if (click == 2 || (click == 1 && this.gameObject.name == "Button1(Clone)")) {
			Destroy (gameObject);
		}

		// display text
		GetComponentInChildren<Text> ().text = IP;

		// move box
		float moveSpeed = 30f;
		transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

		// if below screen:
		//		update score
		//		
		if (transform.position.y <= -20) {
			if (virus == true) {
				theScore.score -= 200;
				makePopup ();
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

	void makePopup(){
		int x = Random.Range (50, 600);
		int y = Random.Range (50, 400);
		GameObject button = Instantiate(popup, new Vector3(x, y, 50), Quaternion.identity) as GameObject;
		button.transform.parent = GameObject.Find("popupList").transform;
	}

	public void onClick(){
		click++;
	}
}
