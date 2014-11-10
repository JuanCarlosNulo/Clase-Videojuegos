using UnityEngine;
using System.Collections;

public class Conseguido : MonoBehaviour {

	public AncianoAcc Anciano;
	public int qsoy;
	public Interfaz cam;
	public Activacion esto;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		if ((esto.activo)&&(esto.accActivo)){
			if (Input.GetMouseButtonUp (0)) {
				switch (qsoy){
				case 1: Anciano.Piedra = true;
					cam.piedras.localPosition = cam.posPiedra;	
					break;
				case 2: Anciano.Agua = true;
					cam.lleno.localPosition = cam.posLleno;	
					break;
				case 3: Anciano.Arena = true;
					cam.arena.localPosition = cam.posArena;	
					break;
				}
				Destroy (gameObject);
			}
		}
	}
}
