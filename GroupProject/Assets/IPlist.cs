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
			list =  list + IPspawn.ipAddresses[x] + "\n";
		}
		
		Text text = GetComponent<Text> ();
		text.text = "Banned IPs:\n\n" + list.ToString ();
	}
}
