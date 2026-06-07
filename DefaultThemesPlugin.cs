using Chronicle.Plugins;
using Chronicle.Plugins.Models;

namespace Chronicle.Plugin.Themes.Default;

/// <summary>
/// Provides the four default Chronicle themes — Light, Dark, Navy &amp; Pink, and Dark Teal.
/// These ship with Chronicle out of the box, but because they are implemented as an
/// <see cref="IThemePlugin"/> they can be overridden or replaced by any other theme plugin.
/// </summary>
public sealed class DefaultThemesPlugin : IThemePlugin
{
    public string PluginId => "chronicle.plugin.themes.default";
    public string Name     => "Default Themes";
    public string Version  => "1.0.0";
    public string Author   => "Chronicle";

    public IReadOnlyList<ThemeDefinition> GetThemes() => AllThemes;

    // ── Light ──────────────────────────────────────────────────────────────────

    private static readonly ThemeDefinition Light = new(
        Key:         "light",
        Label:       "Light",
        Description: "Clean light theme — the default Chronicle look.",
        Swatches:    ["#f5f5f5", "#6200ea", "#ffffff"],
        Variables: new Dictionary<string, string>
        {
            ["--bg-primary"]           = "#f5f5f5",
            ["--bg-secondary"]         = "#ffffff",
            ["--bg-card"]              = "#e8e8e8",
            ["--accent"]               = "#6200ea",
            ["--accent-hover"]         = "#4a00b3",
            ["--accent-subtle"]        = "rgba(98, 0, 234, 0.08)",
            ["--accent-fg"]            = "#fff",
            ["--hover-bg"]             = "rgba(0, 0, 0, 0.04)",
            ["--text-primary"]         = "#212121",
            ["--text-secondary"]       = "#616161",
            ["--text-muted"]           = "#9e9e9e",
            ["--border"]               = "#d0d0d0",
            ["--success"]              = "#2e7d32",
            ["--warning"]              = "#e65100",
            ["--danger"]               = "#c62828",
            ["--status-success-bg"]    = "rgba(46, 125, 50, 0.1)",
            ["--status-success-fg"]    = "#2e7d32",
            ["--status-success-border"]= "rgba(46, 125, 50, 0.3)",
            ["--status-danger-bg"]     = "rgba(198, 40, 40, 0.1)",
            ["--status-danger-fg"]     = "#c62828",
            ["--status-danger-border"] = "rgba(198, 40, 40, 0.3)",
            ["--status-warning-bg"]    = "rgba(230, 81, 0, 0.1)",
            ["--status-warning-fg"]    = "#e65100",
            ["--status-warning-border"]= "rgba(230, 81, 0, 0.3)",
            ["--status-neutral-bg"]    = "rgba(0, 0, 0, 0.06)",
            ["--status-neutral-fg"]    = "#616161",
            ["--status-neutral-border"]= "#d0d0d0",
            ["--surface"]              = "#ffffff",
            ["--surface-raised"]       = "#ffffff",
            ["--surface-2"]            = "#f0f0f0",
            ["--shadow"]               = "0 2px 8px rgba(0, 0, 0, 0.1)",
        }
    );

    // ── Dark ───────────────────────────────────────────────────────────────────

    private static readonly ThemeDefinition Dark = new(
        Key:         "dark",
        Label:       "Dark",
        Description: "Classic dark theme with purple accents.",
        Swatches:    ["#121212", "#bb86fc", "#1e1e1e"],
        Variables: new Dictionary<string, string>
        {
            ["--bg-primary"]           = "#121212",
            ["--bg-secondary"]         = "#1e1e1e",
            ["--bg-card"]              = "#2a2a2a",
            ["--accent"]               = "#bb86fc",
            ["--accent-hover"]         = "#a070dc",
            ["--accent-subtle"]        = "rgba(187, 134, 252, 0.12)",
            ["--accent-fg"]            = "#fff",
            ["--hover-bg"]             = "rgba(255, 255, 255, 0.05)",
            ["--text-primary"]         = "#e0e0e0",
            ["--text-secondary"]       = "#a0a0a0",
            ["--text-muted"]           = "#606060",
            ["--border"]               = "#3a3a3a",
            ["--success"]              = "#66bb6a",
            ["--warning"]              = "#ffa726",
            ["--danger"]               = "#ef5350",
            ["--status-success-bg"]    = "#1a3a1a",
            ["--status-success-fg"]    = "#4caf50",
            ["--status-success-border"]= "#2e5e2e",
            ["--status-danger-bg"]     = "#3a1a1a",
            ["--status-danger-fg"]     = "#f44336",
            ["--status-danger-border"] = "#5e2e2e",
            ["--status-warning-bg"]    = "#2a2a1a",
            ["--status-warning-fg"]    = "#ffc107",
            ["--status-warning-border"]= "#4a4a2e",
            ["--status-neutral-bg"]    = "#2a2a2a",
            ["--status-neutral-fg"]    = "#888",
            ["--status-neutral-border"]= "#444",
            ["--surface"]              = "#1e1e1e",
            ["--surface-raised"]       = "#323232",
            ["--surface-2"]            = "#252525",
            ["--shadow"]               = "0 2px 8px rgba(0, 0, 0, 0.5)",
        }
    );

