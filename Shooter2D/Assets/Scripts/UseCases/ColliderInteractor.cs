using System.Collections;
using System.Collections.Generic;
using Controllers;
using UnityEngine;
using UseCases;

public class ColliderInteractor {

	private static List<IModel> _models = new List<IModel>();
	private static List<IPresenter> _presenters;
	

	public static void AddModel(IModel model) {
       if (!_models.Contains(model))
			_models.Add(model);
	}
	
	public static void RemoveModel(IModel model) {
		if (_models.Contains(model))
			_models.Remove(model);
	}

	public static void ClearModels() {
		_models.Clear();		
	}

	public static void CheckCollide() {
        foreach (var model in _models)
            model.isCollided = false;

        if (_models.Count < 2)
            return;

        for (int i = 0; i < _models.Count; i++) {
			for (int j = 0; j < _models.Count; j++) {
                if (i == j)
                    continue;

                if (IsIntersected(_models[i].Position, _models[i].Size, _models[j].Position, _models[j].Size)) {
					_models[i].isCollided = true;
					_models[j].isCollided = true;
			    }
            }
		}
	}

	private static bool IsIntersected(Vector2 positionA, float sizeA, Vector2 positionB, float sizeB) {
       return Mathf.Abs(positionA.x - positionB.x) * 2 < (sizeA + sizeB) &&
              Mathf.Abs(positionA.y - positionB.y) * 2 < (sizeA + sizeB);
               
	}
}
