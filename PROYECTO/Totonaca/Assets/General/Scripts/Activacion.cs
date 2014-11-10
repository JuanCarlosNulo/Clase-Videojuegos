using UnityEngine;
using System.Collections;

public class Activacion : MonoBehaviour {

	public bool activo, accActivo;
	Collider thisCol;

	public Texture2D cursorTexture;
	CursorMode cursorMode;
	Vector2 hotSpot;

	void Start () {
		thisCol = gameObject.collider;
		hotSpot = Vector2.zero;
		cursorMode = CursorMode.Auto;
	}

	void Update(){
		if (accActivo){
			if (activo){
				thisCol.enabled = true;
			}else{
				thisCol.enabled = false;
			}
		}
	}

	void OnMouseOver(){
		if (activo){
			Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		}
	}

	void OnMouseExit(){
		if (activo){
			Cursor.SetCursor(null, Vector2.zero, cursorMode);
		}
	}
}
