using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace QuietGuard
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioHandler : Page
    {
        public AudioHandler()
        {

            this.InitializeComponent();

        }

        private static int _clicks = 0;

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            _clicks += 1;
            progressBar1.Value = _clicks;
            if (_clicks >= progressBar1.Maximum) _clicks = 0;
        }



    }
}
