using UnityEngine;
using System.Collections;

public class IPspawn : MonoBehaviour {

	string[] ipAddresses = new string[100];
	string[] fileSize = new string[20];
	string[] origin = new string[20];
	string[] fileType = new string[20];
	// Use this for initialization
	void Start () {
		// this is messy but it wouldn't let me delcare it normally up there ^
		// as in string[] array = new string{ "blah", "blah", blah" };
		// it kept throwing errors that make no sense
		// feel free to try again
		fileSize [0] = "156kB"; fileSize [1] = "756kB"; fileSize [2] = "645kB"; fileSize [3] = "134kB"; fileSize [4] = "317kB"; fileSize [5] = "498kB"; fileSize [6] = "401kB"; fileSize [7] = "320kB"; fileSize [8] = "569kB"; fileSize [9] = "731kB"; fileSize [10] = "351kB"; fileSize [11] = "368kB"; fileSize [12] = "479kB"; fileSize [13] = "428kB"; fileSize [14] = "600kB"; fileSize [15] = "641kB"; fileSize [16] = "527kB"; fileSize [17] = "264mB"; fileSize [18] = "480mB"; fileSize [19] = "398mB";
		origin [0] = "a"; origin [1] = "b"; origin [2] = "c"; origin [3] = "d"; origin [4] = "e"; origin [5] = "f"; origin [6] = "g"; origin [7] = "h"; origin [8] = "i"; origin [9] = "j"; origin [10] = "k"; origin [11] = "l"; origin [12] = "m"; origin [13] = "n"; origin [14] = "o"; origin [15] = "p"; origin [16] = "q"; origin [17] = "r"; origin [18] = "s"; origin [19] = "t"; 
		fileType [0] = "a"; fileType [1] = "b"; fileType [2] = "c"; fileType [3] = "d"; fileType [4] = "e"; fileType [5] = "f"; fileType [6] = "g"; fileType [7] = "h"; fileType [8] = "i"; fileType [9] = "j"; fileType [10] = "k"; fileType [11] = "l"; fileType [12] = "m"; fileType [13] = "n"; fileType [14] = "o"; fileType [15] = "p"; fileType [16] = "q"; fileType [17] = "r"; fileType [18] = "s"; fileType [19] = "t";

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
			ipAddresses[i] = address;
			address = "";
		}

	}

	void Remake () {
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
			ipAddresses[i] = address;
			address = "";
		}
	}
	
	// Update is called once per frame
	void Update () {


	}

	public string get(int rand, int array){
		switch (array) {
		case 1:
			return ipAddresses[rand];
			break;
		case 2:
			return fileSize[rand];
			break;
		case 3:
			return origin[rand];
			break;
		case 4:
			return fileType[rand];
			break;

		default:
			return ipAddresses[rand];
			break;
		}
	}
}
