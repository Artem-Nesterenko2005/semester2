// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

namespace RunningButton;

/// <summary>
/// class for launch form.
/// </summary>
internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new ButtonGame());
    }
}
