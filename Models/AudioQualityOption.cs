namespace YoutubeAudioDownloader.Models;

public sealed record AudioQualityOption(AudioQuality Value, string Label)
{
    public override string ToString()
    {
        return Label;
    }
}
