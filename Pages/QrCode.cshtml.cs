using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QRCodeApp;

namespace QRCodeWebApp.Pages
{
  public class QrCodeModel : PageModel
  {
    public IActionResult OnGet([FromQuery] string url)
    {
      //Gera a imagem do QRCode com array de bytes
      var image = QrCodeGenerator.GenerateByteArray(url);
      return File(image, "image/jpeg");
    }
  }
}