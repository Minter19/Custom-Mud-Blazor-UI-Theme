# 🎨 Custom MudBlazor Theme

This project implements a **custom theme** using [MudBlazor](https://mudblazor.com/), styled to match specific design preferences (e.g. Pertamina branding or your own color system). The theme is applied globally using the `MudThemeProvider`.

---

## 🔧 How to Use the Custom Theme

To activate the custom theme in your **Blazor Server** or **Blazor WebAssembly** application, follow the steps below:

### ✅ 1. Import the Theme Class

In your `MainLayout.razor`, import the namespace where your custom theme is located:

```razor
@using _05.WebUI.Components.Shared
```

### ✅ 2. Add `<MudThemeProvider>`

Wrap your layout content with the `MudThemeProvider` component and set the theme and dark mode flag:

```razor
<MudThemeProvider Theme="@MyCustomTheme" IsDarkMode="@_isDarkMode" />
```

You can place this at the root of your layout or `App.razor` depending on your app structure.

### ✅ 3. Define the Theme Properties

In the `@code` block of `MainLayout.razor`, define the following properties:

```razor
@code {
    private bool _isDarkMode = false; // Change to true to enable dark mode
    private CustomMudTheme MyCustomTheme = new CustomMudTheme();
}
```

---

## 📁 Theme Location

Make sure your custom theme class is located in:

```
_05.WebUI/
└── Components/
    └── Shared/
        └── CustomMudTheme.cs
```

This class should inherit from `MudTheme` and define your color palette, layout properties, and typography.

---

## 💡 Optional: Enable Theme Toggle

To allow users to switch between light and dark mode, bind `_isDarkMode` to a toggle button or switch:

```razor
<MudSwitch @bind-Checked="_isDarkMode" Color="Color.Primary" Label="Dark Mode" />
```

---

## 🔗 Resources

- [MudBlazor Documentation](https://mudblazor.com/)
- [Blazor Layouts](https://learn.microsoft.com/en-us/aspnet/core/blazor/layouts)
- [Blazor WebAssembly vs Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models)

---

## 📄 License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

---

Made with ❤️ using MudBlazor and Blazor.
