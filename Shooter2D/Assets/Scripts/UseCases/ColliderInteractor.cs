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
		foreach (var model in _models) {
			
		}
	}
}
