
using UnityEngine;

public class EnemyPresenter {
	public EnemyModel _enemyModel;
	public EnemyView _enemyView;

	public EnemyPresenter(Vector2 startPosition, EnemyView enemyView) {
		_enemyModel = new EnemyModel(startPosition, 1f, 20f );
		_enemyView = enemyView;
		_enemyView.Init(this);
	}

	public EnemyModel Model {
		get { return _enemyModel; }
        
	}
    
	public void MoveModel(Vector2 direction) {
		_enemyModel.Move(direction);
	}
    
   
}
