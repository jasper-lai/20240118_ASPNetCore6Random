namespace ASPNetCore6Random.Controllers
{
    using ASPNetCore6Random.Services;
    using ASPNetCore6Random.Wrapper;
    using Microsoft.AspNetCore.Mvc;

    public class LottoController : Controller
    {
        private readonly ILottoService _lottoService;

        public LottoController(ILottoService lottoService)
        {
            _lottoService = lottoService;
        }

        public IActionResult Index()
        {
            var result = _lottoService.Lottoing();
            return View(result);
        }
    }
}
