using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerModel {
	public Vector2 Position { get; private set; }
	public int Lives { get; private set; }
	public float MoveSpeed { get; private set; }
	
	
	public Vector2 MoveDirection { get; set; }
	
	public event Action<Vector2> PositionChanged;
	public event Action<int> LivesChanged;

	public PlayerModel(Vector2 position, int lives, float moveSpeed) {
		Position = position;
		Lives = lives;
		MoveSpeed = moveSpeed;
	}

	public void Move(Vector2 direction) {
		Position += direction * Time.deltaTime * MoveSpeed;
		
		if (PositionChanged != null)
			PositionChanged(this.Position);
	}

	public void TakeDamage(int damage) {
		Lives -= damage;

		if (LivesChanged != null)
			LivesChanged(Lives);
	}
	
}
