using System.IO;

namespace Notepad.ApplicationService
{
    // Ações possíveis do usuário na interação com caixas de diálogo.
    public enum DialogResult
    {
        Yes,
        No,
        Cancel,
        Ok,
        Unknown
    }

    // Interface que representa serviços executados pela view.
    public interface IWindowServices
    {
        // Exibir diálogo "Sobre".
        void ShowAboutDialog();

        // Mostrar diálogo para salvar alterações.
        DialogResult ShowSaveChangesDialog();

        // Mostrar diálogo para carregar arquivo.
        FileInfo ShowOpenFileDialog();

        // Mostrar diálogo para salvar arquivo.
        FileInfo ShowSaveFileDialog();

        // Fechar janela.
        void CloseWindow();
    }
}
