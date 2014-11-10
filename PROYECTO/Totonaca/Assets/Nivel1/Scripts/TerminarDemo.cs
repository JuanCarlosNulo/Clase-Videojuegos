using UnityEngine;
using System.Collections;

public class TerminarDemo : MonoBehaviour {

	public Texture2D cursorTexture;
	CursorMode cursorMode;
	Vector2 hotSpot;
	
	void Start () {
		hotSpot = Vector2.zero;
		cursorMode = CursorMode.Auto;
	}

	void OnMouseOver(){
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		if (Input.GetMouseButtonUp(0)){
			Application.LoadLevel("Final");
		}
	}
}
