using UnityEngine;
using System.Collections;

public class IPspawnV2 : MonoBehaviour {
	
	bool toShow;
	string address;
	int capacity;
	string capacityString;
	string fileType;

	string[] ipAddresses;

	// Use this for initialization
	void Start () {
		//i = 0;
		toShow = true;
		ipAddresses = new string[100];
		
		//for (int i = 0; i < 100; i++) {
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
			//ipAddresses[i] = address;
			Debug.Log(address);
			//address = "";
		//}
		
		string [] fileArray = new string[] {"kB", "kB", "kB", "kB", "kB", "kB", "kB", "kB", "gB", "gB"}; 
		string[] otherInfo = new string[100];
		string info = "";
		//if (Input.GetMouseButton(1))
		//{
		Ray clickPoint = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitPoint;
		
		// See if the ray collided with an object
		if (Physics.Raycast(clickPoint, out hitPoint))
		{
			// Make sure this object was the
			// one that received the right-click
			if (hitPoint.collider == this.GetComponent<Collider>())
			{
				for (int j = 0; j< 100; j++)
				{
					capacity = Random.Range(0,11);
					capacityString = capacity.ToString();
					fileType = fileArray[Random.Range(0,fileArray.Length-1)];
					otherInfo[j] = capacityString + fileType;
					//capacityString = "";
					//fileType = "";
				}
			}
		}
		//i = 0;
	}
	
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
			OnRightClick();
	}
	
	// Update is called once per frame
	void OnRightClick () {
		
		if (toShow == true)
		{
			Debug.Log("toShow = true " + capacityString + fileType);
			toShow = false;
		}
		else if (toShow == false)
		{
			//address = ipAddresses[i];
			Debug.Log("toShow = false " + address);
			toShow = true;

		}
		
	}
}
