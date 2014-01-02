## Diffbot Client Library for .NET

This project provides a client library that make it easy to access [Diffbot](http://www.diffbot.com) API with .NET.

### Usage Sample

```csharp
using Diffbot.Client;

var diffbot = new DiffBotClient("<your api key>");
var article = await diffbot.ExtractArticle("<web page url>");
```

### Source Code

https://github.com/KriaSoft/Diffbot

### Credits

Developed by [Konstantin Tarkus](http://tarkus.me) ([@koistya](https://angel.co/koistya)), [KriaSoft](http://www.kriasoft.com).

### License

This project is licensed under the **Apache License 2.0**. Refer to
[LICENSE.txt](https://github.com/KriaSoft/Diffbot/blob/master/LICENSE.txt) for more information.

### Feedback

Have questions or need help? Email me at [hello@tarkus.me](mailto:hello@tarkus.me?title=DIffbot+on+GitHub).