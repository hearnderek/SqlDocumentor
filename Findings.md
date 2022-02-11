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