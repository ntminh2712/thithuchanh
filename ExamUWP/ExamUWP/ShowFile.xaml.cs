using ExamUWP.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ExamUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowFile : Page
    {
        ObservableCollection<FileEntity> ListFile = new ObservableCollection<FileEntity>();
        public ShowFile()
        {

            this.InitializeComponent();
            getFile();
        }
        private async void getFile()
        {
            IReadOnlyList<StorageFile> items = await ApplicationData.Current.LocalFolder.GetFilesAsync();
            foreach (StorageFile file in items)
            {
                FileEntity files_ = new FileEntity();
                files_.name = file.Name;
                files_.content = file.Name;
                ListFile.Add(files_);
            }
        }
    }
}
