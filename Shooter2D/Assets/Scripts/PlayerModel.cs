using System;
using UnityEngine;

public class PlayerModel {
	public Vector2 Position { get; private set; }
	
	public float Size { get; private set; }
	public float MoveSpeed { get; private set; }
	
	public event Action<Vector2> PositionChanged;

	public PlayerModel(Vector2 position, float size, float moveSpeed) {
		Position = position;
		Size = size;
		MoveSpeed = moveSpeed;
	}

	public void Move(Vector2 direction) {
		Position += direction * Time.deltaTime * MoveSpeed;
		
		if (PositionChanged != null)
			PositionChanged(this.Position);
	}
	
}
