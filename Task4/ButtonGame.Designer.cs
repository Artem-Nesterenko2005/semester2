// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

namespace RunningButton;

partial class ButtonGame
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button = new Button();
        winText = new TextBox();
        SuspendLayout();
        // 
        // button
        // 
        button.Location = new Point(301, 195);
        button.Name = "button";
        button.Size = new Size(169, 82);
        button.TabIndex = 0;
        button.Text = "Нажми";
        button.UseVisualStyleBackColor = true;
        button.MouseClick += ButtonClick;
        button.MouseEnter += MoveButton;
        button.MouseHover += MoveButton;
        // 
        // winText
        // 
        winText.Location = new Point(280, 223);
        winText.Name = "winText";
        winText.ReadOnly = true;
        winText.Size = new Size(206, 27);
        winText.TabIndex = 1;
        winText.Text = "Вы победили";
        winText.TextAlign = HorizontalAlignment.Center;
        winText.Visible = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(winText);
        Controls.Add(button);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button;
    private TextBox winText;
}
