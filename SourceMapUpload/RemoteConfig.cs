namespace SourceMapUpload;

public class RemoteConfig {
    public required string Host { get; set; }
    public int Port { get; set; }
    public required string User { get; set; }
    public required string LoginKeyPath { get; set; }
    public required string RemotePath { get; set; }
}
