using UnityEngine;
using System.Collections;

public class VasoAcc : MonoBehaviour {
	
	public Activacion Rio;
	public Ven ARio;

	void Start () {
		
	}

	void Update () {
		
	}
	
	void OnMouseOver(){
		if (Input.GetMouseButtonUp (0)) {
			Rio.accActivo = true;
			ARio.accActivo = true;
			Destroy (gameObject);
		}

	}
	
}