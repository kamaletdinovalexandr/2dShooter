using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UseCases;

public class NewTestScript {

    [Test]
    public void TestModelCollision() {
        var model1 = new PlayerModel(Vector2.zero, 1f, 6f);
        var model2 = new EnemyModel(Vector2.zero, 1f, 6f);
        ColliderInteractor.AddModel(model1);
        ColliderInteractor.AddModel(model2);
        ColliderInteractor.CheckCollide();
        ColliderInteractor.RemoveModel(model1);
        ColliderInteractor.RemoveModel(model2);
        Assert.AreEqual(true, model1.isCollided);
        Assert.AreEqual(true, model2.isCollided);
    }
    
    [Test]
    public void TestModelNotCollision() {
        var model1 = new PlayerModel(Vector2.one, 1f, 6f);
        var model2 = new EnemyModel(Vector2.one * 100f, 1f, 6f);
        ColliderInteractor.ClearModels();
        ColliderInteractor.AddModel(model1);
        ColliderInteractor.AddModel(model2);
        ColliderInteractor.CheckCollide();
        ColliderInteractor.RemoveModel(model1);
        ColliderInteractor.RemoveModel(model2);
        Assert.AreEqual(false, model1.isCollided);
        Assert.AreEqual(false, model2.isCollided);
    }


}
