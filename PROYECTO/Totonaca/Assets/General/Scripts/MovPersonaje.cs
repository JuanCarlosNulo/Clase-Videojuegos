using UnityEngine;
using System.Collections;

public class MovPersonaje : MonoBehaviour {
	
	Transform thisTransform;
	
	public GameObject Objetivo;
	public float AcelIni;
	public float limiteFinal, limiteMedio, limiteCasi;
	public float Aceleracion;
	Vector3 Velocidad, Lineal;
	float distancia;
	bool avanzar;
	public moverSprite spri;
			
	void Start () {
		thisTransform = transform;
		distancia = Vector3.Distance (Objetivo.transform.position, transform.position);
		limiteMedio = distancia * 0.8f;
		limiteCasi = limiteFinal * 2.5f;
	}
	
	void Update () {
		distancia = Vector3.Distance (Objetivo.transform.position, transform.position);
		if (transform.position.x < Objetivo.transform.position.x){
			spri.dir = 1;
		}else{
			spri.dir = -1;
		}
		controlarAceleracion();
		Lineal= buscar();

		if (avanzar) {
			thisTransform.position += Velocidad * Time.deltaTime;
			Velocidad += Lineal * Time.deltaTime;
			Velocidad -= Velocidad.sqrMagnitude * 0.01f * Velocidad.normalized;
		}
	}

	Vector3 buscar (){
		Lineal = new Vector3();
		Lineal = Objetivo.transform.position - transform.position;
		Lineal.Normalize();
		Lineal *= Aceleracion;
		return Lineal;
	}
 
	void controlarAceleracion(){
		if (distancia < limiteFinal) {
			avanzar = false;
			Aceleracion = 0;
			Objetivo = gameObject;
		} else {
			avanzar = true;
			if (distancia > limiteMedio) {
				Aceleracion = AcelIni;
			}
			if ((distancia > limiteCasi)&&(distancia <= limiteMedio)){
				Aceleracion = AcelIni/3;
			}
			if (distancia < limiteCasi){
				Aceleracion = AcelIni/6;
			}
		}
	}
}