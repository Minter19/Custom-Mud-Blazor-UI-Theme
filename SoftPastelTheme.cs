using MudBlazor;

namespace _05.WebUI.Components.Shared
{
    public class CustomMudTheme : MudTheme
    {
        public CustomMudTheme()
        {
            // Set a soft, rounded border radius
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "8px",
            };

            // --- LIGHT THEME ---
            PaletteLight = new PaletteLight
            {
                // Main palette colors with a softer, pastel feel
                Primary = "#60935D",    // A soft, natural green
                Secondary = "#F0EAD6",  // A creamy, light beige
                Tertiary = "#C8E4B2",   // A pale, gentle green
                Info = "#60935D",       // Same as primary

                // Essential palette colors for user feedback
                Success = "#4CAF50",    // A standard, clear green for success
                Warning = "#FFB300",    // A bright, visible orange for warnings
                Error = "#E53935",      // A classic red for errors

                // Backgrounds for a clean, light interface
                Background = "#FCFCFC",      // Almost white for a clean canvas
                Surface = "#FFFFFF",         // Pure white for cards and surfaces
                AppbarBackground = "#FCFCFC",
                DrawerBackground = "#FCFCFC",

                // Optimized text colors for readability on light backgrounds
                TextPrimary = "#333333",     // A very dark gray for high contrast
                TextSecondary = "#757575",   // A medium gray for secondary text
                AppbarText = "#333333",

                // Action and divider colors for a subtle feel
                ActionDefault = "#757575",
                ActionDisabled = "#BDBDBD",
                ActionDisabledBackground = "#E0E0E0",
                TableLines = "#E0E0E0",
                Divider = "#E0E0E0",
            };

            // --- DARK THEME ---
            // A well-balanced dark theme with good contrast
            PaletteDark = new PaletteDark
            {
                // Harmonious dark theme colors
                Primary = "#9CCC65",    // A bright green that stands out
                Secondary = "#6A6A6A",  // A neutral dark gray
                Tertiary = "#8DAB6C",
                Info = "#9CCC65",

                // Essential palette colors
                Success = "#81C784",
                Warning = "#FFD54F",
                Error = "#EF5350",

                // Background and surface colors
                Background = "#121212",      // A true dark background
                Surface = "#1F1F1F",         // Dark gray surface for depth
                AppbarBackground = "#1F1F1F",
                DrawerBackground = "#1F1F1F",

                // Text colors for readability on dark backgrounds
                TextPrimary = "#E0E0E0",
                TextSecondary = "#A4A4A4",
                AppbarText = "#E0E0E0",

                // Action and divider colors
                ActionDefault = "#A4A4A4",
                ActionDisabled = "#616161",
                ActionDisabledBackground = "#424242",
                TableLines = "#424242",
                Divider = "#424242",
            };

            // Typography settings for optimal reading experience
            Typography = new Typography
            {
                Default = new DefaultTypography
                {
                    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "1rem", // Use 'rem' for better scalability
                    FontWeight = "400",
                    LineHeight = "1.6", // Increased line height for better readability
                    LetterSpacing = "0.009375em"
                },
            };
        }
    }
}
