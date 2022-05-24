namespace backgroundClient.Classes
{
    public class ProgramShortcut
    {
        public string FilePath { get; set; }
        public bool isWindowsApp { get; set; }
        public bool isOpenAllShortcut { get; set; } = false;

        public string name { get; set; } = "";
        public string Arguments = "";
        public string WorkingDirectory = Paths.exeString;
 

        public ProgramShortcut() // needed for XML serialization
        {

        }

    }
}
