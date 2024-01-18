namespace ASPNetCore6Random.Services
{
    using ASPNetCore6Random.ViewModels;
    using ASPNetCore6Random.Wrapper;

    public class LottoService : ILottoService
    {
        private readonly IRandomGenerator _randomGenerator;

        public LottoService(IRandomGenerator randomGenerator) 
        {
            _randomGenerator = randomGenerator;
        }

        public LottoViewModel Lottoing()
        {
            var result = new LottoViewModel();

            // Random(min, max): 含下界, 不含上界
            var yourNumber = _randomGenerator.Next(0, 10);
            var message = (yourNumber == 9) ? "恭喜中獎" : "再接再厲";

            result.YourNumber = yourNumber;
            result.Message = message;

            return result;
        }
    }
}
