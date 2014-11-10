using UnityEngine;
using System.Collections;

public class BandejaAcc : MonoBehaviour {

	public Activacion esto, Piedra, Pala, Vaso;
	public Ven APiso, AMesa;
	public Interfaz cam;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		if ((esto.activo)&&(esto.accActivo)){
			if (Input.GetMouseButtonUp (0)) {
				Piedra.accActivo = true;
				Pala.accActivo = true;
				Vaso.accActivo = true;
				APiso.accActivo = true;
				AMesa.accActivo = true;
				Destroy (gameObject);
				cam.bandeja.localPosition = cam.posBan;
				cam.tapa.localPosition = cam.posTapa;
			}
		}
	}

}
