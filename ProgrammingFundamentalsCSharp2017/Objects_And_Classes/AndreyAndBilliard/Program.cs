int n = int.Parse(Console.ReadLine());
var products = new Dictionary<string, double>();

for (int i = 0; i < n; i++)
{
    string[] inputTokens = Console.ReadLine().Split('-').ToArray();
    string name = inputTokens[0];
    double price = double.Parse(inputTokens[1]);
    products[name] = price;
}
var clientOrders = new Dictionary<string, Dictionary<string, int>>();
while (true)
{   
    string input = Console.ReadLine();
    if (input == "end of clients")
    {
        break;
    }
    string[] inputTokens = input.Split('-', ',').ToArray();
    string clientName = inputTokens[0];
    string productName = inputTokens[1];
    int quantity = int.Parse(inputTokens[2]);
    if (!products.ContainsKey(productName))
    {
        continue;
    }
    if (!clientOrders.ContainsKey(clientName))
    {
        clientOrders.Add(clientName, new Dictionary<string, int>());
    }
    if (clientOrders[clientName].ContainsKey(productName))
    {
        clientOrders[clientName][productName] += quantity;
    }
    else
    {
        clientOrders[clientName].Add(productName, quantity);
    }
}

double totalBill = 0; 

foreach (var clientOrder in clientOrders.OrderBy(x => x.Key))
{
    Console.WriteLine(clientOrder.Key);
    foreach (var order in clientOrder.Value)
    {
        Console.WriteLine($"-- {order.Key} - {order.Value}");
    }

    double bill =  clientOrder.Value.Sum(x => x.Value * products[x.Key]);

    totalBill += bill;
    Console.WriteLine($"Bill: {bill:F2}");  
}
Console.WriteLine($"Total bill: {totalBill:F2}");
