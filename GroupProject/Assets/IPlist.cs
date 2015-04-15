using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IPlist : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		string list = "";
		
		for (int i = 0; i < 10; i++) {
			int x = i + 90;
			string ip = GameObject.FindGameObjectWithTag("Respawn").GetComponent<IPspawn>().get(x, 1);
			list =  list + ip + "\n";
		}
		
		Text text = GetComponent<Text> ();
		text.text = list.ToString ();
	}
}
