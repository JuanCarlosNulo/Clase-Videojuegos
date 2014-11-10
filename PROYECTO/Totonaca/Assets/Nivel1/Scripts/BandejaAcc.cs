using UnityEngine;
using System.Collections;

public class BandejaAcc : MonoBehaviour {

	public Activacion Piedra, Pala, Vaso;
	public Ven APiso, AMesa;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonUp (0)) {
			Piedra.accActivo = true;
			Pala.accActivo = true;
			Vaso.accActivo = true;
			APiso.accActivo = true;
			AMesa.accActivo = true;
			Destroy (gameObject);
		}
	}

}
