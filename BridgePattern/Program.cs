using BridgePattern;

IImplementation implementation = new ConcreteImplementationA();
Abstraction abstraction = new ExtendedAbstraction(implementation);
abstraction.Operation();

implementation = new ConcreteImplementationB();
abstraction = new ExtendedAbstraction(implementation);
abstraction.Operation();
