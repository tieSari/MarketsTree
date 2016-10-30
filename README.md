## MarketsTree

This is ASP.NET MVC application for MarketsTree viewing. The tree is not collapsible, perhaps in the next version it will be ;)

###Project files I have created or updated:
```
Index.cshtml
MarketsDataModel.cs
MarketClassification.cs
HomeController.cs
Site.css
```

###Syntax for creating table Markets:
CREATE TABLE `Markets` (`NODE_ORDER` INTEGER PRIMARY KEY, `NODE_LEVEL` INTEGER NOT NULL, `NODE_NAME` VARCHAR(255) NOT NULL, `EXPOSURES` FLOAT;

It is possible to handle the tree structure using NODE_ORDER. It keeps nodes in original order.
