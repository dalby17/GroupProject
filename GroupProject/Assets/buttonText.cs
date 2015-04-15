using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonText : MonoBehaviour {

	public string IP;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
		Text text = GetComponent<Text>();
		text.text = IP;
	}
}
