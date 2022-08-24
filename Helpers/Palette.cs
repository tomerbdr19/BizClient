using System;
namespace BizClient.Helpers
{
    public class Palette
    {
        public string Key { get; set; }
        public bool IsChecked { get; set; }

        public Color PaletteDark { get; set; }
        public Color PaletteMed { get; set; }
        public Color PaletteLight { get; set; }

        public Color BackgroundColor { get; set; }
        public Color CardColor { get; set; }
        public Color ButtonColor { get; set; }
        public Color ButtonTextColor { get; set; }
        public Color TextColor { get; set; }
    }

    public static class BusinessPalettes {
        public static List<Palette> Palettes { get; } = new() {
        new() {
            Key = "1",
            PaletteDark =Color.FromHex("#0E4AB4"),
            PaletteMed = Color.FromHex("#EBF1F4"),
            PaletteLight = Color.FromHex("#FFFFFF"),
            BackgroundColor = Color.FromHex("#EBF1F4"),
            ButtonColor = Color.FromHex("#0E4AB4"),
            ButtonTextColor = Color.FromHex("#FFFFFF"),
            CardColor = Color.FromHex("#FFFFFF"),
            TextColor = Color.FromHex("#000000")
        },
        new() {
            Key = "2",
            PaletteDark =Color.FromHex( "#007d00"),
            PaletteMed = Color.FromHex("#00b300"),
            PaletteLight = Color.FromHex("#bfffbf"),
            BackgroundColor = Color.FromHex("#bfffbf"),
            ButtonColor = Color.FromHex("#005700"),
            ButtonTextColor = Color.FromHex("#FFFFFF"),
            CardColor = Color.FromHex("#FFFFFF"),
            TextColor = Color.FromHex("#000000")
        },
        new() {
            Key = "3",
            PaletteDark =Color.FromHex("#303f47"),
            PaletteMed = Color.FromHex("#d6f0ff"),
            PaletteLight = Color.FromHex("eaf8ff"),
            BackgroundColor = Color.FromHex("#303f47"),
            ButtonColor = Color.FromHex("#d6f0ff"),
            ButtonTextColor = Color.FromHex("#FFFFFF"),
            CardColor = Color.FromHex("#eaf8ff"),
            TextColor = Color.FromHex("#000000")
        },
        new() {
            Key = "4",

            PaletteDark =Color.FromHex("#7d0000"),
            PaletteMed = Color.FromHex("#b30000"),
            PaletteLight = Color.FromHex("#e08181"),
            BackgroundColor = Color.FromHex("#f1e8e6"),
            ButtonColor = Color.FromHex("#800015"),
            ButtonTextColor = Color.FromHex("#FFFFFF"),
            CardColor = Color.FromHex("#FFFFFF"),
            TextColor = Color.FromHex("#000000")
        },
        new() {
            Key = "1",
            IsChecked = true,
            PaletteDark = Color.FromHex( "#6918b4"),
            PaletteMed = Color.FromHex("#b691ff"),
            PaletteLight = Color.FromHex("#dbc8ff"),
            BackgroundColor = Color.FromHex("#dbc8ff"),
            ButtonColor = Color.FromHex("#6918b4"),
            ButtonTextColor = Color.FromHex("#FFFFFF"),
            CardColor = Color.FromHex("#FFFFFF"),
            TextColor = Color.FromHex("#000000")
        }
    };
    }
}

