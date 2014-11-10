using UnityEngine;
using System.Collections;

public class Entrar : MonoBehaviour {

	public GameObject personaje,camara, coli;
	public MovPersonaje perso;
	
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name=="Colisionador"){
			//personaje.animation.Play("AnimPersSalida");
			perso.Objetivo = coli;
			personaje.transform.Rotate(new Vector3(0,-90,0));
			personaje.transform.localPosition = new Vector3(-9.15f,-4f,-11f);
			camara.animation.Play("movCamDentro");

		}
	}
}
