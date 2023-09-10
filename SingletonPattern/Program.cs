using SingletonPattern;

var b1 = LoadBalancer.GetInstance();
var b2 = LoadBalancer.GetInstance();
var b3 = LoadBalancer.GetInstance();
var b4 = LoadBalancer.GetInstance();
// Confirm these are the same instance
if (b1 == b2 && b2 == b3 && b3 == b4)
{
    Console.WriteLine("Same instance\n");
}

var balancer = LoadBalancer.GetInstance();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Dispatch request to: " + balancer.NextServer().IP);
}