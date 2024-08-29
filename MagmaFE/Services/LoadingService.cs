namespace MagmaFE.Services;

public class LoadingService
{
    public event Action OnChange;
    private bool isLoading;

    public bool IsLoading
    {
        get => isLoading;
        set
        {
            if (isLoading != value)
            {
                isLoading = value;
                OnChange?.Invoke();
            }
        }
    }
}