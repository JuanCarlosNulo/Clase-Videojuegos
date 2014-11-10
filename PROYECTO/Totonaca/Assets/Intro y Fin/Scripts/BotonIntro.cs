using UnityEngine;
using System.Collections;

public class BotonIntro : MonoBehaviour {

	public GameObject titulo;

	void OnMouseOver(){
		if (Input.GetMouseButtonUp(0)){
			gameObject.animation.Play("ClicBoton");
			titulo.animation.Play("AnImtro");
		}
	}
}
