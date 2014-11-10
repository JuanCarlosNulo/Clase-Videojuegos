using UnityEngine;
using System.Collections;

public class VasoAcc : MonoBehaviour {
	
	public Activacion esto, Rio;
	public Ven ARio;

	void Start () {
		
	}

	void Update () {
		
	}
	
	void OnMouseOver(){
		if ((esto.activo)&&(esto.accActivo)){
			if (Input.GetMouseButtonUp (0)) {
				Rio.accActivo = true;
				ARio.accActivo = true;
				Destroy (gameObject);
			}
		}
	}
	
}