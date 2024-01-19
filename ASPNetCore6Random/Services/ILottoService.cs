namespace ASPNetCore6Random.Services
{
    using ASPNetCore6Random.ViewModels;

    public interface ILottoService
    {
        LottoViewModel Lottoing(int min, int max);
    }
}
