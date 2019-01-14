using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractView : MonoBehaviour {

	public void SetPosition(Vector2 newPosition) {
		transform.position = newPosition;
	}
}
