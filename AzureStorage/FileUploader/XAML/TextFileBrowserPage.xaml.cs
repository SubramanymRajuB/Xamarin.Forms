using System;
using System.Text;
using Xamarin.Forms;

namespace FileUploader.XAML
{
    public partial class TextFileBrowserPage : ContentPage
    {
        string fileName;

        public TextFileBrowserPage()
        {
            InitializeComponent();
        }

        async void OnGetFileListButtonClicked(object sender, EventArgs e)
        {
            activityIndicator.IsVisible = true;
            var fileList = await AzureStorage.GetFilesListAsync(ContainerType.Text);
            listView.ItemsSource = fileList;
            editor.Text = string.Empty;
            deleteButton.IsEnabled = false;
            activityIndicator.IsVisible = false;
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                activityIndicator.IsVisible = true;
                fileName = e.SelectedItem.ToString();
                var byteData = await AzureStorage.GetFileAsync(ContainerType.Text, fileName);
                var text = Encoding.UTF8.GetString(byteData);
                editor.Text = text;
                deleteButton.IsEnabled = true;
                activityIndicator.IsVisible = false;
            }
            listView.SelectedItem = null;
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                bool isDeleted = await AzureStorage.DeleteFileAsync(ContainerType.Text, fileName);
                if (isDeleted)
                {
                    OnGetFileListButtonClicked(sender, e);
                }
            }
        }
    }
}
