using UnityEngine;
using System.Collections;

public class moverSprite : MonoBehaviour {

	public Transform guia;
	Transform thisTransform;
	string cualArea;
	public int dir, actual;

	void Start () {
		thisTransform = transform;
		cualArea = "Interior";
		actual = 1;
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
		if (actual!=dir){
			if (actual==1){
				transform.Rotate(new Vector3(0,0,180));
			}else if(actual==-1){
				transform.Rotate(new Vector3(0,0,0));
			}
			actual = dir;
		}
	}
}
