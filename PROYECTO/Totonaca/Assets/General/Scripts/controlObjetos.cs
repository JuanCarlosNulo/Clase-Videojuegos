using UnityEngine;
using System.Collections;

public class controlObjetos : MonoBehaviour {

	public bool enArea;
	public Activacion[] arrObjetos;
	//Collider thisCol;
	//Vector3 tamOriginal;

	void Start(){
		//tamOriginal = thisCol.collider;
	}


	void Update () {
		foreach (Activacion obj in arrObjetos) {
			if (enArea){
				obj.activo = true;
			}else{
				obj.activo = false;
			}
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name=="Colisionador"){
			enArea= true;
			//thisCol.enabled = false;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.name=="Colisionador"){
			enArea= false;
			//thisCol.enabled = true;
		}
	}
}
