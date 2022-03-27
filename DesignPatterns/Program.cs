using DesignPatterns;
using DesignPatterns.Behavioural.Iterator;
using DesignPatterns.Behavioural.Observer;
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Template;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;

ClientTemplate client;

// Creational Patterns
client = new FactoryClient();
client.Run();
client = new AbstractFactoryClient();
client.Run();
client = new BuilderClient();
client.Run();
client = new PrototypeClient();
client.Run();
client = new SingletonClient();
client.Run();

// Structural Patterns
client = new AdapterClient();
client.Run();
client = new CompositeClient();
client.Run();
client = new DecoratorClient();
client.Run();

// Behavioral Patterns
client = new IteratorClient();
client.Run();
client = new ObserverClient();
client.Run();
client = new StrategyClient();
client.Run();
client = new TemplateClient();
client.Run();
