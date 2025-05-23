using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OpenIPC_Config.Models.Presets;

public class FileModification
{
    public string FileName { get; set; }
    public ObservableCollection<KeyValuePair<string, string>> Changes { get; set; }

    public FileModification()
    {
        Changes = new ObservableCollection<KeyValuePair<string, string>>();
    }
}