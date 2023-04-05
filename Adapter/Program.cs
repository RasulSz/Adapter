using Adapter;

SocketForTools socketForTools = new();
Dishwasher dishwasher = new();
Fridge fridge = new();
socketForTools.PowerGone(dishwasher);
socketForTools.PowerGone(fridge);
Iphone iphone = new();
///socketForTools.PowerGone(iphone);
AdapterP adapter = new(iphone);
socketForTools.PowerGone(adapter);