namespace Boom_Manager_Project
{
    class Options
    {
        private static Options _opt;

        public static Options OptionsInstance()
        {
            return _opt ?? (_opt = new Options());
        }

        public string UsualClient = "0";
    }
}
