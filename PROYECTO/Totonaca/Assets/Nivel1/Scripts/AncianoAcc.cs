using UnityEngine;
using System.Collections;

public class AncianoAcc : MonoBehaviour {

	public Activacion Bandeja;
	public Ven APared;
	public GameObject Instrucciones, gorro;
	Vector3 pos, x;
	bool mostrar;
	public bool Arena, Agua, Piedra;
	
	void Start () {
		mostrar = false;
		x = new Vector3(100,pos.y,pos.z);
		pos = Instrucciones.transform.position;
		Instrucciones.transform.position = x;
	}
	
	// Update is called once per frame
	void Update () {
//		Instrucciones.height = 0;
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonUp(0)){
			Bandeja.accActivo = true;
			APared.accActivo = true;
			mostrar = true;
			if ((Arena)&&(Agua)&&(Piedra)){
				gorro.animation.wrapMode = WrapMode.Loop;
				gorro.animation.Play("gorro");
				mostrar = false;
			}
		}
		if (mostrar){
			Instrucciones.transform.position = pos;
		}
	}

	void OnMouseExit () {
		Instrucciones.transform.position = x;
	}
}
