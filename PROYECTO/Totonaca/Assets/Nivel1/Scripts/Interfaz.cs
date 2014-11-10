using UnityEngine;
using System.Collections;

public class Interfaz : MonoBehaviour {

	public Transform bandeja, tapa, piedras, lleno, arena;
	public Vector3 posBan, posTapa, posPiedra, posLleno, posArena;

	void Start () {
		posBan = bandeja.localPosition;
		posTapa = tapa.localPosition;
		posPiedra = piedras.localPosition;
		posLleno = lleno.localPosition;
		posArena = arena.localPosition;

		bandeja.localPosition = Vector3.zero;
		tapa.localPosition = Vector3.zero;
		piedras.localPosition = Vector3.zero;
		lleno.localPosition = Vector3.zero;
		arena.localPosition = Vector3.zero;
	}
}
