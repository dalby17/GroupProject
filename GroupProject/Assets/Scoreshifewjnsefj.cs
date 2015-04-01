using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoreshifewjnsefj : MonoBehaviour {

	public static int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// show score
		Text text = GetComponent<Text> ();
		text.text = score.ToString ();
	}
}
