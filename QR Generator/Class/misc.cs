using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Updater.Controls;

namespace QR_Generator.Class
{
    public class misc
    {
        public static void QRgen(PictureBox pb, UCTextBox tb)
        {
            try
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(tb.Texts, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pb.Image = code.GetGraphic(5);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
