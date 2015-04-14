using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textChanger : MonoBehaviour {

	string IP = "IP";
	string data = "data";
	bool rightClick = false;
	// Use this for initialization
	void Start () {
		IP = this.GetComponent ("Translate").IP;
		data = this.GetComponent ("Translate").data;
	}
	
	// Update is called once per frame
	void Update () {
		// show IP
		Text text = GetComponent<Text> ();
		if (!rightClick) {
			text.text = IP;
		}
		if (rightClick) {
			text.text = data;
		}

	}

}
