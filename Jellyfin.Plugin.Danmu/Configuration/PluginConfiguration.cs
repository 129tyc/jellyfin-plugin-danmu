using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Danmu.Configuration;

/// <summary>
/// The configuration options.
/// </summary>
public enum SomeOptions
{
    /// <summary>
    /// Option one.
    /// </summary>
    OneOption,

    /// <summary>
    /// Second option.
    /// </summary>
    AnotherOption
}

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        ToAss = false;
        AssFont = string.Empty;
        AssFontSize = string.Empty;
        AssLineCount = string.Empty;
        AssSpeed = string.Empty;
        AssTextOpacity = string.Empty;

    }

    /// <summary>
    /// �Ƿ�ͬʱ����ASS��ʽ��Ļ.
    /// </summary>
    public bool ToAss { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    public string AssFont { get; set; }

    /// <summary>
    /// �����С.
    /// </summary>
    public string AssFontSize { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    public string AssLineCount { get; set; }

    /// <summary>
    /// �ƶ��ٶ�.
    /// </summary>
    public string AssSpeed { get; set; }

    /// <summary>
    /// ͸����.
    /// </summary>
    public string AssTextOpacity { get; set; }

}
