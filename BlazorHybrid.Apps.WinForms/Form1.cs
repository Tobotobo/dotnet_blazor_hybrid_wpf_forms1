using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using BlazorHybrid.Views;

namespace BlazorHybrid.Apps.WinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var blazorWebView1 = new BlazorWebView {
            Dock = DockStyle.Fill,
        };
        this.Controls.Add(blazorWebView1);

        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        blazorWebView1.HostPage = "wwwroot\\index.html";
        blazorWebView1.Services = services.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<Counter>("#app");
    }
}
