﻿namespace BizClient;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new BootstrapShell();
    }
}
