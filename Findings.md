# Findings
Documenting everything that I've come to understand.

## Parse Query
Microsoft.SqlServer.Management.SqlParser.Parser.ParseResult parseResult = Microsoft.SqlServer.Management.SqlParser.Parser.Parser.Parse(query);

### 32bit vs 64bit
メッセージ: 
テスト メソッド TestSqlDocumentor.UnitTests.ProduceError が例外をスローしました: 
System.BadImageFormatException: ファイルまたはアセンブリ 'Microsoft.SqlServer.Management.SqlParser, Version=16.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91'、またはその依存関係の 1 つが読み込めませんでした。間違ったフォーマットのプログラムを読み込もうとしました。

  スタック トレース: 
Program.Main(String[] args)
UnitTests.RunProgram(String query) 行 11
UnitTests.ProduceError() 行 25

Look like this is happening because I'm running my program in the wrong byteness.
- [Success] Trying both SqlDocumentor and TestSqlDocumentor in 64bit -- and it worked

## Parse Result Errors
Looks like we get nice information about warning and errors within the TSQL

if(parseResult.Errors.Any())
{
    Console.WriteLine("We've had some issues when parsing the query");

    int i = 0;
    foreach (var error in parseResult.Errors)
    {
        i++;
        if (error.IsWarning)
            Console.WriteLine($"[Warning {i}]");
        else
            Console.WriteLine($"[Error {i}]");

        Location start = error.Start;
        Console.WriteLine($"At Line: {start.LineNumber} and character: {start.ColumnNumber}");
        Console.WriteLine(error.Message);

    }
}

## ParseResult

parseResult.BatchCount = number of batches in script


## ParseResult.Script
A tree of tokens representing the script. Has an XML representation.

RetrieveAllIdentifiers()
appears to be a simple select * SqlParser.SqlCodeDom.SqlIdentifier objects within tree

## SqlParser Glossary
Batch = Section of a sql script with 'GO'|EOF as the end of batch delimiter


## SqlSelectStatement
THIS is what I want to document

## SqlQueryWithClause = WITH
contiains "SqlCommonTableExpression"s which in turn each contain a "SqlQuerySpecification"




# Looking at the tree

Using the Visitor/Strategy? patten I can walk the tree and do things with that.

Microsoft's built-in visitor interface is a little bit too bulky for what I want, so I'll just use my own tree walker


As long as I'm walking the tree, I can basically figure out whatever I need. The hardest part is predicting how MS with tokenize everything. 




# Metadata -- A slog

I'm trying to figure out how to get Metadata binded to my queries...


This seems to do what I want... BUT I don't know how to get a working metadataProvider.

Microsoft.SqlServer.Management.SqlParser.Binder.BinderProvider.CreateBinder( IMetadataProvider metadataProvider )



Looking into the decompiled source of SSMS, I found that RadLangSvc -> LanguageService.cs has a method called RefreshServiceCache, which also resets the bindercache...

it's using 
using Microsoft.SqlServer.Management.SqlParser.MetadataProvider;
using Microsoft.SqlServer.Management.SqlParser.Parser;

Now it's all about figuring out how they initialize object from these libs...

MetadataDisplayInfoProvider is used...



MethodNameAndParamLocations methodNameAndParams = Microsoft.SqlServer.Management.SqlParser.Intellisense.Resolver.GetMethodNameAndParams(parseResult, request.Line + 1, request.Col + 1, (IMetadataDisplayInfoProvider) this.displayInfoProvider);


Couldn't find the connection between provider and database...



## Update 2022-02-13
Wow, Microsoft did not make metadata easy to work with here.
I believe that if I fillout all of their needed interfaces -- which are too many -- I can get their bind implementation to work.

For now I am just going to stick with my own self built approach that uses their base objects.