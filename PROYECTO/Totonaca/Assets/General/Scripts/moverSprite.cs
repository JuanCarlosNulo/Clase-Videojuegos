using UnityEngine;
using System.Collections;

public class moverSprite : MonoBehaviour {

	public Transform guia;
	Transform thisTransform;
	string cualArea;

	void Start () {
		thisTransform = transform;
		cualArea = "Interior";
	}
	
	// Update is called once per frame
	void Update () {
		switch(cualArea){
			case "Interior": 
				thisTransform.position = new Vector3(guia.position.x, guia.position.y+30f, guia.position.z);
				break;
			case "Exterior":
				thisTransform.position = new Vector3(guia.position.x, guia.position.y+30, guia.position.z);
				break;
		}
	}
}
