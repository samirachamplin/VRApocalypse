using UnityEngine;
using System.Collections;

public class GuiLevel : MonoBehaviour {

		void OnGUI ()
		{
			if(GUI.Button(new Rect(10,10,150,100), "Click"))
			{
				Debug.Log("Button Clicked");
			}
		}
	}