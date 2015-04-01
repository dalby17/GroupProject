using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public float timeLeft = 120f;
	public void Start () {

		}

	// Update is called once per frame
	public void Update () {
		timeLeft -= Time.deltaTime;
		Text text = GetComponent<Text> ();
		int seconds = Mathf.FloorToInt (timeLeft);
		text.text = seconds.ToString ();



		if (timeLeft <= 0) 
		{
		//pop up of score screen for that level
		}

	}
}
