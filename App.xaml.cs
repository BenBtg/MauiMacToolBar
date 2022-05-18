using System.Diagnostics;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using UIKit;

namespace MauiMacToolBar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
	}
	

	protected override Window CreateWindow(IActivationState activationState)
	{
		var mainWin = new Window();
		mainWin.HandlerChanged += MainWind_HandlerChanged;

		var rootNav = new MainPage();

		mainWin.Page = rootNav;
		return mainWin;
	}

	private void MainWind_HandlerChanged(object sender, EventArgs e)
	{
		var window = sender as Microsoft.Maui.Controls.Window;
		var uiWindow = window.Handler.PlatformView as UIWindow;

		if (uiWindow != null)
		{
			uiWindow.WindowScene.Titlebar.TitleVisibility = UITitlebarTitleVisibility.Hidden;
		}
	}
}
