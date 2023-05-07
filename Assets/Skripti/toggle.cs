using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour {
	public GameObject adidashat;
	public GameObject guccihat;
	public GameObject adidasbikses;
	public GameObject guccibikses;
	public GameObject adidast;
	public GameObject guccit;
	void Start(){
		adidashat.SetActive (false);
		guccihat.SetActive (false);
		adidasbikses.SetActive (false);
		guccibikses.SetActive (false);
		adidast.SetActive (false);
		guccit.SetActive (false);
	 }
	public void showadidashat(bool x){
		adidashat.SetActive (x);

	}
	public void showguccihat(bool x){
		guccihat.SetActive (x);
	}
	public void showadidasbikses(bool x){
		adidasbikses.SetActive (x);
	}
	public void showguccibikses(bool x){
		guccibikses.SetActive (x);
	}


	public void showadidast(bool x){
		adidast.SetActive (x);
	}
	public void showguccit(bool x){
		guccit.SetActive (x);
	}

}
