
using Controllers;
using UnityEngine;

using UseCases;

public class EnemyPresenter : IPresenter{
	public IModel EnemyModel;
	public EnemyView _enemyView;

	public EnemyPresenter(Vector2 startPosition, EnemyView enemyView) {
		EnemyModel = new EnemyModel(startPosition, 1f, 20f );
		_enemyView = enemyView;
		UpdateView();
        ColliderInteractor.AddModel(EnemyModel);
    }
    
	public void MoveModel(Vector2 direction) {
		EnemyModel.Move(direction);
		UpdateView();
	}

    public IModel GetModel() {
        return EnemyModel;
    }

    public void UpdateView() {
        if (EnemyModel == null)
            return;

        _enemyView.UpdateView(EnemyModel);

        if (EnemyModel.isCollided) {
            
        }
	}

    public void DestroyModel() {
        _enemyView.Destroy();
        ColliderInteractor.RemoveModel(EnemyModel);
        EnemyModel = null;
    }

    
}
