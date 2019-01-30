using System.Collections;
using System.Collections.Generic;
using Controllers;
using UnityEngine;
using UseCases;

public class ColliderInteractor {

	private static List<IModel> _models = new List<IModel>();
	private static List<IPresenter> _presenters = new List<IPresenter>();
	

	public static void AddModel(IModel model) {
		if (!_models.Contains(model))
			_models.Add(model);
	}
	
	public static void RemoveModel(IModel model) {
		if (_models.Contains(model))
			_models.Remove(model);
	}

	public static void CheckCollide() {
		for (int i = 0; i < _models.Count; i++) {
			for (int j = 0; j < _models.Count; j++) {
				if (i == j)
					continue;
				
				var aTopLeft = _models[i].Position - _models[i].Size / 2 * Vector2.up ;
				var aBottomRight = _models[i].Position + _models[i].Size / 2 * Vector2.down;
				var bTopLeft = _models[j].Position - _models[j].Size / 2 * Vector2.up ;
				var bBottomRight = _models[j].Position + _models[j].Size / 2 * Vector2.down;

				if (IsIntersected(aTopLeft, bBottomRight, aBottomRight, bTopLeft)) {
					_models[i].isCollided = true;
					_models[j].isCollided = true;
				}
				
			}
		}
	}

	private static bool IsIntersected(Vector2 aTopLeft, Vector2 bBottomRight, Vector2 aBottomRight, Vector2 bTopLeft) {
		return (aTopLeft.x > bBottomRight.x)
		       || (aBottomRight.x < bTopLeft.x)
		       || (aTopLeft.y > bBottomRight.y)
		       || (aBottomRight.y < bTopLeft.y);
	}
}
