using UnityEngine;
using System.Collections;

public class IPspawnV2 : MonoBehaviour {
	
	

	// Use this for initialization
	void Start () {

		string address = "";
		for (int i = 0; i < 100; i++) {
			for (int x = 0; x < 4; x++) {
				int three = Random.Range(0, 1000);
				string threeGroup = three.ToString();
				if (three < 100 && three >= 10) {
					threeGroup = threeGroup + "0";
				}
				else if (three < 10) {
					threeGroup = threeGroup + "00";
				}
				if (x < 3) {
					address = address + threeGroup + ".";
				}
				else {
					address = address + threeGroup;;
				}
			}
			IPspawn.ipAddresses[i] = address;
			Debug.Log(address);
			address = "";
		}
		
		
	}

	void Update()
	{
		if (Input.GetMouseButton(1))
			OnRightClick();
	}
	
	// Update is called once per frame
	void OnRightClick () {
		string [] fileArray = new string[] {"kB", "kB", "kB", "kB", "kB", "kB", "kB", "kB", "gB", "gB"}; 
		string[] otherInfo = new string[100];
		//string info = "";
		//if (Input.GetMouseButton(1))
		//{
		Ray clickPoint = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitPoint;
		
		// See if the ray collided with an object
		if (Physics.Raycast(clickPoint, out hitPoint, 5.0f))
		{
			// Make sure this object was the
			// one that received the right-click
			if (hitPoint.collider == this.GetComponent<Collider>())
			{
				for (int j = 0; j< 100; j++)
				{
					int capacity = Random.Range(0,11);
					string capacityString = capacity.ToString();
					string fileType = fileArray[Random.Range(0,fileArray.Length-1)];
					otherInfo[j] = capacityString + fileType;
					Debug.Log(j);
					Debug.Log(capacityString + fileType);
					capacityString = "";
					fileType = "";
				}
			}
		}
		//}

	}
}