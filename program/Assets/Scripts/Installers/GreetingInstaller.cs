using Zenject;

public class GreetingInstaller : MonoInstaller<GreetingInstaller> {
    public GreetingConsumer greetingConsumerPrefab;
    public override void InstallBindings() {
        Container.Bind<IGreeting>().To<Greeting>().AsSingle();
        Container.BindFactory<GreetingConsumer, GreetingConsumer.Factory>().FromComponentInNewPrefab(greetingConsumerPrefab);
    }
}