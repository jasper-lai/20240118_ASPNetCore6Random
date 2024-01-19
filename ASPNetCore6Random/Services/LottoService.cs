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

        public LottoViewModel Lottoing(int min, int max)
        {
            var result = new LottoViewModel();

            // Random(min, max): 含下界, 不含上界
            var yourNumber = _randomGenerator.Next(min, max);
            // 只要餘數是 9, 就代表中獎
            var message = (yourNumber % 10 == 9) ? "恭喜中獎" : "再接再厲";

            result.YourNumber = yourNumber;
            result.Message = message;

            return result;
        }
    }
}
