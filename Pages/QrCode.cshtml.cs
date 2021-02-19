using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QRCodeApp;

namespace QRCodeWebApp.Pages
{
  public class QrCodeModel : PageModel
  {
    public IActionResult OnGet()
    {
      //Gera a imagem do QRCode com array de bytes
      var image = QrCodeGenerator.GenerateByteArray("https://github.com/gilsonDias92/");
      return File(image, "image/jpeg");
    }
  }
}