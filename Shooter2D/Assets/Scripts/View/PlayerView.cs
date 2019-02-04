using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UseCases;

public class PlayerView : MonoBehaviour {

	public void UpdateView(IModel model) {
		transform.position = model.Position;
	}

    public void Destroy() {
        Destroy(this.gameObject);
    }
}
