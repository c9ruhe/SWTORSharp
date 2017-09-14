# SWTORSharp
Wrapper for [SWTORData.com](http://swtordata.com) Api.

## Installation 

1. [Clone the repo](https://github.com/c9ruhe/SWTORSharp.git) or [download the zip file](https://github.com/c9ruhe/SWTORSharp/archive/master.zip).

2. Build the project and reference the `.dll` for your own app.

## Usage
To use the API, you must have an API key you can get from [here](http://swtordata.com/api)
```c#
using SWTORSharp.Core;
using System;
try
{
var client = new SWTORClient("apikey");
var item = client.GetItemById(1);
Console.WriteLine(item.DisplayName); //Outputs "Diabolist's Superior Lightsabe"
}
catch (SWTORException ex)
{
    //Do whatever.
}
```
You can also get all items, or search items.
```c#

var client = new SWTORClient("apikey");
ItemList list = client.GetItems(query: "Saber"); //Outputs about 2799 items with all pages combined.
foreach (var item in list.Objects)
{
       Console.WriteLine($"{item.DisplayName} -- {item.Id} -- {item.Quality.Name}");
}
```

## Requirements

.Net Framework 4.6.2

RestSharp.NetCore

Newtonsoft.Json

## Questions?

Your best bet is to [create an issue](https://github.com/c9ruhe/SWTORSharp/issues/new), or you can find me in the [SWTORData](https://discord.gg/7WwKKHM)/[C#](https://discord.gg/GB4FNGp) Discord Servers. I don't bite.

## License
Read [LICENSE](https://github.com/c9ruhe/SWTORSharp/blob/master/LICENSE)