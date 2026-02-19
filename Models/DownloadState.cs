namespace YoutubeAudioDownloader.Models;

public enum DownloadState
{
    Pending,
    Queued,
    Downloading,
    Completed,
    Failed,
    Stopped
}
