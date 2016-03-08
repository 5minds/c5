# Styling relationships

By default, all relationships are rendered as dashed grey lines as shown in the example diagram below.

![Default styling](images/styling-relationships-1.png)

However, the following characteristics of the relationships can be customized:

- Line thickness (pixels)
- Colour (HTML hex value)
- Line style (dashed or solid)
- Smooth (angled or curved)
- Font size (pixels)
- Width (of the description, in pixels)
- Position (of the description along the line, as a percentage from start to end)

## Tagging relationships

All relationships within a software architecture model can have one or more tags associated with them. A tag is simply a free-format string. By default, the .NET client library adds the ```"Relationship"``` tag to relationships. You can add your own custom tags to relationships using the ```AddTags()``` method on the relationship.

## Colour

To style a relationship, simply create a [RelationshipStyle](https://github.com/structurizr/dotnet/blob/master/Core/View/RelationshipStyle.cs) for a particular tag and specify the characteristics that you would like to change. For example, you can change the colour of all relationships as follows.

```c#
Styles styles = workspace.Views.Configuration.Styles;
styles.add(new RelationshipStyle(Tags.Relationship) { Color = "#ff0000" });
```

![Colouring all relationships](images/styling-relationships-2.png)

You can also change the colour of specific relationships, based upon their tag, as follows.

```c#
user.Relationships.ToList().ForEach(r => r.AddTags("HTTPS"));
styles.add(new RelationshipStyle(Tags.Relationship) { Color = "#3366FF" });
styles.add(new RelationshipStyle("HTTPS") { Color = "#33CC33", Dashed = false });
```

![Colouring relationships based upon tag](images/styling-relationships-3.png)

## Diagram key

[Structurizr](https://structurizr.com) will automatically add all relationship styles to a diagram key.

![The diagram key](images/styling-relationships-4.png)