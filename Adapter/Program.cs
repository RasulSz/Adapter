using Adapter;

SocketForTools socketForTools = new();
Dishwasher dishwasher = new();
Fridge fridge = new();
socketForTools.PowerGone(dishwasher);
Console.WriteLine("\n");
socketForTools.PowerGone(fridge);
Console.WriteLine("\n");
Iphone iphone = new();
///socketForTools.PowerGone(iphone);
AdapterP adapter = new(iphone);
socketForTools.PowerGone(adapter);