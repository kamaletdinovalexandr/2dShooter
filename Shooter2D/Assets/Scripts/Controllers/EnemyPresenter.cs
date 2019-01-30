
using Controllers;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UseCases;

public class EnemyPresenter : IPresenter{
	public IModel _enemyModel;
	public EnemyView _enemyView;

	public EnemyPresenter(Vector2 startPosition, EnemyView enemyView) {
		_enemyModel = new EnemyModel(startPosition, 1f, 20f );
		_enemyView = enemyView;
		UpdateView();
	}

	public IModel Model {
		get { return _enemyModel; }
        
	}
    
	public void MoveModel(Vector2 direction) {
		_enemyModel.Move(direction);
		UpdateView();
	}

	public void UpdateView() {
		_enemyView.UpdateView(_enemyModel);
	}
    
   
}
