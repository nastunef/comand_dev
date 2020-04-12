using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MyMsgBox
    {
        public static void showError(String errorMsg, String titleErrorMsg = "Ошибка")
        {
           MessageBox.Show(errorMsg,titleErrorMsg,MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
        }

        /*
         * @return true == Да, false == нет 
         * 
         * **/
        public static bool showAsk(String askMsg, String titleAskMsg = "Вопрос")
        {
            var res = MessageBox.Show(askMsg, titleAskMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            return res == DialogResult.Yes;
        }

        public static void showInfo(String infoMsg, String titleInfoMsg = "Информация")
        {
            MessageBox.Show(infoMsg, titleInfoMsg, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