    // ── Navy & Pink ────────────────────────────────────────────────────────────

    private static readonly ThemeDefinition NavyPink = new(
        Key:         "navy-pink",
        Label:       "Navy & Pink",
        Description: "Deep navy blues with bold pink accents.",
        Swatches:    ["#1a1a2e", "#e94560", "#16213e"],
        Variables: new Dictionary<string, string>
        {
            ["--bg-primary"]           = "#1a1a2e",
            ["--bg-secondary"]         = "#16213e",
            ["--bg-card"]              = "#0f3460",
            ["--accent"]               = "#e94560",
            ["--accent-hover"]         = "#c73652",
            ["--accent-subtle"]        = "rgba(233, 69, 96, 0.08)",
            ["--accent-fg"]            = "#fff",
            ["--hover-bg"]             = "rgba(255, 255, 255, 0.04)",
            ["--text-primary"]         = "#eaeaea",
            ["--text-secondary"]       = "#a0a0b0",
            ["--text-muted"]           = "#606080",
            ["--border"]               = "#2a2a4a",
            ["--success"]              = "#2ecc71",
            ["--warning"]              = "#f39c12",
            ["--danger"]               = "#e74c3c",
            ["--status-success-bg"]    = "#1a3a1a",
            ["--status-success-fg"]    = "#4caf50",
            ["--status-success-border"]= "#2e5e2e",
            ["--status-danger-bg"]     = "#3a1a1a",
            ["--status-danger-fg"]     = "#f44336",
            ["--status-danger-border"] = "#5e2e2e",
            ["--status-warning-bg"]    = "#2a2a1a",
            ["--status-warning-fg"]    = "#ffc107",
            ["--status-warning-border"]= "#4a4a2e",
            ["--status-neutral-bg"]    = "#2a2a3a",
            ["--status-neutral-fg"]    = "#a0a0b0",
            ["--status-neutral-border"]= "#3a3a5a",
            ["--surface"]              = "#16213e",
            ["--surface-raised"]       = "#1e2d50",
            ["--surface-2"]            = "#1a2540",
            ["--shadow"]               = "0 2px 8px rgba(0, 0, 0, 0.4)",
        }
    );

    // ── Dark Teal ──────────────────────────────────────────────────────────────

    private static readonly ThemeDefinition DarkTeal = new(
        Key:         "dark-teal",
        Label:       "Dark Teal",
        Description: "Deep teal backgrounds with neon green accents.",
        Swatches:    ["#0a2424", "#00ff88", "#112e2e"],
        Variables: new Dictionary<string, string>
        {
            ["--bg-primary"]           = "#0a2424",
            ["--bg-secondary"]         = "#112e2e",
            ["--bg-card"]              = "#183c3c",
            ["--accent"]               = "#00ff88",
            ["--accent-hover"]         = "#00cc6e",
            ["--accent-subtle"]        = "rgba(0, 255, 136, 0.1)",
            ["--accent-fg"]            = "#000",
            ["--hover-bg"]             = "rgba(255, 255, 255, 0.05)",
            ["--text-primary"]         = "#ffffff",
            ["--text-secondary"]       = "#a8c4c4",
            ["--text-muted"]           = "#5a8080",
            ["--border"]               = "#265050",
            ["--success"]              = "#00ff88",
            ["--warning"]              = "#ffa726",
            ["--danger"]               = "#ef5350",
            ["--status-success-bg"]    = "rgba(0, 255, 136, 0.1)",
            ["--status-success-fg"]    = "#00ff88",
            ["--status-success-border"]= "rgba(0, 255, 136, 0.3)",
            ["--status-danger-bg"]     = "#3a1a1a",
            ["--status-danger-fg"]     = "#f44336",
            ["--status-danger-border"] = "#5e2e2e",
            ["--status-warning-bg"]    = "#2a2a1a",
            ["--status-warning-fg"]    = "#ffc107",
            ["--status-warning-border"]= "#4a4a2e",
            ["--status-neutral-bg"]    = "#1a3030",
            ["--status-neutral-fg"]    = "#a8c4c4",
            ["--status-neutral-border"]= "#265050",
            ["--surface"]              = "#112e2e",
            ["--surface-raised"]       = "#1f4848",
            ["--surface-2"]            = "#163838",
            ["--shadow"]               = "0 2px 8px rgba(0, 0, 0, 0.5)",
        }
    );

    // ── Aggregated list (declared after all themes so static init order is correct) ──

    private static readonly IReadOnlyList<ThemeDefinition> AllThemes = [Light, Dark, NavyPink, DarkTeal];
}
