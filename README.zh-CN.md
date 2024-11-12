# 英雄联盟客户端 (UWP)

[![English](https://img.shields.io/badge/docs-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/docs-한국어-green.svg)](README.ko.md)

这是一个使用通用 Windows 平台（UWP）技术高质量重现的英雄联盟客户端项目。该项目展示了 UWP 的各种实现技术，并演示了大型项目分布式设计的广泛技术方法。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnetgroup/leagueoflegends-uwp.svg)](https://github.com/jamesnetgroup/leagueoflegends-uwp/stargazers)
[![Forks](https://img.shields.io/github/forks/jamesnetgroup/leagueoflegends-uwp.svg)](https://github.com/jamesnetgroup/leagueoflegends-uwp/network/members)
[![Issues](https://img.shields.io/github/issues/jamesnetgroup/leagueoflegends-uwp.svg)](https://github.com/jamesnetgroup/leagueoflegends-uwp/issues)

#### 英雄联盟 XAML 基础系列：
<div style="text-align: center;">
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/543a4bd8-ace3-4d1a-acab-36f5b7f8b200.png" width="8%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/0d8bd5b4-c898-4bcf-af91-b4267551934f.png" width="20%"/>
    <img src="https://jamesnetdev.blob.core.windows.net/articleimages/77eaa9cd-865b-430d-89c6-0e10ead0abd5.png" width="8%"/>
</div>

<br/>

[英雄联盟客户端 (WPF)](https://github.com/jamesnetgroup/leagueoflegends-wpf)  
[英雄联盟客户端 (Uno-Platform)](https://github.com/jamesnetgroup/leagueoflegends-uno)  
[英雄联盟客户端 (WinUI 3)](https://github.com/jamesnetgroup/leagueoflegends-winui3)  
[英雄联盟客户端 (UWP)](https://github.com/jamesnetgroup/leagueoflegends-uwp)

> 如果你是 WPF、Uno Platform 或 WinUI 3 开发者，你将看到基于 XAML 的技能如何过渡到 UWP 开发。

## 项目概述

我们自 2008 年以来一直在研究并积累基于 XAML 的技术经验。多年来，WPF、UWP 以及 WinUI 3 等各种技术不断发展，使我们能够将技能扩展到不同的 Windows UI 框架。

我们发布的这个英雄联盟 UWP 版本建立在基于 XAML 的丰富 UX 设计、C# 的面向对象设计以及系统化的项目结构之上。这是继我们的 WPF、Uno Platform 和 WinUI 3 版本的英雄联盟项目之后的新系列。

本项目展示了如何使用 UWP 实现大型项目。通过将复杂控件实现为 CustomControls，我们旨在为开发者提供丰富的学习材料。此外，它还包括 UWP 的各种技术实现案例，展示了如何在实际项目中利用这个框架的强大功能。

特别是，本项目展示了大型应用程序分布式设计的广泛方法。它演示了如何通过模块化结构、高效的状态管理和可扩展的架构来构建和管理复杂的应用程序。

Jamesnet.Core 框架库基于 .NET Standard 2.0 设计，可以在 WPF、Uno Platform、WinUI 3 以及现在的 UWP 中相同地工作。该库作为 Jamesnet.Window 提供给 WPF，作为 Jamesnet.Uno 提供给 Uno Platform，作为 Jamesnet.WinUI3 提供给 WinUI 3，现在作为 Jamesnet.UWP 提供给通用 Windows 平台。

在本项目中，我们直接引用了 Jamesnet.Core 和 Jamesnet.UWP 的实际源代码，让您可以学习基于 XAML 的框架的设计方法。

我们希望这个项目不仅能在 UWP 中广泛使用，还能作为各种基于 XAML 的平台的参考，为 Windows 应用程序开发开辟新的视野。

<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/d3b13869-d0f8-457d-90d9-5a637c500b4a" width="49%"/>
<img src="https://github.com/user-attachments/assets/45920f83-41b9-4924-8e92-86123d15a2a4" width="49%"/>
<img src="https://github.com/user-attachments/assets/4e41c4af-1a98-48b0-9c44-05ac48f0430e" width="49%"/>
<img src="https://github.com/user-attachments/assets/78415f9d-732c-4940-881c-beed7a6e9620" width="49%"/>
<img src="https://github.com/user-attachments/assets/b376f4ed-4ffd-4528-b1cc-6b0483f442e1" width="49%"/>
<img src="https://github.com/user-attachments/assets/3bc0d881-577e-4aa2-8802-698169d701a5" width="49%"/>
<img src="https://github.com/user-attachments/assets/0cedb504-2f27-43b8-87ed-34e85f1d7b83" width="49%"/>
<img src="https://github.com/user-attachments/assets/f5e80933-9d18-47c1-81c6-eb55a680972a" width="49%"/>
<img src="https://github.com/user-attachments/assets/d8aa51d5-c6e1-4a9a-95f8-e20a7c6f9f91" width="49%"/>
<img src="https://github.com/user-attachments/assets/c2cc6c22-8345-4333-83a2-61ab08883652" width="49%"/>
<img src="https://github.com/user-attachments/assets/fd6aa0ca-14c1-4446-b6cb-2617bc15b373" width="49%"/>
<img src="https://github.com/user-attachments/assets/be84fe63-4fb5-4a6c-a537-9907b88e648b" width="49%"/>
<img src="https://github.com/user-attachments/assets/24db2d8b-b839-42b2-be8a-2fc6266dad77" width="49%"/>
<img src="https://github.com/user-attachments/assets/642ccf0d-f2df-4adc-bb87-b1246cbda0b7" width="49%"/>
<img src="https://github.com/user-attachments/assets/bece2bfd-1bb9-436e-b928-929d3706398c" width="49%"/>


## 支持的平台

本项目支持以下平台：

- **Windows 10/11**：在 Windows 10 版本 1809（内部版本 17763）或更高版本上作为原生 UWP 应用程序运行
- **Xbox**：支持 Xbox One 和 Xbox Series X|S
- **HoloLens**：支持 Microsoft HoloLens 设备
- **IoT**：支持 Windows IoT Core 设备

注意：这个应用程序使用 UWP 开发，可以通过 Microsoft Store 部署到各种 Windows 10/11 设备上。

## 如何运行

当你克隆此存储库时，它默认设置为 .NET 环境。你可以立即使用 Windows 上的 Visual Studio 2022 构建和运行它。

### 配置：

项目文件配置如下。你可以根据需要调整 Windows SDK 版本。

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>AppContainerExe</OutputType>
    <TargetFramework>net8.0-windows10.0.19041.0</TargetFramework>
    <TargetPlatformMinVersion>10.0.17763.0</TargetPlatformMinVersion>
    <TargetPlatformVersion>10.0.19041.0</TargetPlatformVersion>
    <UseUWP>true</UseUWP>
  </PropertyGroup>
</Project>
```

## 为项目做贡献

欢迎你的贡献！随时提交 Pull Requests。

## 许可证

本项目采用 MIT 许可证。详情请参见 [LICENSE](LICENSE) 文件。
