using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teksts : MonoBehaviour {

	public 	GameObject teksts;
	public GameObject vecums;
	public GameObject vards;

	public void paraditTekstu(){
	
		teksts.GetComponent<Text>().text=vards.GetComponent<Text>().text+" ir " + vecums.GetComponent<Text>().text + " gadu vecs.";

			
	}


}
