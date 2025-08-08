using MudBlazor;

namespace _05.WebUI.Components.Shared
{
    public class CustomMudTheme : MudTheme
    {
        public CustomMudTheme()
        {
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "0.5rem",
            };

            // === LIGHT THEME ===
            PaletteLight = new PaletteLight
            {
                Primary = "#006CB7",        // Biru Pertamina
                Secondary = "#ED1A2F",      // Merah Pertamina
                Tertiary = "#ADC32C",       // Hijau Pertamina

                Info = "#006CB7",
                Success = "#009640",
                Warning = "#FFA000",
                Error = "#E53935",

                Background = "#F9FAFC",     // Latar belakang bersih dan profesional
                Surface = "#FFFFFF",
                AppbarBackground = "#FFFFFF",
                DrawerBackground = "#FFFFFF",

                TextPrimary = "#1F1F1F",    // Hitam pekat
                TextSecondary = "#5F6368",  // Abu-abu modern
                AppbarText = "#1F1F1F",

                ActionDefault = "#5F6368",
                ActionDisabled = "#C2C2C2",
                ActionDisabledBackground = "#E0E0E0",
                TableLines = "#E5EAF2",
                Divider = "#E5EAF2"
            };

            // === DARK THEME ===
            PaletteDark = new PaletteDark
            {
                Primary = "#66B3E1",        // Biru terang Pertamina
                Secondary = "#F15C69",      // Merah muda terang
                Tertiary = "#C4DA58",       // Hijau terang

                Info = "#66B3E1",
                Success = "#81C784",
                Warning = "#FFD54F",
                Error = "#EF5350",

                Background = "#121212",
                Surface = "#1E1E1E",
                AppbarBackground = "#1E1E1E",
                DrawerBackground = "#1E1E1E",

                TextPrimary = "#F1F1F1",
                TextSecondary = "#A0A0A0",
                AppbarText = "#F1F1F1",

                ActionDefault = "#A0A0A0",
                ActionDisabled = "#616161",
                ActionDisabledBackground = "#424242",
                TableLines = "#2C2C2C",
                Divider = "#2C2C2C"
            };

            // === TYPOGRAPHY ===
            Typography = new Typography
            {
                Default = new DefaultTypography
                {
                    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "1rem",
                    FontWeight = "400",
                    LineHeight = "1.5",
                    LetterSpacing = "0.009375em"
                }
            };
        }
    }
}
