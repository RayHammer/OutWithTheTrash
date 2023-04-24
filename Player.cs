using Godot;
using System;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Parameters")]
    [Export]
    public float _jumpSpeed = 18;

    [ExportGroup("Components")]
    [Export]
    private GravityComponent _gravity;

    public override void _Ready() { }

    public override void _PhysicsProcess(double delta)
    {
        if (Input.IsActionJustPressed("jump"))
        {
            Velocity = Velocity with { Y = _jumpSpeed };
        }
        MoveAndSlide();
    }
}
