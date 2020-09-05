using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvelopeModifier.Modules
{
    public class UserDialogs
    {
        public string SelectFile(string text, string types = "", string filename = "") // I suck at C# so i have no fucking clue if this is good or not
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = types;
            openFileDialog.FileName = filename;
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                return openFileDialog.FileName;
            else
                return string.Empty;
        }

        public string SaveFile(string title, string types = "all|*.*")
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = types,
                Title = title
            };
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                return saveFileDialog.FileName;
            }
            return string.Empty;
        }
    }
}
