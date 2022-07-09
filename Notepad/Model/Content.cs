using Notepad.Framework;
using System.IO;

namespace Notepad.Model
{
    // Representa o conteúdo a ser salvo em um arquivo.
    // Herda de 'NotificationEnable' para poder avisar a view sobre mudanças nas properties.
    public class Content : Bindable
    {
        // Texto do documento.
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                SetValue(ref text, value);
            }
        }

        // Arquivo atrelado ao texto.
        private FileInfo fileInfo;
        public FileInfo FileInfo
        {
            get { return fileInfo; }
            set
            {
                SetValue(ref fileInfo, value);
            }
        }

        // Salvar o conteúdo no arquivo.
        public void Save()
        {
            if (fileInfo != null)
            {
                File.WriteAllText(fileInfo.FullName, text);
            }
        }

        // Carrega o conteúdo do arquivo.
        public void Load()
        {
            if (fileInfo != null)
            {
                Text = File.ReadAllText(fileInfo.FullName);
            }
        }
    }
}
