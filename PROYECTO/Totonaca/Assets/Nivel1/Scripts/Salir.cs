using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour {
	
	public GameObject personaje,camara, coli;
	public MovPersonaje perso;

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name=="Colisionador"){
				//personaje.animation.Play("AnimPersSalida");
			perso.Objetivo = coli;
			personaje.transform.localPosition = new Vector3(-23.78f,-4f,-11f);
			camara.animation.Play("movCam");
			personaje.transform.Rotate(new Vector3(0,90,0));
		}
	}
}
