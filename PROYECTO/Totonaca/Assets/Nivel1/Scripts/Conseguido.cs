using UnityEngine;
using System.Collections;

public class Conseguido : MonoBehaviour {

	public AncianoAcc Anciano;
	public int qsoy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonUp (0)) {
			switch (qsoy){
			case 1: Anciano.Piedra = true; break;
			case 2: Anciano.Agua = true; break;
			case 3: Anciano.Arena = true; break;
			}
			Destroy (gameObject);
		}
	}
}
