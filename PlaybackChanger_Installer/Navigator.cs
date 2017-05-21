namespace PlaybackChanger_Installer
{
    public class Navigator
    {
        private FormMain _container;

        public Navigator(System.Windows.Forms.Form container)
        {
            _container = container as FormMain;
        }

        public void NavigateToLocation()
        {
            _container.NavigateToLocation();
        }
        public void NavigateToOptions()
        {
            _container.NavigateToOptions();
        }
        public void NavigateToInstall()
        {
            _container.NavigateToInstall();
        }
        public Installer GetInstaller()
        {
            return _container.GetInstaller();
        }
        public void CancelInstall(bool force)
        {
            _container.CancelApplication(this, force);
        }
        public void InstallerDone()
        {
            _container.InstallerDone();
        }
    }
}
