using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour {
	public Sprite antimage;
	public Sprite crystal;
	public GameObject image;
	public void MainitAttelu(int x){
		if (x == 0) {
			image.GetComponent<Image> ().sprite = antimage;

		} else {
			image.GetComponent<Image> ().sprite = crystal;
		}
	}


}
