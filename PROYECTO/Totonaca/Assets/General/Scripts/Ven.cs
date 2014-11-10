using UnityEngine;
using System.Collections;

public class Ven : MonoBehaviour {

	public GameObject Objetivo;
	public MovPersonaje personaje;

	public Texture2D cursorTexture;
	CursorMode cursorMode;
	Vector2 hotSpot;

	public bool accActivo;

	void Start(){
		cursorMode = CursorMode.Auto;
		hotSpot = Vector2.zero;
	}

	void OnMouseOver(){
		if ((Input.GetMouseButtonUp(0))&&(accActivo)){
			personaje.Objetivo = Objetivo;
		}
	}

	void OnMouseEnter () {
		if (accActivo) {
			Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);
		}
	}
	void OnMouseExit () {
		if (accActivo) {
			Cursor.SetCursor(null, Vector2.zero, cursorMode);
		}
	}

}
