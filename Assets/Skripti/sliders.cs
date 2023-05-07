using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sliders : MonoBehaviour {

	public GameObject image;
	public GameObject garums;
	public GameObject platums;

	public void mainitPlatumu(){
		float x = platums.GetComponent<Slider> ().value;
		float a = garums.GetComponent<Slider> ().value;
		image.transform.localScale = new Vector2 (x * 2f, a);


	}

	public void mainitGarumu(){
		float x = garums.GetComponent<Slider> ().value;
		float a = platums.GetComponent<Slider> ().value;
		image.transform.localScale = new Vector2 (a, x*2f);

	}

}
