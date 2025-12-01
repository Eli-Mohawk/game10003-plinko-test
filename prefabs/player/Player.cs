using Godot;
using System;

public partial class Player : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Freeze = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Freeze)
		{
			Vector2 newPos = Position;
			newPos.X = GetViewport().GetMousePosition().X;
			Position = newPos;

			if (Input.IsActionJustPressed("drop_player")) Freeze = false;
		}
	}
}
