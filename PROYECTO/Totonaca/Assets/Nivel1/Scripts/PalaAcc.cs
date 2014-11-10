using UnityEngine;
using System.Collections;

public class PalaAcc : MonoBehaviour {
	
	public Activacion Arena;
	public Ven APatio;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseOver(){
		if (Input.GetMouseButtonUp (0)) {
			APatio.accActivo = true;
			Arena.accActivo = true;
			Destroy (gameObject);
		}
	}
	
}