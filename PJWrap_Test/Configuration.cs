namespace PJWrap_Test
{
    public class Configuration
    {
        public int LogLevel { get; set; } = 5;
        public int MaxCalls { get; set; } = 10;
        public bool EnableLog { get; set; } = true;
        public string LogFile { get; set; } = "";
        public bool EnableRegister { get; set; } = true;
        public string Username { get; set; } = "501";
        public string Password { get; set; } = "501Die";
        public string Server { get; set; } = "10.0.0.214";
        public string DialNumber { get; set; } = "502@10.0.0.214";
        public string TransfNumber { get; set; } = "500@10.0.0.214";
        public string DTMF { get; set; } = "1234";
        public string WavDirectory { get; set; } = "C:\\WAVS";
    }
}