using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject box;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawn", 2.0f, 2.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawn() {

		GameObject button = Instantiate(box, new Vector3(325, 400, 49), Quaternion.identity) as GameObject;
		button.transform.parent = GameObject.Find("boxList").transform;
		button = Instantiate(box, new Vector3(200, 400, 49), Quaternion.identity) as GameObject;
		button.transform.parent = GameObject.Find("boxList").transform;
		button = Instantiate(box, new Vector3(75, 400, 49), Quaternion.identity) as GameObject;
		button.transform.parent = GameObject.Find("boxList").transform;
	}


}
