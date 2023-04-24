using Godot;
using System;

public partial class GravityComponent : Node3D
{
    [Export]
    public Vector3 Gravity = new Vector3(0, -50, 0);

    private CharacterBody3D _parent;

    public override void _Ready()
    {
        _parent = GetParentOrNull<CharacterBody3D>();
    }

    public override void _PhysicsProcess(double delta)
    {
        if (_parent == null)
        {
            return;
        }
        var velocity = _parent.Velocity;
        velocity += Gravity * (float)delta;
        _parent.Velocity = velocity;
    }
}
