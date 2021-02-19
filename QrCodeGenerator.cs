using System.Drawing;
using QRCoder;
using System.IO;

namespace QRCodeApp
{
  public static class QrCodeGenerator
  {

    // método que retorna em Bitmap a imagem padrão do QRCodeGenerator 
    public static Bitmap GenerateImage(string url)
    {
      // criamos um objeto 
      var qrGenerator = new QRCodeGenerator();
      
      // qrCodeData armazena os dados do QR code
      var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
      
      // instância do qr code com os dados
      var qrCode = new QRCode(qrCodeData);
      
      // gera a imagem do qr code com a qualidade (xx)
      var qrCodeImage = qrCode.GetGraphic(10);
      
         return qrCodeImage;
    }

    // também precisamos dessa imagem em array de bytes

        public static byte[] GenerateByteArray(string url)
        {
            var image = GenerateImage(url);
            return ImageToByte(image);
        }

        private static byte[] ImageToByte(Image img)
        {
            using var stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }
    }
}