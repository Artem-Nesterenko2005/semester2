// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

namespace RunningButton;

/// <summary>
/// class for playing with a running button.
/// </summary>
public partial class ButtonGame : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ButtonGame"/> class.
    /// </summary>
    public ButtonGame()
    {
        this.InitializeComponent();
    }

    /// <summary>
    /// when you press the button, it ends the game.
    /// </summary>
    /// <param name="sender">event sender.</param>
    /// <param name="e">event args.</param>
    private void ButtonClick(object sender, MouseEventArgs e)
    {
        this.Controls.Remove(this.button);
        this.winText.Visible = true;
    }

    /// <summary>
    /// moves the button when you hover over it.
    /// </summary>
    /// <param name="sender">event sender.</param>
    /// <param name="e">event args.</param>
    private void MoveButton(object sender, EventArgs e)
    {
        Random random = new ();
        this.ActiveControl!.Location = new Point(random.Next(12, 582), random.Next(12, 331));
    }
}
