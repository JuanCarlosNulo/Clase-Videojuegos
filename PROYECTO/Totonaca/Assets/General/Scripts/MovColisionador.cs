using UnityEngine;
using System.Collections;

public class MovColisionador : MonoBehaviour {

	Transform thisTransform;
	void Start () {
		thisTransform = transform;
		thisTransform.position = new Vector3(thisTransform.position.x, thisTransform.position.y-30f, thisTransform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
