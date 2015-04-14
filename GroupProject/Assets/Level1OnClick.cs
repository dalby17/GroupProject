using UnityEngine;
using System.Collections;

public class Level1OnClick : MonoBehaviour {
			
		public void LoadScene(int level)
		{
			Application.LoadLevel(level);
		}
	}