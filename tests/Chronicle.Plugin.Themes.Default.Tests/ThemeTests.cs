using System.Text.RegularExpressions;

namespace Chronicle.Plugin.Themes.Default.Tests;

public class ThemeTests
{
    private static readonly IReadOnlyList<Chronicle.Plugins.Models.ThemeDefinition> Themes = new DefaultThemesPlugin().GetThemes();

    [Fact]
    public void There_are_four_themes_with_unique_keys_and_names()
    {
        Assert.Equal(4, Themes.Count);
        Assert.Equal(Themes.Count, Themes.Select(t => t.Key).Distinct().Count());
        Assert.All(Themes, t => Assert.False(string.IsNullOrWhiteSpace(t.Label)));
        Assert.All(Themes, t => Assert.False(string.IsNullOrWhiteSpace(t.Description)));
    }

    [Fact]
    public void Every_theme_defines_exactly_the_variables_the_light_theme_does()
    {
        var expected = Themes.Single(t => t.Key == "light").Variables.Keys.OrderBy(k => k).ToList();
        foreach (var t in Themes)
            Assert.Equal(expected, t.Variables.Keys.OrderBy(k => k).ToList());
    }

    [Fact]
    public void Every_swatch_is_a_hex_colour()
    {
        foreach (var t in Themes)
            Assert.All(t.Swatches, s => Assert.Matches("^#[0-9a-fA-F]{6}$", s));
    }

    [Fact]
    public void The_version_it_reports_is_a_real_version_number()
    {
        Assert.Matches(@"^\d+\.\d+\.\d+", new DefaultThemesPlugin().Version);
    }
}
