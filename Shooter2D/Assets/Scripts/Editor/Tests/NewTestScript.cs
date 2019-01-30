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
        bool isCollided = ColliderInteractor.IsIntersect(model1, model2);
        Assert.AreEqual(true, isCollided);
    }
    
    [Test]
    public void TestModelNotCollision() {
        var model1 = new PlayerModel(Vector2.zero, 1f, 6f);
        var model2 = new EnemyModel(Vector2.zero * 100f, 1f, 6f);
        bool isCollided = ColliderInteractor.IsIntersect(model1, model2);
        Assert.AreNotEqual(false, isCollided);
    }


}
