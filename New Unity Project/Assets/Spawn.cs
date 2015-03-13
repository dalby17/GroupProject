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

		Instantiate(box, new Vector3(0, 0, 2), Quaternion.identity);
	}
}
