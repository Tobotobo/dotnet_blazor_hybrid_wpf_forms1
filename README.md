# dotnet_blazor_hybrid_wpf1

## 概要
* WPF の Blazor アプリを構築する
* View をクラスライブラリに分離する

Windows Presentation Foundation (WPF) の Blazor アプリを構築する  
https://learn.microsoft.com/ja-jp/aspnet/core/blazor/hybrid/tutorials/wpf?view=aspnetcore-8.0  

### 詳細

```
dotnet new gitignore
dotnet new wpf -n BlazorHybrid.Apps.WPF
dotnet add BlazorHybrid.Apps.WPF package Microsoft.AspNetCore.Components.WebView.Wpf
```

BlazorHybrid.Apps.WPF\BlazorHybrid.Apps.WPF.csproj
```xml
<Project Sdk="Microsoft.NET.Sdk.Razor">
```
```xml
<RootNamespace>BlazorHybrid.Apps.WPF</RootNamespace>
```


```
dotnet run --project BlazorHybrid.Apps.WPF
```

```
dotnet publish -r win-x64 --self-contained BlazorHybrid.Apps.WPF /property:GenerateFullPaths=true -o publish/BlazorHybrid.Apps.WPF
```