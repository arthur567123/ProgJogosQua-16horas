using Godot;
using System;

public partial class NewScript : Node2D
{
    public override void _Ready()
    {
        GD.Print("Olá, Mundo!");
    }

    public override void _PhysicsProcess(double deltaDouble)
    {
        float delta = (float)deltaDouble;
        GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y - 100f * delta);
    }

}

