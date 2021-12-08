using Zenject;

public class InputInstaller : MonoInstaller
{
    public Joystick joystick;
    public override void InstallBindings()
    {
        Container
            .Bind<InputProvider>()
            .To<MixedInputProvider>()
            .AsCached()
            .WithArguments(joystick);
    }
}