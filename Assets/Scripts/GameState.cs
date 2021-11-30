using UniRx;

public static class GameState
{
    public static IntReactiveProperty score = new IntReactiveProperty();
    public static FloatReactiveProperty time = new FloatReactiveProperty();

    public static void reset()
    {
        score.Value = 0;
        time.Value = 0;
    }

}