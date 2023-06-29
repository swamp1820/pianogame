using Godot;
using System;

public partial class Button : Godot.Button
{
	private string _keyName; 
	private Sprite2D _keySprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_keyName = this.Name;
		_keySprite = GetParent<Sprite2D>();
		this.ButtonDown += new Action(Down);
		this.ButtonUp += new Action(Up);
	}

    private void Up()
    {
		GD.Print($"{_keyName} released");
		_keySprite.Texture = GD.Load<Texture2D>("res://assets/keys/key.png");
    }

    private void Down()
    {
		GD.Print($"{_keyName} pressed");
		_keySprite.Texture = GD.Load<Texture2D>("res://assets/keys/key_pressed.png");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
