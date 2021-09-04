# 💪 Strong

![Build](https://github.com/arthursoas/strong/actions/workflows/ci.yml/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/Strong.Text.svg)](https://www.nuget.org/packages/Strong.Text)

#### Strong is a serie of extensions methods focused on making your C# stronger.

## Instalation

Using dotnet CLI
```powershell
dotnet add package Strong.Text
dotnet add package Strong.Numeric
```

## Available methods 

### Strong.Text
```cs
string text = "string";

text.ToBool();

text.FromSnakeCaseToCamelCase();
text.FromSnakeCaseToPascalCase();
text.FromSnakeCaseToKebabCase();
text.FromCamelCaseToSnakeCase();
text.FromCamelCaseToPascalCase();
text.FromCamelCaseToKebabCase();
text.FromPascalCaseToSnakeCase();
text.FromPascalCaseToCamelCase();
text.FromPascalCaseToKebabCase();

text.SplitCamelCase();

text.IsJson();

text.FromWrittenNumberToInt();
text.IsInteger();
text.IsFloat();

text.SuperTrim();
text.RemoveFirstOcurrence('s');
text.RemoveFirstOcurrence("str");
```

### Strong.Numeric
```cs
int number = 10;

number.ToWrittenNumber();

number.IsEven();
number.IsOdd();
number.IsDivisableBy(5);
```

